using System;
using System.Linq;
using System.Collections.Generic;
namespace Question1;
class Program
{
    public static List<City> cities = new List<City>(){
        new City("ABU DHABI"),
        new City("AMSTERDAM"),
        new City("ROME"),
       
        new City("MADURAI"),
        new City("LONDON"),
        new City("NEW DELHI"),
        new City("MUMBAI"),
        new City("NAIROBI")
    };

    public static void Main(string[] args)
    {
        AddQueries();
    }
    public static void AddQueries()
    {
        // Input starting character for the string: M
        System.Console.WriteLine("Input starting character");
        string starting = Console.ReadLine().ToUpper();
        // Input ending character for the string: I
        System.Console.WriteLine("Input ending character");
        string ending = Console.ReadLine().ToUpper();

        var item = from s in cities
                   where s.CityName.StartsWith(starting) &&
                   s.CityName.EndsWith(ending)
                   select s;
        
                     
        foreach (var i1 in item)
        {
            System.Console.WriteLine(i1.CityName);
        }
        
    }
}