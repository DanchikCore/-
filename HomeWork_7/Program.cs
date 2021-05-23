using System;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи строку и она запишется в обратном порядке: ");
            string text = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = text.Length - 1; i > -1; i--)
                reverse += text[i];

            Console.WriteLine(reverse);
        }
    }
}
