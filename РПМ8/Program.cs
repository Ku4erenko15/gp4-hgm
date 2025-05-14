using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РПМ8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод цифры D
            Console.Write("Введите цифру D (от 0 до 9): ");
            int D = int.Parse(Console.ReadLine());

            // Ввод последовательности A
            Console.WriteLine("Введите элементы последовательности A через пробел:");
            string[] input = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(input, int.Parse);

            // Поиск первого подходящего элемента
            foreach (int num in A)
            {
                if (num > 0 && num % 10 == D)
                {
                    Console.WriteLine("Результат: " + num);
                    return;
                }
            }

            // Если не найдено
            Console.WriteLine("Результат: 0");

        }
    }
}
