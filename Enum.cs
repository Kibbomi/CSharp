using System;
using System.Collections.Generic;

namespace CSharp
{
    //class 한정자와 동일한 의미
    //namespace에 바로 위치할 수 있음.
    enum Date : int
    {
        SUN,//0
        MON,//1
        TUE,//2
        WED = 5,
        THU,//6
        FRI,//7
        SAT//8
    }

    enum Color { Red, Green, Blue} // default : int

    class Enum
    {
        static void Main(string[] args)
        {
            
        }
    }
}
