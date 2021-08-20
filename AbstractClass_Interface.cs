using System;
using System.Collections.Generic;

namespace CSharp
{
    interface ICalculatable
    {
        double getArea();
    }

    //it is very similar to abstract class of C++,,,, the purpose, grammar.. 
    public abstract class Point
    {
        public Point() { }
        public Point(int x_, int y_) { x = x_;y = y_; }

        public abstract void Print();
       
        public abstract int x {get; set;}
        public abstract int y { get; set; }
    }

    public class Circle : Point, ICalculatable
    {

        public Circle() { }
        public Circle(int x_, int y_, int r_) : base(x_, y_)
        {
            r = r_;
        }

        //from abstract class
        public override void Print()
        {
            Console.WriteLine($"Circle, x : {x}, y : {y}, r : {r}");
        }

        //from interface
        public double getArea()
        {
            return Math.PI * r * r;
        }

        //from abstract class
        public override int x { get; set; }
        public override int y { get; set; }


        public int r { get; set; }


    }
    class AbstractClass_Interface
    {
        static void Main(string[] args)
        {
            //Point pt = new Point(1,2) -> error!

            Circle cir = new Circle(1, 2, 3);
            cir.Print();
            Console.WriteLine($"cir, area is {cir.getArea()}");
        }
    }
}