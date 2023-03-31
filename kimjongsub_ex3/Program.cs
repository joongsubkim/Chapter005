using System;

namespace kimjongsub_ex3
{

    class mainapp
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                int j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}

        