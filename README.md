# Actions SDK for .NET

Actions is a programming model for writing cloud-native applications which are distributed, dynamically scaled, and loosely coupled in nature.

Actions SDK for .NET allows you to implement the Virtual Actor model, based on the actor design pattern. This SDK can run locally, in a container and in any distributed systems environment.

This repo builds the following packages:

- Microsoft.Actions.Actors
- Microsoft.Actions.Actors.AspNetCore

## Getting Started

### Prerequesites

Each project is a normal C# Visual Studio 2019 project. At minimum, you need [.NET Core SDK 2.2](https://www.microsoft.com/net/download/windows) to build and generate NuGet packages.

We recommend installing [Visual Studio 2019](https://www.visualstudio.com/vs/) which will set you up with all the .NET build tools and allow you to open the solution files. Community Edition is free and can be used to build everything here.

### Build

To build everything and generate NuGet packages, run dotnet cli commands. NuGet packages will be dropped in a *bin* directory at the repo root.

```bash
# Build SDK
dotnet build -c Debug  # for release, -c Release

# Run unit-test
dotnet test

# Generate nuget packages in /bin/Debug/
dotnet pack
```

Each project can also be built individually directly through Visual Studio.

## Releases

Until we publish nuget packages to nuget.org, you can download the latest nuget packages signed by Microsoft from [Preview Kit release](https://github.com/actionscore/previewkit/releases).

## Add nuget to your project

Assume that you download nuget packages to you local disk, /pkg/nugets/.

```bash
# Add Microsoft.Actions.Actors nuget package
dotnet add package Microsoft.Actions.Actors -v 1.0.0-preview001 -s /pkg/nugets/

# Add Microsoft.Actions.Actors.AspNetCore nuget package
dotnet add package Microsoft.Actions.Actors.AspNetCore -v 1.0.0-preview001 -s /pkg/nugets/
```

## Documentation

These articles will help get you started with Actions Runtime and Actions Actors:

- [Getting started with Actions Actor](docs/get-started-actions-actor.md)
- [Actions CLI](https://github.com/actionscore/cli)
- [Actions API Specification](https://github.com/actionscore/spec)