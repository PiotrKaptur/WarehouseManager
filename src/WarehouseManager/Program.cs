
class Project
{


    public static void ProductDisplay(List<Product> products)
    {
        foreach(Product item in products)
        {
             Console.WriteLine($"{item.Id}. - {item.Name} - {item.Price} zł - ilość: {item.Quantity} - kategoria: {item.Category}");
        }
    }
    static void Main()
    {
        WarehouseService warehouseService = new WarehouseService();
        Product product = new Product(1, "Wkrętarka", 500, 34, ProductCategory.NarzędziaPomiaroweIKontrolne);
        warehouseService.AddProduct(product);
        Product product1 = new Product(2, "Wiertarka", 700, 2, ProductCategory.NarzędziaElektryczneIAkumulatorowe);
        warehouseService.AddProduct(product1);
        Product product2 = new Product(3, "Odkurzacz", 640, 5, ProductCategory.NarzędziaElektryczneIAkumulatorowe);
        warehouseService.AddProduct(product2);

        ProductDisplay(warehouseService.Products);


        Console.WriteLine("Test FindProductByName");
        Product? foundProduct = warehouseService.FindProductByName("Telewizor");
        if(foundProduct != null)
        {
            Console.WriteLine(foundProduct.Name);
        }
        else
        {
            Console.WriteLine("Nie znaleziono produktu");
        }


        Console.WriteLine("Test RemoveProduct");
        bool result = warehouseService.RemoveProduct("Odkurzacz");
        Console.WriteLine(result);
        ProductDisplay(warehouseService.Products);


        Console.WriteLine("Test IncreaseQuantity");
        bool effect = warehouseService.IncreaseQuantity(2, 10);
        Console.WriteLine(effect);
        ProductDisplay(warehouseService.Products);


        Console.WriteLine("Test ReduceQuantity");
        bool effect1 = warehouseService.ReduceQuantity(2, 1);
        Console.WriteLine(effect1);
        ProductDisplay(warehouseService.Products);


        Console.WriteLine("Test ReduceQuantity too many");
        bool effect2 = warehouseService.ReduceQuantity(2, 100);
        Console.WriteLine(effect2);
        ProductDisplay(warehouseService.Products);


        Console.WriteLine("Test ReduceQuantity non-existent");
        bool effect3 = warehouseService.ReduceQuantity(5, 1);
        Console.WriteLine(effect3);
        ProductDisplay(warehouseService.Products);


        Console.WriteLine("Test AccessibleProducts");
        List<Product> accessibleProducts = warehouseService.AccessibleProducts();
        ProductDisplay(accessibleProducts);


        Console.WriteLine("Test SearchByCategory");
        List<Product> searchByCategory = warehouseService.SearchByCategory(ProductCategory.NarzędziaElektryczneIAkumulatorowe);
        ProductDisplay(searchByCategory);


        Console.WriteLine("Test LowStockProducts");
        List<Product> lowStockProducts = warehouseService.LowStockProducts(5);
        ProductDisplay(lowStockProducts);


        Console.WriteLine("Test AlphabeticalSorting");
        List<Product> alphabeticalSorting = warehouseService.AlphabeticalSorting();
        ProductDisplay(alphabeticalSorting);
        

        Console.WriteLine("Test SortingByPrice");
        List<Product> sortingByPrice = warehouseService.SortingByPrice();
        ProductDisplay(sortingByPrice);


        Console.WriteLine("Test SortingByQuantity");
        List<Product> sortingByQuantity = warehouseService.SortingByQuantity();
        ProductDisplay(sortingByQuantity);


        Console.WriteLine("Test GetTotalQuantity");
        int result1 = warehouseService.GetTotalQuantity();
        Console.WriteLine($"Get Total Quantity: {result1}");
    }
}
