using System;
using System.Collections.Generic;

namespace CSharp
{   
    class AnonymousType
    {
        static void Main(string[] args)
        {
            var item = new { damage = 1, speed = 5 };

            //anonymous type -> READ ONLY!!!
            Console.WriteLine(item.damage);
            Console.WriteLine(item.speed);

            //item.speed = 100 -> ERROR!
        }
    }
}