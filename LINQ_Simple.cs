using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    class LINQ_Simple
    {
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query :
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;
            /* from : choose data source
             * where : condition
             * select : return type
             */
            foreach (int num in numQuery)
                Console.WriteLine(num);
            
            List<int> numQuery2 =
                (from num in numbers
                 where (num % 2) == 0
                 select num).ToList();

            for (int i = 0; i < numQuery2.Count; ++i)
                Console.WriteLine(numQuery2[i]);
        }
    }
}
 