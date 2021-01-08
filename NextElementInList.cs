using System;
using System.Text;
using System.Collections.Generic;

namespace GetNextElementInList
{
    class NextElementInList
    {
        private static string ReadOnlyNumbers()
        {
            StringBuilder input = new StringBuilder();
            ConsoleKeyInfo ckey;

            while ((ckey = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (Char.IsDigit(ckey.KeyChar))
                {
                    Console.Write(ckey.KeyChar);
                    input.Append(ckey.KeyChar);
                }

                if (ckey.Key == ConsoleKey.Backspace)
                {
                    input.Length--;
                    Console.Write("\b \b");
                }
            }

            Console.Write(Environment.NewLine);
            return input.ToString();
        }

        private static void Main()
        {
            List<string> testList = new List<string>();
            int repeats = 0;
            string inputLine = "";

            do
            {
                repeats = 0;
                Console.Clear();
                Console.WriteLine("Пограмма, которая возвращает следующий объект из этого списка по порядку.");
                Console.WriteLine("Введите несколько строк в список или \"q\" для выхода.");
                Console.WriteLine("\"r\" закончить заполнение списка.");
                Console.WriteLine("\"c\" очистить список.");
                Console.WriteLine("\"q\" для выхода.");
                if (testList.Count > 0)
                {
                    Console.WriteLine("Текущий список: ");
                    try
                    {
                        foreach (string line in testList)
                            Console.WriteLine(line);
                    }
                    catch
                    {
                        Console.WriteLine("Не удалось вывести список");
                    }
                    Console.WriteLine("-----------------------------");
                }


                inputLine = Console.ReadLine();

                switch (inputLine)
                {
                    case "q":
                        return;
                    case "c":
                        testList.Clear();
                        break;
                    case "r":
                        Console.Write("Сколько раз повторить вызов функции? Ввведите натуральное число: ");
                        repeats = Convert.ToInt32(ReadOnlyNumbers());
                        Console.WriteLine("Вы ввели число: {0}", repeats);
                        Cycler cycler = new Cycler(testList);

                        for (int i = 0; i < repeats; i++)
                        {
                            string value = cycler.GetNext();
                            Console.Write(value + " ");
                        }

                        Console.ReadKey();
                        break;
                    default:
                        testList.Add(inputLine);
                        break;
                }

            } while (true);
        }
    }
}
