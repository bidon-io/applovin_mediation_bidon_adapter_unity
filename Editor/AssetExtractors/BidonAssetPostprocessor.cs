// ReSharper disable CheckNamespace
// ReSharper disable HeuristicUnreachableCode

#pragma warning disable CS0162

using System.Linq;
using UnityEditor;
using Bidon.AppLovinMaxAdapter.Utilities.Editor;

namespace Bidon.AppLovinMaxAdapter.AssetExtractors.Editor
{
    internal class BidonAssetPostprocessor : AssetPostprocessor
    {
#if UNITY_2021_3_OR_NEWER
        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths, bool didDomainReload)
        {
#else
        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
#endif
#if UNITY_STANDALONE && BIDON_DEV
            return;
#endif
            if (deletedAssets.Any(asset => asset.Contains(EditorConstants.PackageRootDirectory))) return;

            if (BidonDependenciesInstaller.Deploy()) AssetDatabase.Refresh();
        }
    }
}
