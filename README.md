# TODO
- CakeBuild or DotNetRun target to run the Client or Server dll with the debug pipeline in place

# Vintage Story Mod Template
This repository contains a boilerplate code mod template for Vintage Story using standard dotnet build pipelines without any solution files for Visual Studio and the likes. It makes use of a GitHub Actions powered [Build Pipeline] to build and upload the mod as a zipped artifact so it can be downloaded and tested.

#### TODO: DRY the sauce again
Following the [DRY Principle](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), I made the `.csproj` file as small as can be to outsource the options to a common `Directory.Build.props` file on my [Build Pipeline] repository and also make use of GitHub Actions to build, attest and draft a new release with automatic release notes generation based off a common `CHANGELOG.md` file.

### Usage
- Get a copy of this template by either using the "Use this Template" button on GitHub, cloning the repository or downloading and unpacking a `.zip` file of the repository.
- Code your mod, commit and push to a GitHub repository (if using a GitHub hosted Workflow runner).
- Use Workflow Dispatch to build a test build or draft a new release.

**Note:** You may use [act] to run the GitHub Actions powered build pipeline locally. Functionality is tested for the build workflow (`act -W .github/workflows/build.yml`), expect (obvious) breakage at the remote-targeted release workflow. This is also the reason why that workflow uses `actions/upload-artifact@v5` even though newer versions are available: Act currently only officially supports v3 and v4, it seems to be working with v5. The zipped mod artifact will be placed in subdirectories inside the `dist` directory.

### Building Locally
While I strongly recommend [act] to run the build workflow locally, it is also an option to build the files directly on your system. Using the CakeBuild bootstrapper, you can compile your mod to a `.zip` which is easily included into a local modflow, or use the custom dotnet targets to launch a test client or server directly.

- Set the environment variable `VINTAGE_STORY` to your Vintage Story installation path.
- Run `git submodule update --init --recursive` to fetch CakeBuild files.
- Run `dotnet publish build` once to build the CakeBuild bootstrapper. It will be stored in `bin/CakeBuild`.

- Run `./bin/CakeBuild --configuration Debug` to build the mod and provide a test environment.
- Run `./bin/CakeBuild` to build and publish a zipped artifact.
- Run `dotnet msbuild -t RunClient` to launch a test client with the mod installed. (Use `-tl:off` to get all game logs cause they tend to get swallowed by the dotnet wrapper.)

### Reasoning
#### TODO: Re-add reasoning but to the variant with CakeBuild

[Build Pipeline]: https://github.com/DavidLokison/vs-build
[act]: https://github.com/nektos/act
