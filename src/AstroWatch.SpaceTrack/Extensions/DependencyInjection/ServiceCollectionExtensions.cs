using AstroWatch.SpaceTrack.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace AstroWatch.SpaceTrack.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSpaceTrack(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISpaceTrackPublicClient, SpaceTrackPublicClient>();
            serviceCollection.AddScoped<ISpaceTrackRestrictedClient, SpaceTrackRestrictedClient>();
            serviceCollection.AddScoped<ISpaceTrackAuthenticator, SpaceTrackAuthenticator>();

            return serviceCollection;
        }
        
        public static IServiceCollection AddSpaceTrack(this IServiceCollection serviceCollection, SpaceTrackSettings settings)
        {
            serviceCollection.AddSingleton(settings);
            serviceCollection.AddScoped<ISpaceTrackPublicClient, SpaceTrackPublicClient>();
            serviceCollection.AddScoped<ISpaceTrackRestrictedClient, SpaceTrackRestrictedClient>();
            serviceCollection.AddScoped<ISpaceTrackAuthenticator, SpaceTrackAuthenticator>();

            return serviceCollection;
        }
    }
}