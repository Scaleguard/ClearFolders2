using System;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFolderOne();
            CreateFolderTwo();
        }
        public static void CreateFolderOne()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "PlayerOne";
            string fullFolderPath = Path.Combine(rootPath, folderName);
            Console.WriteLine(fullFolderPath);
            if (Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("The Folder already exist");
            }else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
            
        }
        public static void CreateFolderTwo()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "PlayerOTwo";
            string fullFolderPath = Path.Combine(rootPath, folderName);
            Console.WriteLine(fullFolderPath);
            if (Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("The Folder already exist");
            }
            else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }
    }
}
