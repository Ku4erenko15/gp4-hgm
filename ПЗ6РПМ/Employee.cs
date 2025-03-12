using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ6РПМ
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

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            return new Employee(this.Name, this.Age);
        }
    }


}

