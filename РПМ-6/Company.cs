using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РПМ_6
{
    class Company
    {
        public Employee[] Employees { get; set; }

        public Company(Employee[] employees)
        {
            Employees = employees;
        }

        // Поверхностное копирование
        public Company ShallowCopy()
        {
            return new Company(this.Employees);
        }

        // Глубокое копирование
        public Company DeepCopy()
        {
            Employee[] newEmployees = new Employee[Employees.Length];
            for (int i = 0; i < Employees.Length; i++)
            {
                newEmployees[i] = Employees[i].DeepCopy();
            }
            return new Company(newEmployees);
        }

        public void PrintEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"Сотрудник {i + 1}: {Employees[i]}");
            }
        }
    }
}
