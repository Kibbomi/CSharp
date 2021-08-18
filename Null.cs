using System;
using System.Collections.Generic;

namespace CSharp
{
    class Point
    {
        public int x;
        public int y;
    }

    class Null
    {
        static void Main(string[] args)
        {
            // nullable variable 'a'
            int? a = null;  //null is not '0'
            a = 10;
            Console.WriteLine(a); //10


            //null 조건부 연산자
            Point pt = null;
            a = pt?.x;  //if 'class' pt is null then assign null to a
            Console.WriteLine(a);


            //null 병합 연산자
            a = null;
            Console.WriteLine(a ?? 100); //if a is null, print 100; else print a   
        }
    }
}
