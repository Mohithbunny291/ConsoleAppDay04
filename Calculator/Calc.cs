using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay04
{
    public class Calc
    {
        public void Add(double n1,double n2)
        {
            Console.WriteLine("Add " + (n1 + n2));
        }
        public void Sub(double n1, double n2)
        {
            Console.WriteLine("Sub " +(n1 - n2));
        }
        public void Mul(double n1, double n2)
        {
            Console.WriteLine("Mul " + n1 * n2);
        }
        public void Div(double n1, double n2)
        {
            Console.WriteLine("Div " + n1 / n2);
        }
        public void Num(double n1, double n2)
        {
            Console.WriteLine("Num " + (n1 % n2));
        }
    }
}
