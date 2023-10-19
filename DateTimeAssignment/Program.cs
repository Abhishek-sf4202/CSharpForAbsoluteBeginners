using System;
namespace Date;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        //         Write a C# program to perform below operation.

        // Print the current month of the day
        System.Console.WriteLine(date);
        // Print the previous of 3 day from current date
        System.Console.WriteLine(date.AddDays(-3));
        // Print the 12 hours’ time of now followed by am , pm
        System.Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        System.Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm:ss tt"));
        
        

    }
}