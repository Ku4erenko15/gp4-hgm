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
            var sequence = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse);

            var result = sequence.Where(e => e > 0);
           
            Console.WriteLine(string.Join(" ", result));
            Console.ReadKey();
        }
    }
}
