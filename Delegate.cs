using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    //silimar to function pointer.. (C++)
    //original delegate
    delegate int MyDel(int a, int b);

    //generic delegate
    delegate T SumDel<T>(T a, T b);

    //delegate chain
    delegate T DelChain<T>(T a, T b);

    class Delegate
    {
        #region Methods
        public static int Sum(int a, int b)
        {
            Console.WriteLine("Sum");
            return a + b;
        }

        public static int Sub (int a, int b)
        {
            Console.WriteLine("Sub");
            return a - b;
        }

        public static int Mul (int a, int b)
        {
            Console.WriteLine("Mul");
            return a * b;
        }

        public static int Div(int a, int b)
        {
            Console.WriteLine("Div");
            if (b != 0)
                return a / b;
            else
                return 0;
        }
        #endregion

        static void Main(string[] args)
        {
            //MyDel Del1 = Sum;
            MyDel Del1 = new MyDel(Sum);
            Console.WriteLine(Del1(1, 2));

            //generic delegate
            SumDel<int> Del2 = Sum;
            Console.WriteLine(Del2(1, 2));

            //chain delegate
            DelChain<int> Del3 = new DelChain<int>(Sum) + new DelChain<int>(Sub) + new DelChain<int>(Mul) + new DelChain<int>(Div);
            Console.WriteLine(Del3(1, 2));

            //anonymous delegate
            DelChain<int> Del4 = delegate (int a, int b) { return a + b; } ;
            Console.WriteLine(Del4(100, 100));

            //anonymous delegate
            int[] array = { 9, 1, 6, 3, 8 };
            Array.Sort(array, delegate (int a, int b)
            {
                //descendent
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            foreach (int item in array)
                Console.WriteLine(item);
        }
    }
}