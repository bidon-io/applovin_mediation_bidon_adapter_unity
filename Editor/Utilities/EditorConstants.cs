// ReSharper disable CheckNamespace

namespace Bidon.AppLovinMaxAdapter.Utilities.Editor
{
    public static class EditorConstants
    {
        public const string PackageName = "com.applovin.mediation.adapters.bidon";
        public const string PackageRootDirectory = "Packages/" + PackageName;

        public const string DependenciesFileName = "BidonDependencies";
        public const string RemoveListFileName = "remove_list";

        public const string PackageDependenciesFilePath = PackageRootDirectory + "/Editor/Dependencies/" + DependenciesFileName + ".txt";
        public const string PackageRemoveListFilePath = PackageRootDirectory + "/Editor/PluginRemover/" + RemoveListFileName + ".xml";

        public const string PluginEditorDirectory = "Assets/AppLovinMaxBidonAdapter/Editor";
        public const string PluginDependenciesDirectory = PluginEditorDirectory + "/Dependencies";
        public const string PluginDependenciesFilePath = PluginDependenciesDirectory + "/" + DependenciesFileName + ".xml";

        public const string PluginDocumentationLink = "https://docs.bidon.org/docs/applovin-max/sdk-integration";
    }
}
