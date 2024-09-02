using System;
using System.Linq;

namespace ConsoleCalc_DZ
{
    //Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите выражения вида: a + b, a - b, a / b, a * b");
            string? inputData = Console.ReadLine();

            string[] convertInputData = inputData.Split(' ' , StringSplitOptions.RemoveEmptyEntries);

            try
            {
                double num1 = Convert.ToDouble(convertInputData[0]);
                string op = convertInputData[1];
                double num2 = Convert.ToDouble(convertInputData[2]);
                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Делить на 0 нельзя!");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверная операция! Используйте +, -, *, или /.");
                        return;
                }

                Console.WriteLine($"{num1} {op} {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат числа!");
            }
        }
    }
}