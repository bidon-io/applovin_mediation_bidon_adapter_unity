// ReSharper disable CheckNamespace

using UnityEditor;
using UnityEngine;
using Bidon.AppLovinMaxAdapter.PluginRemover.Editor;
using Bidon.AppLovinMaxAdapter.Utilities.Editor;

namespace Bidon.AppLovinMaxAdapter.TopBarMenu.Editor
{
    internal class TopBarMenu : ScriptableObject
    {
        [MenuItem("AppLovin/Bidon Adapter/Documentation", false, 42)]
        public static void OpenDocumentation()
        {
            Application.OpenURL(EditorConstants.PluginDocumentationLink);
        }

        [MenuItem("AppLovin/Bidon Adapter/Remove Plugin", false, 43)]
        public static void RemovePlugin()
        {
            RemoveHelper.RemovePlugin();
        }
    }
}
