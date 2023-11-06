﻿namespace InventoryManagementSyetemV2;

public class Program
{
    private static readonly Inventory Inventory = new();
    public static void AddAProduct()
    {
        Console.WriteLine("Fill the needed data");
        Console.WriteLine("Product name : ");
        Console.ReadLine();
        string name = new string(Console.ReadLine());
        Console.WriteLine("Product Price : ");
        int price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Product quantity : ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Product newProduct = new Product(name, price, quantity);
        if (Inventory.AddAnItem(newProduct))
        { 
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(newProduct.ToString());
            Console.WriteLine("         Was added successfully");
            Console.WriteLine("----------------------------------------");
        }
        else
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("         Error The Product is Null");
            Console.WriteLine("----------------------------------------");
        }

        MainPage();
    }
    
    public static void MainPage()
    {
        Console.WriteLine("Welcome to Your Inventory");
        Console.WriteLine("What do you want to do: ");
        Console.WriteLine("1. Add a product");
        int comand = Console.Read();
        Console.Clear();
        switch (comand)
        {
            case '1': 
                AddAProduct();
                break;
        }
    }

    public static int Main()
    {
        MainPage();
        return 0;
    }
}