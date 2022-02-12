using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;

namespace ISuckAtGameDev
{
    public static class Folders
    {
        public static void CreateDirectories(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, root);
            foreach (var newDir in dir)
            {
                CreateDirectory(Combine(fullPath, newDir));
            }
        }
    }
}