using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РПМ_6
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Глубокое копирование сотрудника
        public Employee DeepCopy()
        {
            return new Employee(Name, Age);
        }

        public override string ToString()
        {
            return $"{Name}, {Age} лет";
        }
    }
}
