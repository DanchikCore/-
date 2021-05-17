using System;

namespace Practice_work_num._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Привет. Как тебя зовут? - ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет ещё раз, {name}! \n" +
                $"Сегодня [{DateTime.Now}] и я вновь рад тебя видеть!");
        }
    }
}
