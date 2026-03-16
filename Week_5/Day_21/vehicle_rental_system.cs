namespace ConsoleApp15
{
    using System;

    class Vehicle
    {
        public string Brand { get; set; }
        public double RentalRatePerDay { get; set; }

        public virtual double CalculateRental(int days)
        {
            return RentalRatePerDay * days;
        }
    }

    class Car : Vehicle
    {
        public override double CalculateRental(int days)
        {
            return (RentalRatePerDay * days) + 500;
        }
    }

    class Bike : Vehicle
    {
        public override double CalculateRental(int days)
        {
            double total = RentalRatePerDay * days;
            return total - (total * 0.05);
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle v = new Car();

            v.RentalRatePerDay = 2000;

            Console.WriteLine("Total Rental = " + v.CalculateRental(3));
        }
    }
}
