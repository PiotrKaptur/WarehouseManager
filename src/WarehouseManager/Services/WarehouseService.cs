
class WarehouseService
{
    public List<Product> Products {get; set;}

    public WarehouseService()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public Product? FindProductByName(string name)
    {
        return Products.FirstOrDefault(p => p.Name == name);
    }

    public bool RemoveProduct(string name)
    {
        Product? foundProduct = FindProductByName(name);

        if(foundProduct != null)
        {
            Products.Remove(foundProduct);
            return true;
        }
        else
        {
            return false;
        }
    }
}