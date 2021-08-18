using System;
using System.Collections.Generic;

namespace CSharp
{
    class Switch
    {
        static void Main(string[] args)
        {
            short item = 14;

            //general switch 
            switch (item)
            {
                case 1:
                    //do somthing
                    break;

                case 2:
                    //do somthing
                    break;

                default:
                    //do somthing
                    break; 
            }



            // switch which has type check & condition check
            object obj = item;
            switch (obj)
            {
                case int i:
                    Console.WriteLine("This is a integer");
                    break;

                case float f:
                    Console.WriteLine("This is a float");
                    break;

                case short s when s >=10:
                    Console.WriteLine("This is a short which is greater than 10");
                    break;
            }

        }
    }
}
