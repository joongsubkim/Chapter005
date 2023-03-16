using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{

    class mainapp
    {
        static void Main(string[] args)
        {

            Console.Write("세 개의 정수중 첫번째 정수를 입력하세요 ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            Console.Write("세 개의 정수중 두번째 정수를 입력하세요 ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            Console.Write("세 개의 정수중 세번째 정수를 입력하세요 ");
            string input3 = Console.ReadLine();
            int number3 = Convert.ToInt32(input3);

            int[] numberarr = { number1, number2, number3 };
            int max = numberarr.Max();
            int min = numberarr.Min();
            Console.WriteLine($"입력하신 세 개의 정수 {number1}, {number2}, {number3} 중 최대값은 {max} 이며 최소값은 {min}입니다.");

        }
    }
}