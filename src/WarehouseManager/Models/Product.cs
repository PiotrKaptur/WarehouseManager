
class Product
{
    public int Id {get; set;}
    public string Name {get; set;}
    public decimal Price {get; set;}
    public int Quantity {get; set;}
    public ProductCategory Category {get; set;}

    public Product(int id, string name, decimal price, int quantity, ProductCategory category)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
        Category = category;
    }

    public decimal GetTotalPrice()
    {
        return Price * Quantity;
    }
}

