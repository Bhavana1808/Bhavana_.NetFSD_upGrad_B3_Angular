using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
        Trace.AutoFlush = true;

        Trace.WriteLine("Order Validation Started");
        Trace.WriteLine("Order Validated");

        Trace.TraceInformation("Processing Payment");
        Trace.TraceInformation("Payment Successful");

        Trace.WriteLine("Updating Inventory");
        Trace.WriteLine("Inventory Updated");

        Trace.WriteLine("Generating Invoice");
        Trace.WriteLine("Invoice Generated");

        Console.WriteLine("Order Process Completed. Check log.txt");
    }
}