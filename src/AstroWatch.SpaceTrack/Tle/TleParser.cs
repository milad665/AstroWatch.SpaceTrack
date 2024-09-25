using System;
using System.Collections.Generic;
using System.Globalization;

namespace AstroWatch.SpaceTrack.Tle
{
    public class TleParser
    {
        public static TleData ParseTle(string name, string line1, string line2)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(line1) ||
                string.IsNullOrWhiteSpace(line2))
            {
                throw new ArgumentException("Name and TLE lines must be provided.");
            }

            if (line1.Length < 69 || line2.Length < 69)
            {
                throw new ArgumentException("TLE lines must be at least 69 characters long.");
            }

            var tleData = new TleData();
            tleData.Name = name.Trim();

            // Validate Checksums
            if (!ValidateChecksum(line1))
            {
                throw new FormatException("Checksum validation failed for Line 1 of TLE.");
            }

            if (!ValidateChecksum(line2))
            {
                throw new FormatException("Checksum validation failed for Line 2 of TLE.");
            }
            
            // Parsing Line 1
            try
            {
                // Satellite Number
                var satNumber = line1.Substring(2, 5).Trim();
                if (satNumber[0] >= 'A' && satNumber[0] <= 'Z')
                {
                    var value = 0;
                    if (satNumber[0] < 'I')
                        value = satNumber[0] - 55;
                    else if (satNumber[0] < 'O')
                        value = satNumber[0] - 56;
                    else
                        value = satNumber[0] - 57;
                    
                    tleData.SatelliteNumber = int.Parse(satNumber.Substring(1)) + value;    
                }
                else
                {
                    tleData.SatelliteNumber = int.Parse(satNumber);
                }
                
                tleData.Classification = line1[7];
                
                // International Designator (Launch Year, Launch Number, Piece)
                tleData.InternationalDesignator = line1.Substring(9, 8).Trim();

                // Launch Year
                int launchYear = int.Parse(line1.Substring(9, 2).Trim());
                tleData.LaunchYear = launchYear >= 57 ? 1900 + launchYear : 2000 + launchYear;

                // Launch Number
                tleData.LaunchNumber = int.Parse(line1.Substring(11, 3).Trim());

                // Launch Piece
                tleData.LaunchPiece = line1.Substring(14, 3).Trim();
                
                // Epoch Year and Day
                tleData.EpochYear = int.Parse(line1.Substring(18, 2).Trim());
                tleData.EpochDay = double.Parse(line1.Substring(20, 12).Trim(), CultureInfo.InvariantCulture);

                // Convert epoch to DateTime
                int year = tleData.EpochYear >= 57 ? 1900 + tleData.EpochYear : 2000 + tleData.EpochYear;
                tleData.Epoch = ConvertEpochToDateTime(year, tleData.EpochDay);

                // First Time Derivative of Mean Motion
                tleData.FirstDerivativeOfMeanMotion = double.Parse(line1.Substring(33, 10).Replace(" ",""), CultureInfo.InvariantCulture) * 2;

                // Second Time Derivative of Mean Motion
                tleData.SecondDerivativeOfMeanMotion = ParseExponentialNotation(line1.Substring(44, 8)) * 6;

                // BSTAR Drag Term
                tleData.BStarDragTerm = ParseExponentialNotation(line1.Substring(53, 8));

                // Ephemeris Type
                tleData.EphemerisType = int.Parse(line1.Substring(62, 1));

                // Element Set Number
                tleData.ElementSetNumber = int.Parse(line1.Substring(64, 4).Trim());
                
                tleData.Checksum1 = int.Parse(line1.Substring(68, 1));
            }
            catch (Exception ex)
            {
                throw new FormatException("Error parsing Line 1 of TLE: " + ex.Message);
            }

            // Parsing Line 2
            try
            {
                // Inclination
                tleData.Inclination = double.Parse(line2.Substring(8, 8).Replace(" ",""), CultureInfo.InvariantCulture);

                // Right Ascension of the Ascending Node
                tleData.RightAscension = double.Parse(line2.Substring(17, 8).Trim(), CultureInfo.InvariantCulture);

                // Eccentricity
                string eccentricityStr = line2.Substring(26, 7).Trim();
                tleData.Eccentricity = double.Parse("0." + eccentricityStr, CultureInfo.InvariantCulture);

                // Argument of Perigee
                tleData.ArgumentOfPerigee = double.Parse(line2.Substring(34, 8).Replace(" ",""), CultureInfo.InvariantCulture);

                // Mean Anomaly
                tleData.MeanAnomaly = double.Parse(line2.Substring(43, 8).Replace(" ",""), CultureInfo.InvariantCulture);

                // Mean Motion
                tleData.MeanMotion = double.Parse(line2.Substring(52, 11).Trim(), CultureInfo.InvariantCulture);

                // Revolution Number at Epoch
                tleData.RevolutionNumberAtEpoch = int.Parse(line2.Substring(63, 5).Trim());
                
                tleData.Checksum2 = int.Parse(line2.Substring(68, 1));

            }
            catch (Exception ex)
            {
                throw new FormatException("Error parsing Line 2 of TLE: " + ex.Message);
            }

            return tleData;
        }
        
        public static List<TleData> ExtractTleSet(string tleResult)
        {
            var tleSet = new List<TleData>();
                
            var tleSetLines = tleResult.Replace("\r", "").Split('\n');
            var tleName = (string) null;
            var tleLine1 = (string) null;
                
            foreach (var ln in tleSetLines)
            {
                if (string.IsNullOrWhiteSpace(ln))
                    continue;

                var line = ln.Trim();
                var str = line.Split(' ')[0];
                if (str != "1" && str != "2")
                {
                    tleName = line.Substring(1).Trim();
                    tleLine1 = (string) null;
                }
                else
                {
                    if (str == "1")
                        tleLine1 = line;
                    if (str == "2" && tleLine1 != null)
                        tleSet.Add(ParseTle(tleName, tleLine1, line));
                }
            }

            return tleSet;
        }

        private static DateTime ConvertEpochToDateTime(int year, double epochDay)
        {
            DateTime epoch = new DateTime(year, 1, 1).AddDays(epochDay - 1);
            return epoch;
        }

        private static double ParseExponentialNotation(string value)
        {
            // Remove any spaces
            value = value.Trim();

            var offset = value.StartsWith("-") ? 1 : 0;
            // Insert decimal point after first non-space character
            string mantissaPart = value.Substring(0, 5).Insert( offset, "0.").Replace(" ", "");
            string exponentPart = value.Substring(5+offset).Replace(" ", "");

            // Replace '+' with nothing, '-' remains for negative exponents
            exponentPart = exponentPart.Replace("+", "");

            // Combine mantissa and exponent
            string formattedValue = mantissaPart + "e" + exponentPart;

            // Parse as double
            return double.Parse(formattedValue, NumberStyles.Float, CultureInfo.InvariantCulture);
        }
        
        private static bool ValidateChecksum(string line)
        {
            if (line.Length < 69)
                return false;

            int checksumDigit = int.Parse(line.Substring(68, 1));
            int computedChecksum = 0;

            for (int i = 0; i < 68; i++)
            {
                char c = line[i];

                if (char.IsDigit(c))
                {
                    computedChecksum += (int)char.GetNumericValue(c);
                }
                else if (c == '-')
                {
                    computedChecksum += 1;
                }
                // All other characters contribute 0
            }

            computedChecksum = computedChecksum % 10;

            return computedChecksum == checksumDigit;
        }
    }
}