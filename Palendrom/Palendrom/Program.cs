using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palendrom
{
    class PalendromString
    {
        static void Main(string[] args)
        {
            string str;
            int i, j, count = 1;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            { 
            for (i = 0, j = str.Length - 1; i <= j; i++, j--)

            {
                    if (str[i] == str[j])

                    {

                    }
                    else
                    {
                        count = 0;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine("the no is palindrom");

                }
                else
                {
                    Console.WriteLine("the no is not a palindrom");
                }
            }
        }
    }
}
