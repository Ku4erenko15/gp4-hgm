using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РПМ_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Оригинальная компания
            var originalCompany = new Company(new Employee[]
            {
            new Employee("Иван", 30),
            new Employee("Ольга", 28)
            });

            Console.WriteLine("== Оригинальная компания ==");
            originalCompany.PrintEmployees();

            // === Поверхностное копирование ===
            var shallowCopy = originalCompany.ShallowCopy();
            shallowCopy.Employees[0].Name = "Петр"; // Меняем имя первого сотрудника

            Console.WriteLine("\n== После изменения поверхностной копии ==");
            Console.WriteLine("-- Поверхностная копия --");
            shallowCopy.PrintEmployees();

            Console.WriteLine("-- Оригинал (изменился!) --");
            originalCompany.PrintEmployees();

            // === Глубокое копирование ===
            var deepCopy = originalCompany.DeepCopy();
            deepCopy.Employees[0].Name = "Алексей"; // Меняем имя в глубокой копии

            Console.WriteLine("\n== После изменения глубокой копии ==");
            Console.WriteLine("-- Глубокая копия --");
            deepCopy.PrintEmployees();

            Console.WriteLine("-- Оригинал (не изменился) --");
            originalCompany.PrintEmployees();
        }
    }
}

