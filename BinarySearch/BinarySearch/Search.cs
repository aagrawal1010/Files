using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Search
    {
        public void search(int[] arr)
        {
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

    }
}
