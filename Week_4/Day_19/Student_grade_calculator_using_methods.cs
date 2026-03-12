namespace ConsoleApp4
{

    using System;

    class Student
    {
        public double CalculateAverage(int m1, int m2, int m3)
        {
            double avg;
            avg = (m1 + m2 + m3) / 3.0;
            return avg;
        }
    }

    class Program
    {
        static void Main()
        {
            int m1;
            int m2;
            int m3;

            Console.Write("Enter mark 1: ");
            m1 = int.Parse(Console.ReadLine());

            Console.Write("Enter mark 2: ");
            m2 = int.Parse(Console.ReadLine());

            Console.Write("Enter mark 3: ");
            m3 = int.Parse(Console.ReadLine());

            Student s = new Student();

            double average = s.CalculateAverage(m1, m2, m3);

            string grade;

            if (average >= 80)
                grade = "A";
            else if (average >= 60)
                grade = "B";
            else if (average >= 50)
                grade = "C";
            else
                grade = "Fail";

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Grade = " + grade);
        }
    }
}
