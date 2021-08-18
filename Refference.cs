using System;
using System.Collections.Generic;

namespace CSharp
{
    class Refference
    {
        #region refference
        static void Swap(int lhs, int rhs)
        {
            int temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Swap (ref int lhs, ref int rhs)
        {
            int temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        #endregion

        #region refference(out) for returning

        //static void Division(int dividend, int divisor, ref int quotient, ref int remainder)
        static void Division(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        #endregion


        static void Main(string[] args)
        {
            #region refference
            
            int a = 10, b = 100;
            Console.WriteLine($"before swapping a : {a} b : {b}\n");

            Console.WriteLine("Swap , pass by value");
            Swap(a, b);
            Console.WriteLine($"after swapping a : {a} b : {b}\n");

            Console.WriteLine("Swap , pass by reference");
            Swap(ref a, ref b);
            Console.WriteLine($"after swapping a : {a} b : {b}\n");

            #endregion

            int q = 0, r = 0;
            Division(10, 3, out q, out r);
            //Division(10, 3, ref q, ref r);
            Console.WriteLine($"10 / 3 = {q}, {r}");
        }
    }
}
