namespace ConsoleApp14
{
    using System;

    class Product
    {
        private double price;

        public string Name { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    Console.WriteLine("Invalid Price");
            }
        }

        public virtual double CalculateDiscount()
        {
            return price;
        }
    }

    class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05);
        }
    }

    class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15);
        }
    }

    class Program
    {
        static void Main()
        {
            Product p = new Electronics();

            p.Price = 20000;

            Console.WriteLine("Final Price after discount = " + p.CalculateDiscount());
        }
    }
}
