using UnityEditor;
using static UnityEditor.AssetDatabase;

namespace ISuckAtGameDev
{
    public static class ToolsMenu
    {
        [MenuItem("ISAGD Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Folders.CreateDirectories("_Project", "Scripts", "Art", "Scenes", "Prefabs", "Settings");
            Refresh();
        }

        [MenuItem("ISAGD Tools/Setup/Packages/Cinemachine")]
        static void AddCinemachine() => Packages.InstallUnityPackage("cinemachine");

        [MenuItem("ISAGD Tools/Setup/Packages/New Input System")]
        static void AddNewInputSystem() => Packages.InstallUnityPackage("inputsystem");
    }
}
