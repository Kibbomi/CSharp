using System;
using System.IO;
using System.Text;

namespace CSharp
{
    class Files
    {
        static void Main(string[] args)
        {
            Stream s = new FileStream("FileName.txt", FileMode.Append);
            //Stream s = new FileStream("FileName.txt", FileMode.Create);...
            //FileMode.Open, OPenOrCreate, Truncate, Append....

            /*
             * s.Write(
             * byte [] array, // 쓸 데이터가 담겨있는 byte 배열
             * int offset, // byte배열의 어디서부터 시작할 것인지
             * int count, // 기록할 데이터의 총 길이 (단위는 byte)
             */

            int a = 10;
            byte[] wBytes = BitConverter.GetBytes(a);
            // Encoding.Default.GetBytes(string OR char[])


            // 바이트로 읽는것이 불편함..
            // 그래서 Writer, Reader Class가 있음.

            StreamWriter sw = new StreamWriter(s);
            sw.WriteLine();

            StreamReader sr = new StreamReader(new FileStream("FileName.txt",FileMode.Open));
            sr.ReadLine(); // return string

        }
    }
}
