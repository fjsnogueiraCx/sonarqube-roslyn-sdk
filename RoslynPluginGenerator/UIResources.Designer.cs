﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarQube.Plugins.Roslyn {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class UIResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UIResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarQube.Plugins.Roslyn.UIResources", typeof(UIResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of analyzers located in package: {0}.
        /// </summary>
        public static string APG_AnalyzersLocated {
            get {
                return ResourceManager.GetString("APG_AnalyzersLocated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Temporary working folder for this run: {0}.
        /// </summary>
        public static string APG_CreatedTempWorkingDir {
            get {
                return ResourceManager.GetString("APG_CreatedTempWorkingDir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Roslyn plugin specific sources in {0}.
        /// </summary>
        public static string APG_CreatingRoslynSources {
            get {
                return ResourceManager.GetString("APG_CreatingRoslynSources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extracting files from the package to {0}.
        /// </summary>
        public static string APG_ExtractingPackageFiles {
            get {
                return ResourceManager.GetString("APG_ExtractingPackageFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating plugin....
        /// </summary>
        public static string APG_GeneratingPlugin {
            get {
                return ResourceManager.GetString("APG_GeneratingPlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating rules....
        /// </summary>
        public static string APG_GeneratingRules {
            get {
                return ResourceManager.GetString("APG_GeneratingRules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Looking for analyzers in the package....
        /// </summary>
        public static string APG_LocatingAnalyzers {
            get {
                return ResourceManager.GetString("APG_LocatingAnalyzers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Looking for {0} analyzers.
        /// </summary>
        public static string APG_LogAnalyzerLanguage {
            get {
                return ResourceManager.GetString("APG_LogAnalyzerLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No analyzers were found in the specified package.
        /// </summary>
        public static string APG_NoAnalyzersFound {
            get {
                return ResourceManager.GetString("APG_NoAnalyzersFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Plugin generated: {0}.
        /// </summary>
        public static string APG_PluginGenerated {
            get {
                return ResourceManager.GetString("APG_PluginGenerated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} rules generated to {1}.
        /// </summary>
        public static string APG_RulesGeneratedToFile {
            get {
                return ResourceManager.GetString("APG_RulesGeneratedToFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The language &apos;{0}&apos; is not supported. Valid options are &apos;cs&apos; or &apos;vb&apos;..
        /// </summary>
        public static string APG_UnsupportedLanguage {
            get {
                return ResourceManager.GetString("APG_UnsupportedLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Roslyn Analyzer Plugin Generator for SonarQube.
        /// </summary>
        public static string AssemblyDescription {
            get {
                return ResourceManager.GetString("AssemblyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting one or two arguments:
        ///* NuGet package Id (mandatory), and
        ///* NuGet package version (optional).
        /// </summary>
        public static string CmdLine_ERROR_InvalidArgumentCount {
            get {
                return ResourceManager.GetString("CmdLine_ERROR_InvalidArgumentCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating NuGet repository: {0}.
        /// </summary>
        public static string NG_CreatingRepository {
            get {
                return ResourceManager.GetString("NG_CreatingRepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ... downloaded ({0} files).
        /// </summary>
        public static string NG_DownloadedPackage {
            get {
                return ResourceManager.GetString("NG_DownloadedPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading package....
        /// </summary>
        public static string NG_DownloadingPackage {
            get {
                return ResourceManager.GetString("NG_DownloadingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to install package: {0}
        ///Check that there are released versions of the package, or specify a pre-release version identifier..
        /// </summary>
        public static string NG_ERROR_PackageInstallFail {
            get {
                return ResourceManager.GetString("NG_ERROR_PackageInstallFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No packages with the specified id were found: {0}.
        /// </summary>
        public static string NG_ERROR_PackageNotFound {
            get {
                return ResourceManager.GetString("NG_ERROR_PackageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package version was not found: {0}.
        /// </summary>
        public static string NG_ERROR_PackageVersionNotFound {
            get {
                return ResourceManager.GetString("NG_ERROR_PackageVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extracting file &apos;{0}&apos; to {1}.
        /// </summary>
        public static string NG_ExtractingFile {
            get {
                return ResourceManager.GetString("NG_ExtractingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - latest version.
        /// </summary>
        public static string NG_IsLatestPackageVersionSuffix {
            get {
                return ResourceManager.GetString("NG_IsLatestPackageVersionSuffix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to locate package with id &apos;{0}&apos;.
        /// </summary>
        public static string NG_LocatingPackages {
            get {
                return ResourceManager.GetString("NG_LocatingPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of packages located: {0}.
        /// </summary>
        public static string NG_NumberOfPackagesLocated {
            get {
                return ResourceManager.GetString("NG_NumberOfPackagesLocated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package versions:.
        /// </summary>
        public static string NG_PackageVersionListHeader {
            get {
                return ResourceManager.GetString("NG_PackageVersionListHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version was not specified. Using version {0}..
        /// </summary>
        public static string NG_SelectedPackageVersion {
            get {
                return ResourceManager.GetString("NG_SelectedPackageVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using version marked as latest..
        /// </summary>
        public static string NG_UsingLatestPackageVersion {
            get {
                return ResourceManager.GetString("NG_UsingLatestPackageVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping rule in analyzer {0}: Duplicate key..
        /// </summary>
        public static string RuleGen_DuplicateKey {
            get {
                return ResourceManager.GetString("RuleGen_DuplicateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping rule in analyzer {0}: No key found..
        /// </summary>
        public static string RuleGen_EmptyKey {
            get {
                return ResourceManager.GetString("RuleGen_EmptyKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For more information visit &lt;a href=&quot;{0}&quot; target=&quot;_blank&quot;&gt;the rule&apos;s help page&lt;/a&gt;..
        /// </summary>
        public static string RuleGen_ForMoreDetailsLink {
            get {
                return ResourceManager.GetString("RuleGen_ForMoreDetailsLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More Details.
        /// </summary>
        public static string RuleGen_MoreDetailsTitle {
            get {
                return ResourceManager.GetString("RuleGen_MoreDetailsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No description was provided..
        /// </summary>
        public static string RuleGen_NoDescription {
            get {
                return ResourceManager.GetString("RuleGen_NoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not instantiate analyzers from &apos;{0}&apos;. 
        ///
        ///Error: {1}.
        /// </summary>
        public static string Scanner_AnalyzerInstantiationFail {
            get {
                return ResourceManager.GetString("Scanner_AnalyzerInstantiationFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded analyzer: {0}.
        /// </summary>
        public static string Scanner_AnalyzerLoaded {
            get {
                return ResourceManager.GetString("Scanner_AnalyzerLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded: {0} analyzers..
        /// </summary>
        public static string Scanner_AnalyzersLoadSuccess {
            get {
                return ResourceManager.GetString("Scanner_AnalyzersLoadSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded assembly: {0}.
        /// </summary>
        public static string Scanner_AssemblyLoadSuccess {
            get {
                return ResourceManager.GetString("Scanner_AssemblyLoadSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No analyzers found in assembly..
        /// </summary>
        public static string Scanner_NoAnalyzers {
            get {
                return ResourceManager.GetString("Scanner_NoAnalyzers", resourceCulture);
            }
        }
    }
}
