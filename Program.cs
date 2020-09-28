using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine()); 
            Integers intobj1 = new Integers();
            intobj1.myMethod(num1);


            decimal num2;
            intobj1.myMethod( out num2);
            Console.WriteLine("your number + 1 = " + num2);
            Console.ReadLine();

            
        }
    }
}
