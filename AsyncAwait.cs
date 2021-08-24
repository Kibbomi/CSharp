using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharp
{
    //https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/async/

    /* async return type
     * Task - return nothing but do(perform) a task
     * Task<TResult> return a value
     * void - a event handler
     */

    #region Class
    class Coffee { }
    class Egg { }
    class Bacon { }
    class Toast { }
    class Juice { }
    #endregion

    class AsyncAwait
    {
        #region sync functions
        public static Juice PourOrangeJuice()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        public static void ApplyJam(Toast toast)
        {
            Console.WriteLine("Putting jam on the toast");
        }

        public static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
        }
        #endregion

        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            for(int slice = 0; slice <slices; ++slice)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        public static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for(int slice = 0; slice < slices; ++slice)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }


        public static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        public static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring Coffee");
            return new Coffee();
        }

        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            #region synchronization
            /*Coffee cup = PourCoffee();
            Console.WriteLine("Coffee is ready");

            Egg eggs = FryEggs(2);  //6s
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3); //3s x 2 = 6s
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2); //3s
            ApplyButter(toast); //0s
            ApplyJam(toast); //0s .. dependent.
            Console.WriteLine("toast is ready");

            Juice orangeJuice = PourOrangeJuice(); //0s
            Console.WriteLine("orange Juice is ready");
            Console.WriteLine("Breakfast is ready!");*/
            #endregion


            #region asynchronization
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = ToastBreadAsync(2);

            /*await Task.WhenAll(eggsTask, baconTask, toastTask);
             *Console.WriteLine("eggs are ready");
             *Console.WriteLine("bacon is ready");
             *Console.WriteLine("toast is ready");
             *Console.WriteLine("Breakfast is ready!");*/

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };

            while(breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);

                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    ApplyButter(toastTask.Result);
                    ApplyJam(toastTask.Result); // putting in async func is ok too.
                    Console.WriteLine("toast is ready");
                }

                breakfastTasks.Remove(finishedTask);
            }

            Juice orangeJuice = PourOrangeJuice();
            Console.WriteLine("orange Juice is ready");
            Console.WriteLine("Breakfast is ready!");


            #endregion


             sw.Stop();
            Console.WriteLine("Time : " + sw.ElapsedMilliseconds + " ms");

        }
    }
}
 