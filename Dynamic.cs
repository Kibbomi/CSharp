using System;
using System.Collections;

namespace CSharp
{
    class Dynamic
    {
        static void PrintDynamic(dynamic val)
        {
            Console.WriteLine(val);
        }

        static void PrintObject(object val)
        {
            Console.WriteLine(val);
        }

        static void Main(string[] args)
        {
            dynamic a = "apple";
            var b = "apple";
            object c = "apple";

            //dynamic type is similar to object type.

            Console.WriteLine(b.Length); // compile time
            //Console.WriteLine(a.brix); compile OK, runtime NO!

            PrintDynamic("Hello C# World!");
            PrintDynamic(1000);
            PrintDynamic(1.4);
            PrintDynamic(true);
            PrintDynamic(DateTime.Now);

            //casting에 시간을 사용함.
            PrintObject("Hello C# World!");
            PrintObject(1000);
            PrintObject(1.4);
            PrintObject(true);
            PrintObject(DateTime.Now);

            object o = 10;
            o = (int)o + 10; //casting이 필요

            dynamic d = 10;
            d = d + 10;

            var v = 10;
            v = v + 10;
        }
    }
}
 