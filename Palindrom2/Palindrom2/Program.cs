using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom2
{
    class palindromNum
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, tempval;
            Console.Write("Enter a number ");
            num = Convert.ToInt32(Console.ReadLine());
            tempval = num;
            while (num > 0)
            {
                rem = num % 10;  
                num = num / 10;
                sum = sum * 10 + rem; 
                           
            }
           
            if (tempval==sum)
            {
                Console.WriteLine(" Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome");
            }
           


        }
    }
}
