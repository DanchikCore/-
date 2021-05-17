using System;

namespace Практическая_работа__4
{
    class Program
    {

        static void Main(string[] args)
        {

            {
                string FullName = GetUserName();
                string Fio = (FullName);
                Console.WriteLine(Fio);
            }

            static string GetUserName()

            {
                Console.WriteLine("Привет! Запиши 1-ое ФИО в формате [Фамилия, Имя, Отчество]");
                string FullUserName = Console.ReadLine();
                Console.WriteLine("Привет! Запиши 2-ое ФИО в формате [Фамилия, Имя, Отчество]");
                string FullUserName1 = Console.ReadLine();
                Console.WriteLine("Привет! Запиши 3-ое ФИО в формате [Фамилия, Имя, Отчество]");
                string FullUserName2 = Console.ReadLine();
                Console.WriteLine($"{GetUserName()}");
                /*Console.WriteLine($"1. {FullUserName}\n" +
                    $"2. {FullUserName1}\n" +
                    $"3. {FullUserName2}");*/
            }



            /*Console.WriteLine("Привет. Запись 1-ого ФИО.\n" +
                  "Введите Имя...");
            string firstName = Console.ReadLine();
            Console.WriteLine("Фамилию...");
            string lastName = Console.ReadLine();
            Console.WriteLine("И Отчество...");
            string patronymic = Console.ReadLine();

            Console.WriteLine("\nЗапись 2-ого ФИО.\n" +
                  "Введите Имя...");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Фамилию...");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("И Отчество...");
            string patronymic1 = Console.ReadLine();

            Console.WriteLine("\nЗапись 3-ого ФИО.\n" +
                  "Введите Имя...");
            string firstName2 = Console.ReadLine();
            Console.WriteLine("Фамилию...");
            string lastName2 = Console.ReadLine();
            Console.WriteLine("И Отчество...");
            string patronymic2 = Console.ReadLine();

                Console.WriteLine($"{firstName} {lastName} {patronymic}");*/
        }
    }
}
