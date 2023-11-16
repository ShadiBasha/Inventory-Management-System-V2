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
    
    static Product? GetProductByName()
    {
        Console.WriteLine("Please enter the name of the product");
        Console.ReadLine();
        string name = new string(Console.ReadLine());
        Product? product = Inventory.GetItemByName(name);
        if (product == null)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Sorry there is no product with such name");
            Console.WriteLine("----------------------------------------");
            MainPage();
            return null;
        }
        return product;
    }
    public static void EditAProduct()
    {
        Product? productToEdit = GetProductByName();
        if (productToEdit == null)
        {
            return;
        }
        Console.WriteLine("This is the product");
        Console.WriteLine(productToEdit.ToString());
        Console.WriteLine("What do you want to change?");
        Console.WriteLine("1. The Name");
        Console.WriteLine("2. The Price");
        Console.WriteLine("3. The Quantity");
        Console.WriteLine("4. Delete a product");
        Console.WriteLine("Enter the number to continue");
        Console.WriteLine("Enter anything else to exit");
        int comand = Convert.ToInt32(Console.ReadLine());
        switch (comand)
        {
            case 1:
                Console.WriteLine("Enter the new Name for the product");
                string newName = new string(Console.ReadLine());
                productToEdit.Name = newName;
                break;
            case 2:
                Console.WriteLine("Enter the new Price for the product");
                int price = Convert.ToInt32(Console.ReadLine());
                productToEdit.Price = price;
                break;
            case 3:
                Console.WriteLine("Enter the new Quantity for the product");
                int quantity = Convert.ToInt32(Console.ReadLine());
                productToEdit.Quantity = quantity;
                break;
        }
        MainPage();
    }
    static void DeleteAProduct()
    {
        Product? productToDelete = GetProductByName();
        if (productToDelete == null)
        {
            return;
        }
        Inventory.DeleteItem(productToDelete);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(productToDelete.ToString());
        Console.WriteLine("        Was deleted successfully");
        Console.WriteLine("----------------------------------------");
        MainPage();
    }
    static void SearchForAProduct()
    {
        Product? searchedForProduct = GetProductByName();
        if (searchedForProduct == null)
        {
            return;
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(searchedForProduct.ToString());
        Console.WriteLine("----------------------------------------");
        MainPage();
    }
    public static void MainPage()
    {
        Console.WriteLine("Welcome to Your Inventory");
        Console.WriteLine("What do you want to do: ");
        Console.WriteLine("1. Add a product");
        Console.WriteLine("2. View all product");
        Console.WriteLine("3. Edit a product");
        Console.WriteLine("4. Delete a product");
        Console.WriteLine("5. Search for a product");
        Console.WriteLine("Write down the number of");
        Console.WriteLine("the command you want to do");
        Console.WriteLine("press anything else to exit");
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
            case '3': 
                EditAProduct();
                break;
            case '4':
                DeleteAProduct();
                break;
            case '5':
                SearchForAProduct();
                break;
            default : Environment.Exit(0);
                break;
        }
    }

    public static int Main()
    {
        MainPage();
        return 0;
    }
}