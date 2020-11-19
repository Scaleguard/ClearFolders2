using System;
using System.IO;


namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateFile();
            Console.WriteLine("Enter file name (include extension): ");
            string userInput = Console.ReadLine();
            //CreateCustomFile(userInput);
            CreateFileWithExtension(userInput);
        }

        public static void CreateFile()
        {
            string rootPath = @"C:\Users\opilane\Samples\PlayerOne";
            string fileName = "ball.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }

        public static void CreateCustomFile(string fileName)
        {
            string rootPath = @"C:\Users\opilane\Samples\PlayerOTwo";
            
            File.Create(Path.Combine(rootPath, fileName));
        }

        public static void CreateFileWithExtension(string fileName)
        {
            string rootPath = @"C:\Users\opilane\Samples\PlayerOTwo";
            string fullfileName = $"{fileName}.txt";
            File.Create(Path.Combine(rootPath, fullfileName));
        }
    }
}
