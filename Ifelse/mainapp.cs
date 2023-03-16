using System;


namespace Ifelse
{
    class mainapp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("숫자를 입력하세요 : ");

            string input = Console.ReadLine();   //사용자에게 입력값을 받아라
            int number = Int32.Parse(input);  //입력값은 1차적으로 '문자열'로 받는다.
            //형변환 문자열-숫자형으로 변화 
            //형변환이 없으면 모든경우의 수를 적어야 한다.
            if (number < 0)
            {
                Console.WriteLine("음수");
            }
            else if (number > 0)
            {
                Console.WriteLine("양수");
            }
            else
            { Console.WriteLine("0"); }

            //조건연산자 변경. 처리속도가 빠름 
            //Console.WriteLine.(number $2 == ? "짝수" :  "홀수");
            if (number % 2 == 0)
            { Console.WriteLine("짝수"); }
            else
            { Console.WriteLine("홀수"); }










        }
    }
}
