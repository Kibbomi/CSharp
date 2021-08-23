using System;
using System.Collections.Generic;

namespace CSharp
{
    class Reflection
    {
        //reflection can help to analysis a type

        class Point
        {
            public Point() { }
            public Point(int x_, int y_)
            {
                x = x_;
                y = y_;
            }

            public void Print()
            {
                Console.WriteLine($"x : {x}, y : {y}");
            }

            public int x { get; set; } = 0;
            public int y { get; set; } = 0;
        }
            

        static void Main(string[] args)
        {
            Point pt1 = new Point();

            //Type.. 
            Type type = pt1.GetType();

            var Constructors = type.GetConstructors();

            //ctor is constructor
            foreach (var item in Constructors)
                Console.WriteLine($"Constructor : {item.Name}");

            var Fields = type.GetFields();

            foreach (var item in Fields)
                Console.WriteLine($"Fields : {item.Name}");

            var Members = type.GetMembers();

            foreach (var item in Members)
                Console.WriteLine($"Member : {item.Name}");
            //etc...


            //generate instance by type(GetType())
            Point pt2 = Activator.CreateInstance(type) as Point;
            pt2.x = 10;
            pt2.y = 100;
            pt2.Print();
        }
    }
}
