using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ6РПМ
{
    class Program
    {
        static void Main(string[] args)
        {
            Company.Employee[] employees =
        {
            new Company.Employee("Alice", 30),
            new Company.Employee("Bob", 25)
        };

            Company originalCompany = new Company(employees);
            Company shallowCopy = originalCompany.ShallowCopy();
            Company deepCopy = originalCompany.DeepCopy();

            Console.WriteLine("До изменения копии:");
            Console.WriteLine($"Оригинал: {originalCompany.Employees[0].Name}");
            Console.WriteLine($"Поверхностная копия: {shallowCopy.Employees[0].Name}");
            Console.WriteLine($"Глубокая копия: {deepCopy.Employees[0].Name}\n");

            // Меняем имя в поверхностной копии
            shallowCopy.Employees[0].Name = "Charlie";
            Console.WriteLine("После изменения поверхностной копии:");
            Console.WriteLine($"Оригинал: {originalCompany.Employees[0].Name}"); // Изменится
            Console.WriteLine($"Поверхностная копия: {shallowCopy.Employees[0].Name}"); // Изменится
            Console.WriteLine($"Глубокая копия: {deepCopy.Employees[0].Name}\n"); // Не изменится
        }
    }
    }
