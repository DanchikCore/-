using System;
using System.IO;

namespace Практическая_работа__5
{
    class Program
    {
        static void Main(string[] args)
        {
                /*
                // Запись набора чисел в бинарный файл

                byte[] array = { 4, 10, 23, 6 };
                File.WriteAllBytes("startup.txt", array);
                byte[] fromFile = File.ReadAllBytes("startup.txt");*/

                // Запись текущего времени при старте

                string filename = "startup.txt";
                File.AppendAllText(filename, $"{DateTime.Now}");
                File.AppendAllText(filename, Environment.NewLine);

        }
    }
}
