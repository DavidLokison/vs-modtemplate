using System.Reflection;
using System.Runtime.InteropServices;
using Vintagestory.API.Common;
using ModTemplate.Config;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Vintage Story Template Mod")]
[assembly: AssemblyDescription("github.com/DavidLokison/vs-modtemplate")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Template Mod")]
[assembly: AssemblyCopyright(ModVersion.CopyRight)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("d2b49daa-3bfe-4b92-9e98-6f52682a2db9")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(ModVersion.AssemblyVersion)]
[assembly: AssemblyFileVersion(ModVersion.OverallVersion)]

[assembly: ModInfo("Template Mod", "modtemplate",
    Version = ModVersion.ShortGameVersion,
    NetworkVersion = ModVersion.NetworkVersion,
    IconPath = "modtemplate/textures/gui/modicon.png",
    Description = "This mod is a stub – it is intended as a template to develop new Vintage Story mods in an open and cryptographically verified way",
    Authors = new[] { "Yours Truly" }
)]

[assembly: ModDependency("game", "")]
