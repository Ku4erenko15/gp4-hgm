using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод последовательности непустых строк через пробел
            string[] input = Console.ReadLine()
                                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Получение символов по условию задачи
            var result = input
                .Select(s => s.Length % 2 == 1 ? s[0] : s[s.Length - 1])
                .OrderByDescending(c => c);

            // Вывод отсортированных символов
            Console.WriteLine(string.Join(" ", result));
            Console.ReadKey();
        }
    }
}
