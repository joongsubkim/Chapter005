using System;


namespace kimjongsub_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("반복횟수를 입력하세요 :  ");
            string repeat = Console.ReadLine();
            int a = int.Parse(repeat);

            if (a > 0)
            {
                Console.WriteLine();
                for (int i = 0; i < a; i++)
                {

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수 는 입력할 수 없습니다.");
            }
        }
    }
}
