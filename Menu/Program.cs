using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ShowText = "1";
            const string ShowRandomNumber = "2";
            const string ClearConsole = "3";
            const string Exit = "4";

            string userInput;

            bool isWork = true;

            Random random = new Random();
            int maxRandomValue = 1001;
            int minRandomValue = 0;

            while (isWork)
            {
                Console.WriteLine($"{ShowText} Показать текст");
                Console.WriteLine($"{ShowRandomNumber} Показать случайное число от {minRandomValue} до {maxRandomValue}");
                Console.WriteLine($"{ClearConsole} Очистить консоль");
                Console.WriteLine($"{Exit} Выход");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ShowText:
                        Console.WriteLine("Вот вам текст.");
                        break;

                    case ShowRandomNumber:
                        int randomValue = random.Next(minRandomValue, maxRandomValue);
                        Console.WriteLine($"Вот вам случайное число: {randomValue}");
                        break;

                    case ClearConsole:
                        Console.Clear();
                        break;

                    case Exit:
                        isWork = false;
                        Console.WriteLine("Программа завершена");
                        break;

                    default:
                        Console.WriteLine("Такой команды в меню нет");
                        break;
                }
            }
        }
    }
}
