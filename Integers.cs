using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Integers
    {
        public void myMethod(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(result);
        }

        public decimal myMethod (out decimal num2)
        {
            Console.WriteLine("Please put in a decimal");
            num2 = Convert.ToDecimal(Console.ReadLine());
            num2++;
            //decimal num3 = num2 * 15;
            //int final = Convert.ToInt32(num3);
            return num2;

            

        }
        
    }
}
