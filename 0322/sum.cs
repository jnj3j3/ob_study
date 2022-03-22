using System;

namespace _0322
{
    class sum
    {
        static void SumAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) sum = sum + arr[i];

            Console.WriteLine("sum : " + sum);
            Console.WriteLine("avg : " + sum / arr.Length);
        }
        static void Main(string[] args)
        {
            int[] abc = { 1, 2, 3, 4, 5 };
            SumAvg(abc);
        }
    }
}
