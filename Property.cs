using System;
using System.Collections.Generic;

namespace CSharp
{   
    public class Circle
    {
        public Circle() {  }
        public Circle(int x_, int y_, int r_)
        {
            x = x_;
            y = y_;
            r = r_;
        }

        public void Print()
        {
            Console.WriteLine($"circle, x : {x}, y : {y}, r : {r}");
        }

        public int x;

        //To remove getter, setter method. property.
        public int X
        { 
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        //Auto-implemented Property & initialize
        public int y { get; set; } = 5;
        public int r { get; set; }
    }


    class Property
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.Print(); //0, 5, 0

            //initialization by property
            Circle cir1 = new Circle() { x = 10, y = 5, r = 100};
            cir1.Print(); // 10, 5, 100
        }
    }
}