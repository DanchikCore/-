using System;

namespace практическая_работа__3
{
    class Program
    {

        static void Main()
        {
            // Задание №1, ДВУХМЕРНЫЙ МАССИВ ПО ДИАГОНАЛИ

            /*int[,] matrix = new int[5, 5];

            matrix[0, 4] = 1;
            matrix[1, 3] = 1;
            matrix[2, 2] = 1;
            matrix[3, 1] = 1;
            matrix[4, 0] = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }*/

            // Задание №2, ТЕЛЕФОННЫЙ СПРАВОЧНИК

            /*string[,] matrix = new string[5, 2];

            matrix[0, 0] = "Alex";
                matrix[0, 1] = " [ +7 913-914-15-16 / e-mail: - ]";
            matrix[1, 0] = "Jeff";
                matrix[1, 1] = " [ +7 913-915-16-17 / e-mail: Jeff666@gmail.com ]";
            matrix[2, 0] = "Luci";
                matrix[2, 1] = " [ +7 913-916-17-18 / e-mail: - ]";
            matrix[3, 0] = "James";
                matrix[3, 1] = " [ +7 913-917-18-19 / e-mail: - ]";
            matrix[4, 0] = "Adam";
                matrix[4, 1] = " [ +7 913-918-19-10 / e-mail: Adam777@mail.ru ]";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }*/

            // Задание №3, ВВЕДЁННАЯ СТРОКА В ОБРАТНОМ ПОРЯДКЕ

            Console.WriteLine("Введи строку и она запишется в обратном порядке: ");
            string text = Console.ReadLine(); string reverse = string.Empty;

            for (int i = text.Length - 1; i > -1; i--)
                reverse += text[i];

            Console.WriteLine(reverse);
        }
    }
}
