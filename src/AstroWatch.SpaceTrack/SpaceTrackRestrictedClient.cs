using AstroWatch.SpaceTrack.BasicSpaceData.Clients;
using AstroWatch.SpaceTrack.Infrastructure;

namespace AstroWatch.SpaceTrack
{
    public class SpaceTrackRestrictedClient : ISpaceTrackRestrictedClient
    {
        private readonly ISpaceTrackAuthenticator _authenticator;

        public SpaceTrackRestrictedClient(ISpaceTrackAuthenticator authenticator)
        {
            _authenticator = authenticator;
            
            Car = new CarClient(authenticator);
            ConjunctionDataMessage = new ConjunctionDataMessageClient(authenticator);
            CurrentEvent = new CurrentEventClient(authenticator);
            Delete = new DeleteClient(authenticator);
            File = new FileClient(authenticator);
            FileHistory = new FileHistoryClient(authenticator);
            FileReceived = new FileReceivedClient(authenticator);
            FilesTransfer = new FilesTransferClient(authenticator);
            Folder = new FolderClient(authenticator);
            Maneuver = new ManeuverClient(authenticator);
            ManeuverHistory = new ManeuverHistoryClient(authenticator);
        }
        
        public CarClient Car { get; }
        public ConjunctionDataMessageClient ConjunctionDataMessage { get; }
        public CurrentEventClient CurrentEvent { get; }
        public DeleteClient Delete { get; }
        public FileClient File { get; }
        public FileHistoryClient FileHistory { get; }
        public FileReceivedClient FileReceived { get; }
        public FilesTransferClient FilesTransfer { get; }
        public FolderClient Folder { get; }
        public ManeuverClient Maneuver { get; }
        public ManeuverHistoryClient ManeuverHistory { get; }
    }
}