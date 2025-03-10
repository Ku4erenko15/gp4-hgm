using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_5_РПМ
{
    class Number
    {
        private double X { get; }
        private double Y { get; }

        public Number(double x, double y)
        {
            X = x;
            Y = y;
        }

        public string CalculateCube()
        {
            double max = Math.Max(X, Y);
            double cube = Math.Pow(max, 3);
            return $"Куб большего числа ({max}) = {cube}";
        }
    }
}







        
