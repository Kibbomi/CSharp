using System;
using System.Collections.Generic;

namespace CSharp
{
    class Constructor
    {
        class Point
        {
            //default constructor is removed when I define another constructor
            public Point()
            {
                Console.WriteLine("Default constructor");
                x = 0;
                y = 0;
            }

            public Point(int x_, int y_)
            {
                Console.WriteLine("Constructor");
                x = x_;
                y = y_;
            }

            //Class is a reference variable, so it doesnt have to need 'const' modifier like C++...
            public Point(Point pt)
            {
                Console.WriteLine("Copy constructor");
                x = pt.x;
                y = pt.y;
            }

            public void Print()
            {
                Console.WriteLine($"x : {this.x}, y : {this.y}");
            }

            public int x { get; set; }
            public int y { get; set; }
        }


        static void Main(string[] args)
        {
            //pt1, pt2, pt3 have their own memory in heap area.
            Point pt1 = new Point();
            Point pt2 = new Point(1, 2);
            Point pt3 = new Point(pt2);

            //reference variable.(in stack area)
            Point ptRef;

            //ptRef refer a pt1(ptRef -----> pt1)
            ptRef = pt1;
            ptRef.x = 100;
            ptRef.y = 100;

            //they have same values
            ptRef.Print();
            pt1.Print();
            
        }
    }
}
