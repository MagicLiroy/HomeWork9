using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class Program
    {
        static double Fold(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            while (b == 0)
            {
                Console.WriteLine("Делитель не должен быть равен нолю, введите значение повторно: "); 
                b = double.Parse(Console.ReadLine());
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение: ");
            double firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе значение: ");
            double secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите математическую операцию");
            string operation = Console.ReadLine();

            double result = 0;
            bool validOperation = true;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = Fold(firstValue, secondValue);
                        break;

                    case "-":
                        result = Subtract(firstValue, secondValue);
                        break;

                    case "*":
                        result = Multiply(firstValue, secondValue);
                        break;

                    case "/":
                        result = Divide(firstValue, secondValue);
                        break;

                    default:
                        Console.WriteLine("Данная операця не предусмотрена");
                        validOperation = false;
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                validOperation = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                validOperation = false;
            }
            if (validOperation)
            {
                Console.WriteLine("Ответ: {0}", result);
            }

            Console.ReadKey();
        }
    }
}
