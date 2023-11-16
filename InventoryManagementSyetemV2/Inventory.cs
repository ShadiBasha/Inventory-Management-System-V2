namespace InventoryManagementSyetemV2;

public class Inventory
{
    private List<Product> _storage;

    public Inventory()
    {
        _storage = new List<Product>();
    }
    
    public Inventory(List<Product> storage)
    {
        _storage = storage;
    }
    
    public void AddItem(Product? item)
    {
        if (item == null)
        {
            throw new Exception("Error: the item your trying to add is null");
        }
        else
        {
            _storage.Add(item);
        }
    }
    
    public Product? GetItemByName(string name)
    {
        foreach (Product item in _storage)
        {
            if (item.Name.Equals(name))
            {
                return item;
            }
        }
        return null;
    }
    
    public string ViewAllItems()
    {
        var allItems = "";
        foreach (var item in _storage)
        {
            allItems += item + "\n";
        }
        return allItems;
    }
    
}