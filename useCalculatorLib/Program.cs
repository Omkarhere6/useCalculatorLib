using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator;

namespace useCalculatorLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator.mathFuncs cal = new calculator.mathFuncs();
            Console.WriteLine("Enter the first number : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number : ");
            int B = Convert.ToInt32(Console.ReadLine());
            
            cal.Add(A, B);
            
            cal.Sub(A, B);
            
            cal.mul(A, B);
            
            cal.div(A, B);

            Console.ReadLine();
        }
    }
}
