using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[100];
                Console.WriteLine("Number of elements in the array ?");
                string firststring = Console.ReadLine();

                int firstvalue = Int32.Parse(firststring);

                Console.WriteLine(" Enter array elements ");

                for (int i = 0; i < firstvalue; i++)
                {
                    string secondstring = Console.ReadLine();
                    a[i] = Int32.Parse(secondstring);
                }
                Array.Sort(a);
                Console.WriteLine("Enter Search element");

                string thirdstring = Console.ReadLine();
                int secondvalue = Int32.Parse(thirdstring);
                int low = 0;
                int high = firstvalue - 1;
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (secondvalue < a[mid])
                        high = mid - 1;
                    else if (secondvalue > a[mid])
                        low = mid + 1;
                    else if (secondvalue == a[mid])
                    {

                        Console.WriteLine("Elemen found at location {1}, secondvalue, mid + 1");
                        return;
                    }
                }
                Console.WriteLine("Search unsuccessful");
            }

            catch (Exception e)
            {
                Console.WriteLine("entered wrong value");
            }
        }
    }
}
