using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class Prime
    {
        static void Main(string[] args)
        { 
         Console.Write("Enter a Number");
            int num, count = 0;
        num = Convert.ToInt32(Console.ReadLine());
          
       
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
}
            if (count==2)
            { 
                Console.WriteLine("Entered Number is a Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
          
        }
    }
}
           
