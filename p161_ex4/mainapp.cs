using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex4
{
	class mainapp
	{
		static void Main(string[] args)
		{
			Console.Write("몇월계절? :");
			string input = Console.ReadLine();
			int input1 = Convert.ToInt32(input);
			switch (input1)
			{

				case 3:
				case 4:
				case 5:
					Console.WriteLine($"입력하신 { input1}월은 봄 입니다.");
					break;
				case 6:
				case 7:
				case 8:
					Console.WriteLine($"입력하신 { input1}월은 여름 입니다.");
					break;
				case 9:
				case 10:
				case 11:
					Console.WriteLine($"입력하신 { input1}월은 가을 입니다.");
					break;
				case 12:
				case 2:
				case 1:
					Console.WriteLine($"입력하신 { input1}월은 겨울 입니다.");
					break;
			}
		}
	}
}
