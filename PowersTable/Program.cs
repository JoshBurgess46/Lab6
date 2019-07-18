using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Chart!");
            bool go = true;
            while (go)
            {
                Console.WriteLine("Would you like to continue? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Enter a number to start");
                    TableLook(ParseInput());
                }
                else
                {
                    Console.WriteLine("Have a great day! Good-Bye");
                    go = false;

                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();

            }
            
        }
        public static void TableLook(int num)
        {
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine("======  =======  ======");
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i}\t{NumberSquared(i)}\t{CubedNumbers(i)}");
            }
        }
        public static int ParseInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static int NumberSquared(int num)
        {
            return num *= num;
        }
        public static int CubedNumbers(int num)
        {
            return num *= num *= num;
        }
    }
}
