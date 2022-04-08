using System;
using System.IO;

namespace LR_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "store.txt";
            StreamReader reader = new StreamReader(path);
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пустий");
            }
            else
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            reader.Close();

            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(DateTime.Now.ToString());
            writer.Close();

        }
    }
}
