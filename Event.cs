using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    delegate void EventHandler(string msg);
    
    //어떤 객채의 변화를 감지하는 역할.
    //event는 클래스 외부에서 직접 호출할 수 없음. (등록은 가능)
    class Notifier
    {
        public event EventHandler myHandler;

        public void CheckNumber(int i)
        {
            if( i % 2 == 0)
            {
                myHandler("It is even number");
            }
        }
    }

    class Event
    {
        public static void EventOccured(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            //어떠한 일을 하는 객체를 선언, 할당
            Notifier myNotifier = new Notifier();
            myNotifier.myHandler += EventOccured; // 등록

            //객체를 통해 이벤트 사용
            for(int i=0; i< 10; ++i){
                myNotifier.CheckNumber(i);
            }

        }
    }
}