using System;
using System.IO;

namespace FindFileInFolderAndSubfolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindInMultipleFolders();
        }


        public static void FindInMultipleFolders()
        {
            string searchName = "XXXXXXX";
            string[] files = Directory.GetFiles(@"XXXXXXXX", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                if (Path.GetFileNameWithoutExtension(info.Name).ToLower() == searchName.ToLower())
                {
                    Console.WriteLine(info.FullName);
                }
            }
        }
    }
}
