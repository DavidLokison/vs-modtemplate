# Vintage Story Mod Template
This repository contains a boilerplate code mod template for Vintage Story using standard dotnet build pipelines without any solution files for Visual Studio and the likes. It makes use of a GitHub Actions powered [Build Pipeline] to build and upload the mod as a zipped artifact so it can be downloaded and tested.

#### TODO: DRY the sauce again
Following the [DRY Principle](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), I made the CSPROJ file as small as can be to outsource the options to a common `Directory.Build.props` file on my [Build Pipeline] repository and also make use of GitHub Actions to build, attest and draft a new release with automatic release notes generation based off a common `CHANGELOG.md` file.

The newest additions have yet to be incorporated into the pipeline action.

### Usage
- Get a copy of this template by either using the "Use this Template" button on GitHub, cloning the repository or downloading and unpacking a ZIP file of the repository.
- Code your mod, commit and push to a GitHub repository (if using a GitHub hosted Workflow runner).
- Use Workflow Dispatch to build a test build or draft a new release.

**Note:** You may use [act] to run the GitHub Actions powered build pipeline locally. Functionality is tested for the build workflow (`act -W .github/workflows/build.yml`), expect (obvious) breakage at the remote-targeted release workflow. This is also the reason why that workflow uses `actions/upload-artifact@v5` even though newer versions are available: Act currently only officially supports v3 and v4, it seems to be working with v5. The zipped mod artifact will be placed in `dist/1/<modid>_<version>` directory.

### Building Locally
While I strongly recommend [act] to build your mod locally, it is also an option to build the files directly on your system. Using the CakeBuild bootstrapper, you can compile your mod to a deploy directory (`dist/Release/<modid>`) which is easily included into a local modflow, or use the custom dotnet targets to launch a test client or server directly.

- Set the environment variable `VINTAGE_STORY` to your Vintage Story installation path.
- Run `git submodule update --init --recursive` to fetch CakeBuild files.
- Run `dotnet publish build` once to build the CakeBuild bootstrapper. It will be stored in `bin/CakeBuild`.

- Run `./bin/CakeBuild --configuration Debug` to build the mod and provide a test environment.
- Run `./bin/CakeBuild` to build and publish a zipped artifact.
- Run `dotnet msbuild -t RunClient` to launch a test client with the mod installed. (Use `-tl:off` to get all game logs cause they tend to get swallowed by the dotnet wrapper.)

### A word on modinfo.json and AssemblyInfo
There will be no `modinfo.json` found inside this template source code. The reason behind this is that the CakeBuild system automatically derives the contents of the modinfo from the information provided through [AssemblyInfo.cs](Properties/AssemblyInfo.cs). This is so you can programmatically influence the modinfo, for example to target multiple game versions or to customize world configurations.

Another reason for not providing a JSON file is the possibility to distribute DLL-only mods. Sometimes all your mod does is changing game logic without even touching assets with a ten foot pole, so packing that file in a ZIP just to provide modinfo seems ridiculous. If the CakeBuild detects no `assets` folder inside the project root and [ TODO: CakeBuild CLI Option no symbols ] is set to `true`, it will provide only a single DLL file, ready to be inserted into the mod directory as-is.

In addition to the ModInfo, custom ModWorldConfiguration settings can be specified inside the assembly info. Until a guide for that is ready, I suggest heading over to [VSSurvivalMod] and their assembly info where they configure custom world settings and presets.

### Reasoning
This template aims to be feature-equivalent to the official mod template [by Anego Studios](https://github.com/anegostudios/vsmodtemplate). The reason to re-add CakeBuild into the mix despite still trying to stay as simple as possible was that CakeBuild is vastly used within the Vintage Story modding community and it provides some tools to automatically generate metadata and run tests which would not easily be doable with a dotnet-only approach. Ultimately, it makes the codebase itself more readable, the build more portable across systems and it is capable of running inside an [act] local container so it's got everything I need, if not more.

[Build Pipeline]: https://github.com/DavidLokison/vs-build
[act]: https://github.com/nektos/act
[VSSurvivalMod]: https://github.com/anegostudios/vssurvivalmod
