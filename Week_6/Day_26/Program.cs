using System;

class Program
{
    static void Main()
    {
        ProductDataAccess db = new ProductDataAccess();

        while (true)
        {
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Product p = new Product();

                    Console.Write("Name: ");
                    p.ProductName = Console.ReadLine();

                    Console.Write("Category: ");
                    p.Category = Console.ReadLine();

                    Console.Write("Price: ");
                    p.Price = decimal.Parse(Console.ReadLine());

                    db.InsertProduct(p);
                    break;

                case 2:
                    db.GetAllProducts();
                    break;

                case 3:
                    Product up = new Product();

                    Console.Write("ID: ");
                    up.ProductId = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    up.ProductName = Console.ReadLine();

                    Console.Write("Category: ");
                    up.Category = Console.ReadLine();

                    Console.Write("Price: ");
                    up.Price = decimal.Parse(Console.ReadLine());

                    db.UpdateProduct(up);
                    break;

                case 4:
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    db.DeleteProduct(id);
                    break;

                case 5:
                    return;
            }
        }
    }
}