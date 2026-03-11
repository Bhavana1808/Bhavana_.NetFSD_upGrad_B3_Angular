namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string name;
            double salary;
            double bonus;
            double finalSalary;
            int experience;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Experience: ");
            experience = int.Parse(Console.ReadLine());
            if (salary < 0)
            {
                Console.WriteLine("Salary cannot be nagative");
            }
            else
            {
                if (experience < 2)
                {
                    bonus = salary * 0.05;
                }
                else if (experience <= 5)
                {
                    bonus = salary * 0.10;
                }
                else
                {
                    bonus = salary * 0.15;
                }

                finalSalary = salary + bonus;

                Console.WriteLine("Employee: " + name);
                Console.WriteLine("Bonus: " + bonus);
                Console.WriteLine("Final Salary: " + finalSalary);
            }
        }

    }
}
