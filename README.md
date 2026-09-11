# Vintage Story Mod Template
This repository contains a boilerplate code mod template for Vintage Story using standard dotnet build pipelines without any solution files for Visual Studio and the likes. It makes use of a GitHub Actions powered [Build Pipeline] to build and upload the mod as a zipped artifact so it can be downloaded and tested.

This template is aimed towards simplicity, so I omitted CakeBuild and other helpers present in the [vsmodtemplate](https://github.com/anegostudios/vsmodtemplate) repository. This is by no means aimed to replace this pipeline, but instead provide a simple code setup able to be built by `dotnet build` and the likes without needing to use external build "helpers" for this purpose.

Following the [DRY Principle](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), I made the `.csproj` file as small as can be to outsource the options to a common `Directory.Build.props` file on my [Build Pipeline] repository and also make use of GitHub Actions to build, attest and draft a new release with automatic release notes generation based off a common `CHANGELOG.md` file.

### Usage
- (Optional) For enabling local builds check out the [Build Pipeline] and create your mod projects inside that directory so the `Directory.Build.props` file gets pushed into 
- Get a copy of this template by either using the "Use this Template" button on GitHub, cloning the repository or downloading and unpacking a `.zip` file of the repository.
- (When building locally) Set the environment variable `VINTAGE_STORY` to your Vintage Story installation path and run `dotnet build` with whatever command line arguments you might need to debug or perftest.
- Code your mod, commit and push to a GitHub repository.
- Use Workflow Dispatch to build a test build or draft a new release.
- (Untested) You may use [act](https://github.com/nektos/act) to run the GitHub Actions powered build pipeline locally.

### Reasoning
I wanted to keep my mods more simple and personally don't make use of CakeBuild all too often so I wanted a way to just omit it altogether. CakeBuild has its upsides though, having a Json5 validator, being able to load the Vintage Story libraries at compile time to proofread certain input files, all this neat stuff. But it's a bit much for my usual approach to modding. I might make another version with CakeBuild in the future though, maybe even under this repository so one can choose from the options. Until that, this template is more or less simple with no validation other than compile-time compatibility.

[Build Pipeline]: https://github.com/DavidLokison/vs-build
