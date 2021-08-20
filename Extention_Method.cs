using System;
using System.Collections.Generic;

namespace CSharp
{
    //static class !!!
    static class MyExtention
    { 
        //this가 오고 우측에는 매개변수목록이 옴.
        public static int Power(this int num, int exp)
        {
            for (int i = 0; i < exp; ++i)
                num *= num;
            return num;
        }
    }

    class Extention_Method
    {
        static void Main(string[] args)
        {
            //이렇게 사용할 수 있음.
            Console.WriteLine(2.Power(3));

            //static class
            //static function & this modifier is placed as first argument.
        }
    }
}