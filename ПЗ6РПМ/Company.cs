using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ6РПМ
{
    class Company
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Employee(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public Employee ShallowCopy()
            {
                return (Employee)this.MemberwiseClone();
            }

            public Employee DeepCopy()
            {
                return new Employee(this.Name, this.Age);
            }
        }

        public Employee[] Employees { get; set; }

        public Company(Employee[] employees)
        {
            Employees = employees;
        }

        public Company ShallowCopy()
        {
            return (Company)this.MemberwiseClone();
        }

        public Company DeepCopy()
        {
            Employee[] copiedEmployees = new Employee[Employees.Length];
            for (int i = 0; i < Employees.Length; i++)
            {
                copiedEmployees[i] = Employees[i].DeepCopy();
            }
            return new Company(copiedEmployees);
        }

    }
}
