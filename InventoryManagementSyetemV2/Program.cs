namespace InventoryManagementSyetemV2;

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
        try
        {
            Inventory.AddItem(newProduct);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(newProduct.ToString());
            Console.WriteLine("         Was added successfully");
            Console.WriteLine("----------------------------------------");
        }
        catch (Exception e)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{e.Message}");
            Console.WriteLine("----------------------------------------");
        }
        MainPage();
    }
    
    public static void ViewProducts()
    {
        Console.WriteLine("-------------------------------------\n");
        Console.WriteLine("Products in the inventory");
        Console.WriteLine(Inventory.ViewAllItems());
        Console.WriteLine("-------------------------------------");
        Console.ReadLine();
        MainPage();
    }
    
    public static void MainPage()
    {
        Console.WriteLine("Welcome to Your Inventory");
        Console.WriteLine("What do you want to do: ");
        Console.WriteLine("1. Add a product");
        Console.WriteLine("2. View all product");
        int comand = Console.Read();
        Console.Clear();
        switch (comand)
        {
            case '1': 
                AddAProduct();
                break;
            case '2': 
                ViewProducts();
                break;
        }
    }

    public static int Main()
    {
        MainPage();
        return 0;
    }
}