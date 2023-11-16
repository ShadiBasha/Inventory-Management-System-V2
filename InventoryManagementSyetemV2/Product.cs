using System.Data.SqlTypes;

namespace InventoryManagementSyetemV2;

public class Product
{
    private static int _numberOfProducts;
    private int _productNumber;
    private int _price;
    private int _quantity;
    
    public string Name { get; set; }
    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0)
                _quantity = 0;
            else
                _quantity = value;
        }
    }
    
    public int Price
    {
        get => _price;
        set
        {
            if (value < 0)
                _price = 0;
            else
                _price = value;
        }
    }
    
    
    public Product()
    {
        _productNumber = -1;
        Name = "";
        Price = 0;
        Quantity = 0;
    } 
    public Product(string name, int price, int quantity)
    {
        _productNumber = _numberOfProducts;
        Name = name;
        Price = price;
        Quantity = quantity;
        _numberOfProducts++;
    }

    public override string ToString()
    {
        return $"{_productNumber} : Name : {Name}, Price : {Price}, Quantity: {Quantity}";
    }
}