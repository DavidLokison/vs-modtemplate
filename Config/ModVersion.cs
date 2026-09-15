using Vintagestory.API.Config;

#nullable disable

namespace ModTemplate.Config
{
    /// <summary>
    /// The mods current version
    /// </summary>
    public static class ModVersion
    {
        /// <summary>
        /// Major and Minor version as string for easy updating all the other ones in this class
        /// </summary>
        public const string OverallMajorMinor = "1.0";

        /// <summary>
        /// Assembly Info Version number in the format: major.minor.revision-[rc/pre.subrevision]
        /// </summary>
        public const string OverallVersion = OverallMajorMinor + ".0";

        public static EnumReleaseType ReleaseType => GameVersion.GetReleaseType(OverallVersion);

        /// <summary>
        /// Assembly Info Version number in the format: major.minor.revision.subrevision
        /// </summary>
        public const string AssemblyVersion = OverallVersion +".0";

        /// <summary>
        /// Version of the Network Protocol
        /// </summary>
        public const string NetworkVersion = OverallMajorMinor + ".0";

        /// <summary>
        /// Copyright notice
        /// </summary>
        public const string CopyRight = "Template under CC0 1.0 Universal";
    }
}
