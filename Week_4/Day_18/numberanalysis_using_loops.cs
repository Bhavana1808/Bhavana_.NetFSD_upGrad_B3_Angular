namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n;
                int evenCount = 0;
                int oddCount = 0;
                int sum = 0;
                int i;

                Console.Write("Enter Number: ");
                n = int.Parse(Console.ReadLine());

                for (i = 1; i <= n; i++)
                {
                    sum = sum + i;

                    if (i % 2 == 0)
                        evenCount++;
                    else
                        oddCount++;
                }

                Console.WriteLine("Even Count: " + evenCount);
                Console.WriteLine("Odd Count: " + oddCount);
                Console.WriteLine("Sum: " + sum);
            }
        }
    }
