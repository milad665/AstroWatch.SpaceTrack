# AstroWatch.SpaceTrack

AstroWatch.SpaceTrack is a .NET SDK designed to integrate with the SpaceTrack API, simplifying access to satellite data, orbital elements, and space debris tracking. This SDK allows developers to seamlessly interact with the SpaceTrack API to build space-related applications with ease.

## Features

- Retrieve satellite catalog data, orbital elements, and TLE (Two-Line Element) sets.
- Perform satellite position and tracking queries.
- Query launch and decay events for space objects.
- Support for API authentication.

## Installation

To install AstroWatch.SpaceTrack via [NuGet](https://www.nuget.org/packages/AstroWatch.SpaceTrack/):

```bash
dotnet add package AstroWatch.SpaceTrack
```

Alternatively, you can install it using the NuGet Package Manager in Visual Studio by searching for `AstroWatch.SpaceTrack`.

## Getting Started

The SDK consist of two main clients: the public client and the restricted client. Public client facilitates access to the publicly available SpaceTrack data "Classes" and the restricted client does the same for restricted ones. To learn more about space track API concepts visit  [Introduction to the API - SpaceTrack.org](https://www.space-track.org/documentation#/api)

The public classes are end-to-end tested but the restricted ones are not simply because I don't have access to them. I would encourage anyone with access to those endpoints to contribute to this repository by testing and extending the SDK.

You can initialize the SDK in two ways:


### Using Dependency Injection
1. Add the following json property to appsettings.json:
```json
  "SpaceTrackSettings": {
    "Username": "YOUR_USERNAME",
    "Password": "YOUR_PASSWORD"
  }
```
2. Register the configurations and SpaceTrackSDK services to the ServiceCollection. Bellow is an example of how it's done in an ASP.NET core application's Program.cs file: 
```csharp
using AstroWatch.SpaceTrack;
using AstroWatch.SpaceTrack.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Register the configurations
builder.Services.Configure<SpaceTrackSettings>(builder.Configuration.GetSection(SpaceTrackSettings.SectionName));
// Register SpaceTrack services
builder.Services.AddSpaceTrack();


builder.Services.AddMvc();
builder.Services.AddOptions();
builder.Services.AddControllers();
var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
```

3. Inject the client(s) to your application classes:
```csharp
private ISpaceTrackPublicClient _spaceTrackPublicClient;

// If needed:
// private ISpaceTrackRestrictedClient _spaceTrackRestrictedClient;

public TestController(ISpaceTrackPublicClient spaceTrackPublicClient)
{
    _spaceTrackPublicClient = spaceTrackPublicClient;
}
```
### Without Dependency Injection

To access the SpaceTrack API, you need a valid account on [SpaceTrack.org](https://www.space-track.org). Once you have your credentials, authenticate as follows:

```csharp
using AstroWatch.SpaceTrack;

var authenticator = new SpaceTrackAuthenticator(new SpaceTrackSettings("YOUR_USERNAME", "YOUR_PASSWORD"));
var spaceTrackPublic = new SpaceTrackPublicClient(authenticator);

// *** if needed, this is how you can also instanciate the restricted client
// var spaceTrackRestricted = new SpaceTrackRestrictedClient(authenticator);
```

### Fetching Data

To get data from space track you should simply follow the pattern below:

await **_SpaceTrackClient\
    .Class\
    [.FilterOn(c => c.PredicateName).Operator(Value or Condition)]\
    [.FilterOn(c => c.PredicateName).Operator(Value or Condition)]\
    ...\
    .GetAsSomeFormatAsync();_**

Below you can see a few examples of how different types of data are queried:

```csharp
//Store the whole decay history in a csv file
await spaceTrack.Decay.GetAsCsvAsync("DecayData.csv");

//Get updates from the past 10 days for objects in LEO in TLE string format  
var updatesForLeoObjectsInPastTenDays = await spaceTrack.GeneralPerturbations
    .FilterOn(p => p.MeanMotion)
      .IsGreaterThan(11.25)
    .FilterOn(p => p.Epoch)
      .IsGreaterThan(PredicateValue.FromNumberOfDaysAgo(10))
    .GetAsTleStringAsync();

//Get updates from the past 10 days for objects in GEO desrialized as a list of TLE data objects
var updatesForGeoObjectsInPastTenDays = await spaceTrack.GeneralPerturbations
        .FilterOn(p => p.MeanMotion)
          .IsBetween(0.99, 1.01)
        .FilterOn(p => p.Eccentricity)
          .IsLessThan(0.01)
        .GetAsTleDataAsync();

//Get a list of all decayed satellites deserialized as a list of objects
var decayedSatellites = await spaceTrack.SatelliteCatalog
    .FilterOn(s => s.DecayDate)
      .IsNotNull()
    .GetAsDeSerializedListAsync();
```

## Contributing

We welcome contributions! If you'd like to contribute, please fork the repository and submit a pull request.

## Contact

For any inquiries or support, feel free to reach out via [milad665@gmail.com](mailto:milad665@gmail.com).

---

Happy Coding! 🚀
