using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример последовательности строк
            var strings = new List<string>
            {
                "apple",
                "banana",
                "cat",
                "dog",
                "elephant"
            };

            // Получение последовательности символов по условию задачи
            var chars = strings
                .Where(s => !string.IsNullOrEmpty(s))
                .Select(s => s.Length % 2 == 1 ? s[0] : s[s.Length - 1])
                .OrderByDescending(c => (int)c)
                .ToList();

            // Вывод результата
            Console.WriteLine("Результат:");
            foreach (var ch in chars)
            {
                Console.WriteLine(ch);
            }

            // Для ожидания нажатия клавиши (если нужно)
            // Console.ReadKey();
        }
    }
}
