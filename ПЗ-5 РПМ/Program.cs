using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_5_РПМ
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первое число: ");
            string input1 = Console.ReadLine();

            Console.Write("Введите второе число: ");
            string input2 = Console.ReadLine();


            if (double.TryParse(input1, out double x) && double.TryParse(input2, out double y))
            {
                var processor = new Number(x, y);
                Console.WriteLine(processor.CalculateCube());
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Пожалуйста, введите корректные числа.");
            }
            Console.ReadKey();
        }
    }
}

