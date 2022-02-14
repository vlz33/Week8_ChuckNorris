using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomNorris;
            randomNorris = GetRandomFromFile("chuck.txt");
            Console.WriteLine($"Tonight you will learn about Chuck Norris: {randomNorris}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string filename)

        {
            string filePath = $@"C:\Users\Ville\Desktop\KOOL\Programmeerimine\Nädal 8 failid\chuck.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}
