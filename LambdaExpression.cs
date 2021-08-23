using System;
using System.Collections.Generic;

namespace CSharp
{
    delegate int Sum(int a, int b);

    class LambdaExpression
    {
        static void Main(string[] args)
        {
            // Anonymous Functions

            // using lambda ( C# 3.0 )
            //Sum myFunc1 = (int a, int b) =>
            Sum myFunc1 = (a, b) =>
            {
                return a + b;
            };

            // using delegate ( C# 2.0 )
            Sum myFunc2 = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(myFunc1(1, 2));
            Console.WriteLine(myFunc2(2, 3));


            // -> We must generate delegate types and instances. (not good. not productive)
        }
    }
}
