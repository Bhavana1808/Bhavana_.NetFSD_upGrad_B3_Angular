namespace ConsoleApp3
{
    using System;

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main()
        {
            int a;
            int b;

            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            Calculator c = new Calculator();

            int addResult = c.Add(a, b);
            int subResult = c.Subtract(a, b);

            Console.WriteLine("Addition = " + addResult);
            Console.WriteLine("Subtraction = " + subResult);
        }
    }
}
