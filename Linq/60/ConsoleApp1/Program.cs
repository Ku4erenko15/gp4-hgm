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

            Task("LinqBegin60");

            GetEnumerableString()
                .GroupBy(s => s[0]) // группируем по первой заглавной букве
                .Select(g => new {
                    Char = g.Key,
                    TotalLength = g.Sum(s => s.Length)
                })
                .OrderByDescending(x => x.TotalLength) // по убыванию суммы
                .ThenBy(x => x.Char) // по возрастанию кода символа
                .Select(x => $"{x.TotalLength}-{x.Char}")
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadKey();
        }
        static IEnumerable<string> GetEnumerableString()
        {
            // Пример: только заглавные буквы
            return new List<string> { "APPLE", "BANANA", "APRICOT", "BLUEBERRY", "ALMOND" };
        }
        static void Task(string name)
        {
        }
    }
}
