namespace AstroWatch.SpaceTrack
{
    public class SpaceTrackSettings
    {
        public const string SectionName = "SpaceTrackSettings";
        
        public SpaceTrackSettings()
        {}
        
        public SpaceTrackSettings(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}