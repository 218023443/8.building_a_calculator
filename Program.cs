using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.building_a_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert string to a number
            int num= Convert.ToInt32("45");
            Console.WriteLine(num+6);
            Console.Write("Enter num1: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            int num2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Answer is: ");
            Console.WriteLine(num1 + num2);

            // double
            Console.Write("Enter num3: ");
            double num3= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter num4: ");
            double num4= Convert.ToDouble(Console.ReadLine());
            Console.Write("Answer is: ");
            Console.WriteLine(num3 + num4);
            Console.Read();
        }
    }
}
