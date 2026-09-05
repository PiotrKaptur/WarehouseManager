
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
    public  bool IncreaseQuantity(int id, int amount)
    {
        Product? foundProduct = Products.FirstOrDefault(p => p.Id == id);
       
       if(foundProduct != null)
        {
            foundProduct.Quantity = foundProduct.Quantity + amount;
            return true;
        }
        else
        {
            Console.WriteLine("Nie znaleziono produktu");
            return false;
        }
    }

    public  bool ReduceQuantity(int id, int amount)
    {
        Product? foundProduct = Products.FirstOrDefault(p => p.Id == id);
       
       if(foundProduct != null && foundProduct.Quantity >= amount)
        {
            foundProduct.Quantity = foundProduct.Quantity - amount;
            return true;
        }
        else if(foundProduct == null)
        {
            Console.WriteLine("Nie znaleziono produktu");
            return false;
        }
        else
        {
            Console.WriteLine("Niewystarczajaca ilość produktu");
            return false;
        }
    }

    public List<Product> AccessibleProducts()
    {
        return Products.Where(p => p.Quantity > 0).ToList();
    }

    public List<Product> SearchByCategory(ProductCategory category)
    {
        return Products.Where(p => p.Category == category).ToList();
    }

    public List<Product> LowStockProducts(int threshold)
    {
        return Products.Where(p => p.Quantity <= threshold).ToList();
    }

    public  List<Product> AlphabeticalSorting()
    {
        return Products.OrderBy(p => p.Name).ToList();
    }

    public List<Product> SortingByPrice()
    {
        return Products.OrderBy(p => p.Price).ToList();
    }

    public List<Product> SortingByQuantity()
    {
        return Products.OrderBy(p => p.Quantity).ToList();
    }
}