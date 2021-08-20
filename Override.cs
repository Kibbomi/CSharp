using System;
using System.Collections.Generic;

namespace CSharp
{
    class Override
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
                Console.WriteLine($"Point, x : {this.x}, y : {this.y}");
            }

            public virtual double getArea()
            {
                return 0;
            }

            public int x { get; set; }
            public int y { get; set; }
        }

        class Circle : Point
        {
            public Circle() : base()
            {
                this.r = 0;
            }

            public Circle(int x_, int y_, int r_) : base(x_, y_)
            {
                this.r = r_;
            }

            override public void Print()
            {
                Console.WriteLine($"Circle, x : {this.x}, y : {this.y} r : {this.r}");
            }

            new public double getArea() //seal point's getArea
            {
                return Math.PI * r * r;
            }

            public int r { get; set; }
        }

        static void Main(string[] args)
        {
            Point pt1 = new Point();
            pt1.Print(); // point's print

            Point pt2 = new Circle();
            pt2.Print(); // circle's print

            Circle cir = new Circle();
            cir.Print(); // circle's print


            //virtual (base) ----> override (derived)
            // Heap에 존재하는 객체의 Type을 따르도록 함.(C++과 동일)   


            //derived class에 new 숨기고 override를 하지 않는다면
            //case 2 는 circle's print 가 아니고 point's print가 실행됨.
        }
    }
}