using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSum2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();
            string userInput;
            bool exit = false;

            Console.WriteLine($"Введите числа от {int.MinValue} до {int.MaxValue}." +
                $" sum - ввывод суммы введеных чисел. exit - выйти из программы");

            while (exit != true)
            {
                Console.Write("Введите число или команду: ");
                userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    exit = true;
                }

                else if (userInput == "sum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count ; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine("Сумма равна " + sum);
                }
                else
                {
                    int intValue;
                    if (int.TryParse(userInput, out intValue))
                    {
                        numbers.Add(intValue);
                    }
                    else
                    {
                        Console.WriteLine("Не известная команада.");
                    }
                }
            }
        }
    }
}
