using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string rootPath = @"C:\Users\opilane\Samples";
            DeleteAllFiles();
            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllfolders(dir.FullName, true);
            }
            
        }
        // deleting all files function

        public static void DeleteAllFiles()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

         
        }
          public static void DeleteAllfolders(string DirectoryName, bool ifExists)
          {
            if(Directory.Exists(DirectoryName))
            {
                Directory.Delete(DirectoryName, true);

            }else if (ifExists)
            {
                throw new SystemException("No directory to delete");
            }
          }

    }
}
