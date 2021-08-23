using System;
using System.Collections.Generic;

namespace CSharp
{
    class Func_Action
    {
        static void Main(string[] args)
        {
            /*Func & Action are delegate
             *Func -> has return value
             *Action -> doesn't have return value
             */



            //<TReturn>
            //<T1, TReturn>
            //<T1,...,T16, TReturn>
            Func<int, int, int> myDel1 = (int a, int b) => { return a + b; };




            //<>
            //<T1>
            //<T1, ..., T16>
            Action<string> myDel2 = (string msg) => { Console.WriteLine(msg); };

            Console.WriteLine(myDel1(1, 2));
            myDel2("This is a 'Action' delegate");
        }
    }
}
