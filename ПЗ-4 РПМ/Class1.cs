using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_4_РПМ
{
    internal class Build
    {
        public string Address { get; set; }
        public string Type { get; set; }
        public int Floors { get; set; }
        public int Apartments { get; set; }
        public int YearsInUse { get; set; }
        public int YearsToMajorRepair => 25 - (YearsInUse % 25);

        public Build(string address, string type, int floors, int apartments, int yearsInUse)
        {
            Address = address;
            Type = type;
            Floors = floors;
            Apartments = apartments;
            YearsInUse = yearsInUse;
        }
    }
}
