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
    
    public bool AddAnItem(Product item)
    {
        if (item.IsNull)
            return false;
        _storage.Add(item);
        return true;
    }
    
}