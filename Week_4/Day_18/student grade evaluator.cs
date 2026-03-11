namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string name;
                int marks;

                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                Console.Write("Enter Marks: ");
                marks = int.Parse(Console.ReadLine());

                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid Marks");
                }
                else if (marks >= 80)
                {
                    Console.WriteLine("Student: " + name);
                    Console.WriteLine("Grade: A");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine("Student: " + name);
                    Console.WriteLine("Grade: B");
                }
                else if (marks >= 50)
                {
                    Console.WriteLine("Student: " + name);
                    Console.WriteLine("Grade: C");
                }
                else if (marks >= 40)
                {
                    Console.WriteLine("Student: " + name);
                    Console.WriteLine("Grade: D");
                }
                else
                {
                    Console.WriteLine("Student: " + name);
                    Console.WriteLine("Grade: Fail");
                }
            }
        }
       
        }
    