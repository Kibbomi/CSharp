using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    class Point<T>
    {
        public Point() { }
        public Point(T x_, T y_)
        {
            x = x_;
            y = y_;
        }

        public void Print()
        {
            Console.WriteLine($"x : {x}, y : {y}");
        }
        public T x { get; set; }
        public T y { get; set; }  
    }
   
    class Generic_class
    {
        /*
         * public static T GenericMethod <T, U> (T a, U b) where T : conditions
         * {
         *  //implement
         * }
         */

        /*
         * <T> where T :
         * class -> T must be reference type
         * struct -> T must be value type
         * new() -> T must have constructor which doesn't have any parameters
         * BaseClass(anything) : T must inherit BaseClass ,,,T : BaseClass
         * Interface(anything) : Same
         * 
         */
        static void Main(string[] args)
        {
            Point<int> pt1 = new Point<int>(1, 2);
            Point<double> pt2 = new Point<double>(1.5, 2.5);


            pt1.Print();
            pt2.Print();

        }
    }
}