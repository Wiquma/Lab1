using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number and press enter: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number and press enter: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("result=" + Sum(a, b));
        }
        public static int Sum(int a, int b)
        {
            return (a + b);
        }

    }
    
}
