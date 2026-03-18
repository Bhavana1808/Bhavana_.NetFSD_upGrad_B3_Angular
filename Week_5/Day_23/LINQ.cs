namespace ConsoleApp23
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    namespace LinqProblems
    {
        class Product
        {
            public int ProductCode { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }
            public double Mrp { get; set; }
        }
        class Program
        {
            static void Main()
            {
                List<Product> products = new List<Product>()
            {
                new Product{ ProductCode=101, ProductName="Soap", Category="FMCG", Mrp=25 },
                new Product{ ProductCode=102, ProductName="Rice", Category="Grain", Mrp=50 },
                new Product{ ProductCode=103, ProductName="Oil", Category="FMCG", Mrp=120 },
                new Product{ ProductCode=104, ProductName="Wheat", Category="Grain", Mrp=40 },
                new Product{ ProductCode=105, ProductName="Shampoo", Category="FMCG", Mrp=30 }
            };
                // 1st one

                var fmcg = products.Where(p => p.Category == "FMCG");
                Console.WriteLine("FMCG Products:");
                foreach (var p in fmcg)
                {
                    Console.WriteLine($"Code: {p.ProductCode} | Name: {p.ProductName} | Category: {p.Category} | MRP: {p.Mrp}");
                }
                // 2nd one

                var grainProducts = products.Where(p => p.Category == "Grain");
                Console.WriteLine("Grain Products:");
                foreach (var p in grainProducts)
                {
                    Console.WriteLine($"Code: {p.ProductCode} | Name: {p.ProductName} | Category: {p.Category} | MRP: {p.Mrp}");
                }
                // 3rd one

                var sortCode = products.OrderBy(p => p.ProductCode);
                Console.WriteLine("Sort by Product Code:");
                foreach (var p in sortCode)
                {
                    Console.WriteLine($"Code: {p.ProductCode} | Name: {p.ProductName} | Category: {p.Category} | MRP: {p.Mrp}");
                }
                // 4th one

                var sortCategory = products.OrderBy(p => p.Category);
                Console.WriteLine("Sort by Category:");
                foreach (var p in sortCategory)
                {
                    Console.WriteLine($"Code: {p.ProductCode} | Name: {p.ProductName} | Category: {p.Category} | MRP: {p.Mrp}");
                }
                // 5th one

                var sortMrpAsc = products.OrderBy(p => p.Mrp);
                Console.WriteLine("Sort by MRP Ascending:");
                foreach (var p in sortMrpAsc)
                {
                    Console.WriteLine($"Code: {p.ProductCode} | Name: {p.ProductName} | Category: {p.Category} | MRP: {p.Mrp}");
                }
                // 6th one

                var sortMrpDesc = products.OrderByDescending(p => p.Mrp);
                Console.WriteLine("Sort by MRP Descending:");
                foreach (var p in sortCode)
                {
                    Console.WriteLine($"Code: {p.ProductCode} | Name: {p.ProductName} | Category: {p.Category} | MRP: {p.Mrp}");
                }
                // 7th one

                var groupCategory = products.GroupBy(p => p.Category);
                Console.WriteLine("Group by Category:");
                foreach (var group in groupCategory)
                {
                    Console.WriteLine("Category: " + group.Key);
                    foreach (var p in group)
                        Console.WriteLine(p.ProductName);
                }
                // 8th one

                var groupMrp = products.GroupBy(p => p.Mrp);
                Console.WriteLine("Group by MRP:");
                foreach (var g in groupMrp)
                {
                    Console.WriteLine("MRP: " + g.Key);
                    foreach (var p in g)
                        Console.WriteLine(p.ProductName);
                }
                // 9th one

                var maxFmcg = products
                    .Where(p => p.Category == "FMCG")
                    .OrderByDescending(p => p.Mrp)
                    .FirstOrDefault();
                if (maxFmcg != null)
                    Console.WriteLine($"{maxFmcg.ProductName} - {maxFmcg.Mrp}");

                // 10th one

                int totalCount = products.Count();
                Console.WriteLine("Count Total Products");
                Console.WriteLine("Total Products: " + products.Count());

                // 11th one

                int fmcgCount = products.Count(p => p.Category == "FMCG");
                Console.WriteLine("Count FMCG Produts");
                Console.WriteLine("FMCG Count: " + products.Count(p => p.Category == "FMCG"));

                // 12th one

                double maxPrice = products.Max(p => p.Mrp);
                Console.WriteLine("Max Price");
                Console.WriteLine("Max Price: " + products.Max(p => p.Mrp));

                // 13th one

                double minPrice = products.Min(p => p.Mrp);
                Console.WriteLine("Min Price");
                Console.WriteLine("Min Price: " + products.Min(p => p.Mrp));


                // 14th one

                bool allBelow30 = products.All(p => p.Mrp < 30);
                Console.WriteLine("All Products below 30");
                Console.WriteLine("All below 30: " + products.All(p => p.Mrp < 30));


                // 15th one

                bool anyBelow30 = products.Any(p => p.Mrp < 30);
                Console.WriteLine("Any Product below 30");
                Console.WriteLine("Any below 30: " + products.Any(p => p.Mrp < 30));
            }



        }

    }
