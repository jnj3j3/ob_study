using System;

namespace yoon_year
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int year = int.Parse(Console.ReadLine());
                if (year < 1 || year > 3000)
                {
                    Console.WriteLine("다시입력해주세요.");
                    continue;
                }

                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) Console.WriteLine(year + "년은 윤년입니다.");
                else Console.WriteLine(year + "년은 평년입니다.");
            }
        }
    }
}
