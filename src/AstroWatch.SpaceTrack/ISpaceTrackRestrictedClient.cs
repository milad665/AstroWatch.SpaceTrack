using AstroWatch.SpaceTrack.BasicSpaceData.Clients;

namespace AstroWatch.SpaceTrack
{
    public interface ISpaceTrackRestrictedClient
    {
        CarClient Car { get; }
        ConjunctionDataMessageClient ConjunctionDataMessage { get; }
        CurrentEventClient CurrentEvent { get; }
        DeleteClient Delete { get; }
        FileClient File { get; }
        FileHistoryClient FileHistory { get; }
        FileReceivedClient FileReceived { get; }
        FilesTransferClient FilesTransfer { get; }
        FolderClient Folder { get; }
        ManeuverClient Maneuver { get; }
        ManeuverHistoryClient ManeuverHistory { get; }
    }
}