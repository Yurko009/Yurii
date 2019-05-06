using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write(number.ToString());
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
