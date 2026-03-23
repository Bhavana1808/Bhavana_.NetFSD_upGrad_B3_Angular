using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Application Started...\n");

        // Calling async logging multiple times
        Task log1 = WriteLogAsync("User logged in");
        Task log2 = WriteLogAsync("Product viewed");
        Task log3 = WriteLogAsync("Order placed");

        Console.WriteLine("Logs are being written asynchronously...\n");

        // Wait for all logs to complete
        await Task.WhenAll(log1, log2, log3);

        Console.WriteLine("\nAll logs written successfully!");
    }

    // Async method to simulate file writing
    static async Task WriteLogAsync(string message)
    {
        Console.WriteLine($"Start writing log: {message}");

        // Simulate file I/O delay
        await Task.Delay(2000);

        Console.WriteLine($"Log written: {message}");
    }
}