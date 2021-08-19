using System;
using System.Collections.Generic;

namespace CSharp
{
    class derived_constructor
    {
        class Point
        {
            public Point()
            {
                x = 0;
                y = 0;
            }

            public Point(int x_, int y_)
            {
                x = x_;
                y = y_;
            }

            public virtual void Print()
            {
                Console.WriteLine($"x : {this.x}, y : {this.y}");
            }

            public int x { get; set; }
            public int y { get; set; }
        }

        class Circle : Point
        {
            //constructor
            public Circle() : base() //this()도 있음.
            {
                this.r = 0;
            }

            public Circle(int x_, int y_, int r_) : base(x_, y_)
            {
                this.r = r_;
            }

            override public void Print()
            {
                Console.WriteLine($"x : {this.x}, y : {this.y} r : {this.r}");
            }

            public int r { get; set; }
        }

        static void Main(string[] args)
        {
            Point pt = new Circle(1, 2, 3);
            pt.Print(); //Circle -> Print()
        }
    }
}