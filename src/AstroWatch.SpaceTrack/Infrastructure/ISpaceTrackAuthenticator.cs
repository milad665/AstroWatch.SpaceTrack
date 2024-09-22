using System.Collections.Generic;
using System.Threading.Tasks;

namespace AstroWatch.SpaceTrack.Infrastructure
{
    public interface ISpaceTrackAuthenticator
    {
        Task<IEnumerable<string>> LoginAsync();
    }
}