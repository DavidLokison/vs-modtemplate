# TODO
- CakeBuild or DotNetRun target to run the Client or Server dll with the debug pipeline in place

# Vintage Story Mod Template
This repository contains a boilerplate code mod template for Vintage Story using standard dotnet build pipelines without any solution files for Visual Studio and the likes. It makes use of a GitHub Actions powered [Build Pipeline] to build and upload the mod as a zipped artifact so it can be downloaded and tested.

#### TODO: DRY the sauce again
Following the [DRY Principle](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), I made the `.csproj` file as small as can be to outsource the options to a common `Directory.Build.props` file on my [Build Pipeline] repository and also make use of GitHub Actions to build, attest and draft a new release with automatic release notes generation based off a common `CHANGELOG.md` file.

### WIP: Usage
- Run `dotnet msbuild -t CakeBuild` to build the mod and provide a test environment.
- Run `dotnet msbuild -t CakeBuild -c Release` to build and publish a zipped artifact.
- Run `dotnet msbuild -t RunClient` to launch a test environment with the mod installed. (Use `-tl:off` to get all game logs cause they tend to get swallowed by the dotnet wrapper.)

### Usage
- (Optional) For enabling local builds check out the [Build Pipeline] and create your mod projects inside that directory so the `Directory.Build.props` file gets pushed into 
- Get a copy of this template by either using the "Use this Template" button on GitHub, cloning the repository or downloading and unpacking a `.zip` file of the repository.
- (When building locally) Set the environment variable `VINTAGE_STORY` to your Vintage Story installation path and run `dotnet build` with whatever command line arguments you might need to debug or perftest.
- Code your mod, commit and push to a GitHub repository.
- Use Workflow Dispatch to build a test build or draft a new release.
- (Untested) You may use [act](https://github.com/nektos/act) to run the GitHub Actions powered build pipeline locally.

### Reasoning
#### TODO: Re-add reasoning but to the variant with CakeBuild

[Build Pipeline]: https://github.com/DavidLokison/vs-build
