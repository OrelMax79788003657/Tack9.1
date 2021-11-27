using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tack9._1
{
    internal class Program
    {
        static void Main()
        {
            double first = 0;
            double second = 0;
            string tempNum = "";
            Console.WriteLine("Вас приветствует калькулятор");
            try
            {

                Console.Write("Введите число 1: ");
                tempNum = Console.ReadLine();
                while (!double.TryParse(tempNum, out first))
                {
                    Console.WriteLine("This is not valid input. Try agin");
                    tempNum = Console.ReadLine();
                }


                Console.Write("Введите число 2: ");
                tempNum = Console.ReadLine();
                while (!double.TryParse(tempNum, out second))
                {
                    Console.WriteLine("This is not valid input. Try agin");
                    tempNum = Console.ReadLine();
                }

                Console.WriteLine("Укажите действие:\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Деление");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Ваш результат:");
                    Console.WriteLine(first + second);
                }
                else if (input == "2")
                {
                    Console.Write("Ваш результат:");
                    Console.WriteLine(first - second);
                }
                else if (input == "3")
                {
                    Console.Write("Ваш результат:");
                    Console.WriteLine(first * second);
                }
                else if (input == "4")
                {
                    if (second == 0)

                    {
                        throw new DivideByZeroException("You can't divide by Zero!");
                    }
                    Console.Write("Ваш результат:");
                    Console.WriteLine(first / second);
                }
                else
                {
                    Console.WriteLine("Неверное действие");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
             Console.ReadKey();


        }

       

     }

}

