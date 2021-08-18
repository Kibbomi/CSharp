using System;
using System.Collections.Generic;

namespace CSharp
{
    class Parameters
    {
        #region use params (variable length parameter)

        static void Print(params string[] args)
        {
            foreach (string str in args)
                Console.WriteLine(str);
        }

        #endregion


        //in order from right to left
        static int Sum(int a, int b, int c = 10, int d = 100)
        {
            return a + b + c + d;
        }

        static void Main(string[] args)
        {

            // variable length parameters (params) (가변 길이 매개 변수)
            Print("Hello");
            Print("Hello", "C#");
            Print("Hello", "C#", "World!");

            // named parameters (명명된 매개 변수)
            Console.WriteLine(Sum(a : 1, b : 2, c : 3, d : 4));


            // optional parameters (선택적 매개 변수)
            Console.WriteLine(Sum(1, 1));
            Console.WriteLine(Sum(1, 1, 1));
            Console.WriteLine(Sum(1, 1, 1 ,1));
        }
    }
}
