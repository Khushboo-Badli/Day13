using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LINQ_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 5, 0, 3, 89, 56, 4 };//aarray of integers
            var result = from a
                         in num
                         where a < 7
                         orderby a
                         select a;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
