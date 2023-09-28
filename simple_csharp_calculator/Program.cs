// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIMPLE CALCULATOR");
            Console.WriteLine("\n");

            //Console.Write("Enter number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}