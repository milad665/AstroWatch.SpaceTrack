using AstroWatch.SpaceTrack.Tle;

namespace AstroWatch.Tests
{
    public class TleParserTests
    {
        [Fact]
        public void ParseTle_ValidInput_ReturnsTleData()
        {
            // Arrange
            string name = "ISS (ZARYA)";
            string line1 = "1 25544U 98067A   21275.91843130  .00000553  00000-0  19017-4 0  9991";
            string line2 = "2 25544  51.6431  19.3697 0004254 169.1873 304.5075 15.48984961271949";

            // Act
            var result = TleParser.ParseTle(name, line1, line2);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(25544, result.SatelliteNumber); // Satellite Number
            Assert.Equal("ISS (ZARYA)", result.Name); // Satellite Name

            // Launch details
            Assert.Equal(1998, result.LaunchYear); // Launch Year (from International Designator 98067A)
            Assert.Equal(67, result.LaunchNumber); // Launch Number (from International Designator)
            Assert.Equal("A", result.LaunchPiece); // Launch Piece (from International Designator)

            // Epoch time
            Assert.Equal(21, result.EpochYear); // Epoch Year
            Assert.Equal(275.91843130, result.EpochDay, 5); // Epoch Day
            var expectedEpoch = new DateTime(2021, 10, 2, 22, 2, 32, 464).AddMicroseconds(320); // Calculated epoch datetime
            Assert.Equal(expectedEpoch, result.Epoch); // Epoch DateTime

            // First derivative of mean motion
            Assert.Equal(0.00001106, result.FirstDerivativeOfMeanMotion, 5); // First Derivative of Mean Motion

            // Second derivative of mean motion
            Assert.Equal(0, result.SecondDerivativeOfMeanMotion,
                5); // Second Derivative of Mean Motion (00000-0 means it's zero)

            // BSTAR drag term
            Assert.Equal(1.9017e-5, result.BStarDragTerm, 5); // BSTAR Drag Term

            // Ephemeris Type
            Assert.Equal(0, result.EphemerisType); // Ephemeris Type

            // Element Set Number
            Assert.Equal(999, result.ElementSetNumber); // Element Set Number

            // Line 2 Checks
            Assert.Equal(51.6431, result.Inclination, 4); // Inclination
            Assert.Equal(19.3697, result.RightAscension, 4); // Right Ascension of Ascending Node
            Assert.Equal(0.0004254, result.Eccentricity, 7); // Eccentricity
            Assert.Equal(169.1873, result.ArgumentOfPerigee, 4); // Argument of Perigee
            Assert.Equal(304.5075, result.MeanAnomaly, 4); // Mean Anomaly
            Assert.Equal(15.48984961, result.MeanMotion, 8); // Mean Motion

            // Revolution Number at Epoch
            Assert.Equal(27194, result.RevolutionNumberAtEpoch); // Revolution Number at Epoch

            // Checksum
            Assert.Equal(1, result.Checksum1); // Checksum for Line 1
            Assert.Equal(9, result.Checksum2); // Checksum for Line 2
        }

        [Fact]
        public void ParseTle_InvalidLineLength_ThrowsArgumentException()
        {
            // Arrange
            string name = "ISS (ZARYA)";
            string line1 = "1 25544U 98067A";  // invalid length
            string line2 = "2 25544  51.6431  19.3697 0004254 169.1873 304.5075 15.48984961271943";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => TleParser.ParseTle(name, line1, line2));
        }

        [Fact]
        public void ParseTle_InvalidChecksumLine1_ThrowsFormatException()
        {
            // Arrange
            string name = "ISS (ZARYA)";
            string line1 = "1 25544U 98067A   21275.91843130  .00000553  00000-0  19017-4 0  8888";  // Invalid checksum
            string line2 = "2 25544  51.6431  19.3697 0004254 169.1873 304.5075 15.48984961271943";

            // Act & Assert
            Assert.Throws<FormatException>(() => TleParser.ParseTle(name, line1, line2));
        }

        [Fact]
        public void ParseTle_InvalidChecksumLine2_ThrowsFormatException()
        {
            // Arrange
            string name = "ISS (ZARYA)";
            string line1 = "1 25544U 98067A   21275.91843130  .00000553  00000-0  19017-4 0  9991";
            string line2 = "2 25544  51.6431  19.3697 0004254 169.1873 304.5075 15.48984961271999";  // Invalid checksum

            // Act & Assert
            Assert.Throws<FormatException>(() => TleParser.ParseTle(name, line1, line2));
        }

        [Fact]
        public void ExtractTleSet_ValidInput_ReturnsListOfTleData()
        {
            // Arrange
            string tleData = @"
                ISS (ZARYA)
                1 25544U 98067A   21275.91843130  .00000553  00000-0  19017-4 0  9991
                2 25544  51.6431  19.3697 0004254 169.1873 304.5075 15.48984961271949
                Hubble Space Telescope
                1 20580U 90037B   21275.91843130  .00000553  00000-0  19017-4 0  9995
                2 20580  28.4692  53.4321 0001234 291.1234 109.5124 14.69723759123458";

            // Act
            var result = TleParser.ExtractTleSet(tleData);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal(25544, result[0].SatelliteNumber);
            Assert.Equal(20580, result[1].SatelliteNumber);
        }

        [Fact]
        public void ExtractTleSet_InvalidTleData_SkipsInvalidTle()
        {
            // Arrange
            string tleData = @"
                ISS (ZARYA)
                1 25544U 98067A   21275.91843130  .00000553  00000-0  19017-4 0  9991
                2 25544  51.6431  19.3697 0004254 169.1873 304.5075 15.48984961271949
                Invalid TLE
                1 20580U 90037B";  // Invalid TLE length

            // Act
            var result = TleParser.ExtractTleSet(tleData);

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);  // Should skip the invalid TLE entry
            Assert.Equal(25544, result[0].SatelliteNumber);
        }
    }
}
