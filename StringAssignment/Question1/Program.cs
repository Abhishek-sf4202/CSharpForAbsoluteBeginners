using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string str1 = "";
        str1 = Console.ReadLine();
        System.Console.WriteLine("Display the odd number of characters from above string");
        for (int i = 0; i < str1.Length; i++)
        {
            if (i % 2 != 0)
            {
                System.Console.Write(str1[i]);
            }

        }
        System.Console.WriteLine("\n Replace the character n with capital N");
        str1 = str1.Replace('n', 'N');
        System.Console.WriteLine(str1);

        System.Console.WriteLine("Display the above string in reverse");
        for (int i = str1.Length - 1; i >= 0; i--)
        {

            System.Console.Write(str1[i]);


        }
        System.Console.WriteLine("\n Length of above string");
        System.Console.WriteLine($"{str1.Length}");

        // Get the two string from user and concatenate the first 4 characters of first string and last 3 characters of second string

        //         Input:
        // First String: Computer
        System.Console.WriteLine("Enter the string 1");
        string str2 = Console.ReadLine();

        System.Console.WriteLine("Enter the string2");
        string str3 = Console.ReadLine();



        // Second String: Science

        // Output: Compnce
        System.Console.Write(str2.Substring(0, 4));
        System.Console.Write(str3.Substring(str3.Length - 4, 3));


        // 6.Print the words by splitting with comma and print in separate line
        System.Console.WriteLine("\n Print the words by splitting with comma and print in separate line");
        // Input: Chennai,Trichy,Mumbai
        string str4 = "Chennai,Trichy,Mumbai";
        string[] str5 = str4.Split(',');
        foreach (string item in str5)
        {
            System.Console.WriteLine(item);
        }
        // Output:

        // Chennai
        // Trichy
        // Mumbai

    }
}