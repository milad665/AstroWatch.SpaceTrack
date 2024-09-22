using System;

namespace AstroWatch.SpaceTrack.Tle
{
    public class TleData
    {
        public string Name { get; set; }
        public char Classification { get; set; }
        public int SatelliteNumber { get; set; }
        public string InternationalDesignator { get; set; } // Includes Launch Year, Launch Number, Piece
        public int LaunchYear { get; set; }
        public int LaunchNumber { get; set; }
        public string LaunchPiece { get; set; }
        public int EpochYear { get; set; }
        public double EpochDay { get; set; }
        public DateTime Epoch { get; set; }
        public double FirstDerivativeOfMeanMotion { get; set; }
        public double SecondDerivativeOfMeanMotion { get; set; }
        public double BStarDragTerm { get; set; }
        public int EphemerisType { get; set; }
        public int ElementSetNumber { get; set; }
        public double Inclination { get; set; }
        public double RightAscension { get; set; }
        public double Eccentricity { get; set; }
        public double ArgumentOfPerigee { get; set; }
        public double MeanAnomaly { get; set; }
        public double MeanMotion { get; set; }
        public int RevolutionNumberAtEpoch { get; set; }
        public int Checksum1 { get; set; }
        public int Checksum2 { get; set; }
    }
}

