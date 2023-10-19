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
         new City("PARIS"),
         new City("CALIFORNIA"),
        
        new City("LONDON"),
        new City("NEW DELHI"),
        new City("ZURICH"),
        new City("NAIROBI")
    };

    public static void Main(string[] args)
    {
        AddQueries();
    }
    public static void AddQueries()
    {
        // Write a program in C# to display the list of items in the array 
        // according to the length of the string then by name in ascending order.
        var item1 = from s in cities
                     orderby s.CityName.Length
                     select s;
                     
        foreach (var i1 in item1)
        {
            System.Console.WriteLine(i1.CityName);
        }
        
    }
}