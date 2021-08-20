using System;
using System.Collections.Generic;

namespace CSharp
{
    class Point
    {
        Point() { }
        Point(int x_, int y_)
        {
            x = x_;
            y = y_;
        }

        public int x { get; set; }
        public int y { get; set; }
    }

    class Array
    {
        static void Main(string[] args)
        {
            #region array 1d, 2d, 3d...
            int[] arr0 = { 1, 2, 3 };
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5]; // 0, 0, 0, 0, 0
            
            int[,] arr3 = new int[2, 3] { { 1,2,3 },{ 4,5,6 } };
            int[,] arr4 = new int[2, 3]; //0,0,0,0

            for (int i = 0; i < 2; ++i){
                for (int j = 0; j < 3; ++j)
                    Console.Write($"{arr3[i, j]} ");
                Console.WriteLine();
            }
            // int[,,] arr5 = new int[2,2,2] {{ { , }, { , }}, {{ , },{ , }}}
            #endregion

            #region Jagged Array
            int[][] jagged = new int[3][]; // 3개의 행을가진 2차원 Vector(C++)를 선언한 것 같은 느낌

            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[3] { 6, 7, 8 };
            jagged[2] = new int[2] { 9, 10 };

            for (int i = 0; i < jagged.Length; ++i)
            {
                for (int j = 0; j < jagged[i].Length; ++j)
                    Console.Write($"{jagged[i][j]} ");
                Console.WriteLine();
            }
            #endregion

            #region Array class static methods
            int[] arr = new int[] { 5, 4, 3, 2, 1 };
            System.Array.Sort(arr); //1, 2, 3, 4, 5
            System.Array.BinarySearch(arr, 3); //return index of target number
            System.Array.Resize<int>(ref arr, 10); // 1, 2, 3, 4, 5, 0, 0, 0, 0, 0  C++과 동일
            System.Array.Clear(arr, 0, arr.Length); //0, 0, ..., 0

            foreach (int item in arr)
                Console.WriteLine(item);

            #endregion

    }
}