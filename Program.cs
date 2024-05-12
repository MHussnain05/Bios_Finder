using System;
using System.Management;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;


class Program
{
    [SupportedOSPlatform("windows")] // Suppress the warning CA1416 for Windows-only code.
    static void Main()
    {
        // Check if the operating system is Windows.
        if (OperatingSystem.IsWindows())
        {
            // Call the function to retrieve BIOS information.
            RetrieveBIOSInfo();
        }
        else
        {
            // Inform the user that the application is not supported on their platform.
            Console.WriteLine("This application only supports Windows.");
        }
        
        // Keep the console window open.
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to retrieve BIOS information.
    static void RetrieveBIOSInfo()
    {
        // Create a ManagementObjectSearcher to query BIOS information.
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");

        // Iterate through the results and print BIOS information.
        foreach (ManagementObject obj in searcher.Get())
        {
            Console.WriteLine($"BIOS Serial Number: {obj["SerialNumber"]}");
            Console.WriteLine($"BIOS Version: {obj["Version"]}");
        }
    }
}
