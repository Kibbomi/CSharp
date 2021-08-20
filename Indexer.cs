using System;
using System.Collections.Generic;

namespace CSharp
{
    class Point
    {
        public Point() { }
        public Point(int x_, int y_)
        {
            x = x_;
            y = y_;
            array = new string[] { "default", "default", "default" };
        }

        #region Indexer
        public string this[int idx]
        {
            get
            {
                return array[idx];
            }
            set
            {
                if(idx < array.Length)
                    array[idx] = value; 
            }
        }



        public string[] array { get; set; }
        #endregion

        public int x { get; set; }
        public int y { get; set; }
        
    }




    class Indexer
    {
        static void Main(string[] args)
        {
            Point pt = new Point(1,2);

            for(int i=0; i<pt.array.Length; ++i)
                Console.WriteLine(pt[i]);

            pt[1] = "CHANGED!";

            for (int i = 0; i < pt.array.Length; ++i)
                Console.WriteLine(pt[i]);
        }
    }
}