﻿public class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>() { "BlackBerry", "Cantalope", "HoneyMelon" };

        fruits.Add("Orange");

        fruits.Remove("HoneyMelon");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
        {
            { 1, "BlackBerry" },
            { 2, "Cantalope" },
            { 3, "Dragon Fruit" }
        };

        
        fruitDictionary.Add(4, "Cranberry");

       
        Console.WriteLine("\nFruit Dictionary:");
        foreach (var item in fruitDictionary)
        {
            Console.WriteLine("ID: " + item.Key + " Fruit: " + item.Value);
        }
    }
}