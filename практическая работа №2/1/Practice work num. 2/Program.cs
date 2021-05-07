using System;

namespace Practice_work_num._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Привет. Как тебя зовут? - ");
                string name = Console.ReadLine();

            Console.WriteLine($"Рад знакомству {name}! Это программа для подсчета среднесуточной температуры.\n" +
                $"Введи показание минимальной температуры...");
                string tempMin = Console.ReadLine();

            Console.WriteLine($"А теперь показание максимальной...");
                string tempMax = Console.ReadLine();

            string tempAvg = (tempMax + tempMin);

            Console.WriteLine($"И того среднесуточное значение равно...\n" +
                $"{tempAvg}");


        }
    }
}
