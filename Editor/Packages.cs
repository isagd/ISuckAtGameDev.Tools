namespace ISuckAtGameDev
{
    public static class Packages
    {
        public static void InstallUnityPackage(string packageName)
        {
            UnityEditor.PackageManager.Client.Add($"com.unity.{packageName}");
        }
    }
}