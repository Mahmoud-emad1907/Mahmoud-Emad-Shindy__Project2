using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahmoud_Emad_Shindy__Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number"); int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sand number"); int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = num1; i < num2; i++)
            {
                decimal sum = 0;
                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                        sum = sum + x;
                }
                    if (sum == i)
                    {
                        Console.WriteLine(i);
                    }
            }
        }
    }
}
