using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ejercicio_3
{
    internal class Suma
    {
        private double num1;
        private double num2;
        private double num3;
        private double num4;

        public Suma ( double num1, double num2, double num3, double num4)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;

        }

        public double Getsuma()
        {
            return num1 +num2 + num3 + num4;
        }
        public double Promedio()
        {
            return Getsuma() / 4;
        }
    }
}
