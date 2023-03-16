using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex3
{
	class mainapp
	{
		static void Main(string[] args)
		{
			Console.Write("몇월이궁금하세요? :");
			string input = Console.ReadLine();
			int input1 = Convert.ToInt32(input);
			switch (input1)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.WriteLine("31일 까지 있습니다.");
					break;

				case 4:
				case 6:
				case 9:
				case 11:
					Console.WriteLine("30일 까지 있습니다");
					break;

				case 2:
					Console.WriteLine("28일 까지 있습니다");
					break;

			}
		}
	}
}
