using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex3
{
    class mainapp
    {
        static void Main(string[] args)

        {

            Console.Write("정수를 입력하세요");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number <= 50)
            {
                Console.WriteLine($"입력하신정수 {number}는(은)50미만입니다.");
            }


            else
            {
                Console.WriteLine($"입력하신정수 {number}는(은)50이상입니다.");
            }

        }
    }
}


