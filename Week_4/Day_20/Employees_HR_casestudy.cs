namespace ConsoleApp7
{
    using System;

    class Employee
    {
        private string fullName;
        private int age;
        private decimal salary;
        private readonly string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");

                fullName = value.Trim();
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 80)
                    throw new ArgumentException("Age must be between 18 and 80");

                age = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 1000)
                    throw new ArgumentException("Salary cannot be below 1000");

                salary = value;
            }
        }

        public Employee(string name, decimal startSalary, int age)
        {
            employeeId = "E" + new Random().Next(1000, 9999);

            FullName = name;
            Age = age;
            Salary = startSalary;
        }

        public void GiveRaise(decimal percentage)
        {
            if (percentage <= 0 || percentage > 30)
                throw new ArgumentException("Raise must be between 0 and 30%");

            Salary = Salary * (1 + percentage / 100);
            Console.WriteLine("Salary increased to: " + Salary);
        }

        public bool DeductPenalty(decimal amount)
        {
            if (amount <= 0)
                return false;

            if (Salary - amount < 1000)
                return false;

            Salary -= amount;
            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("Marko Horvat", 4500m, 35);

            Console.WriteLine(emp.EmployeeId);
            Console.WriteLine(emp.FullName);
            Console.WriteLine(emp.Salary);

            emp.GiveRaise(10);

            bool result = emp.DeductPenalty(200);

            Console.WriteLine("Penalty Applied: " + result);
            Console.WriteLine("Final Salary: " + emp.Salary);
        }
    }
}
