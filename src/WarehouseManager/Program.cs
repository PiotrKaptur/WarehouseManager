
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
        Product product2 = new Product(3, "Odkurzacz", 650, 5, ProductCategory.NarzędziaElektryczneIAkumulatorowe);
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


        Console.WriteLine("Test GetTotalWarehouseValue");
        decimal result2 = warehouseService.GetTotalWarehouseValue();
        Console.WriteLine($"Get total warehouse value : {result2}");


        Console.WriteLine("Test TheMostExpensiveProduct");
        var result3 = warehouseService.TheMostExpensiveProduct();
        if(result3 == null)
        {
            Console.WriteLine("No products");
        }
        else
        {
            Console.WriteLine($"{result3.Id}. - {result3.Name} - {result3.Price} zł - ilość: {result3.Quantity} - kategoria: {result3.Category}");
        }


        Console.WriteLine("Test GetProductWithHighestQuantity");
        var result4 = warehouseService.GetProductWithHighestQuantity();
        if(result4 == null)
        {
            Console.WriteLine("No products");
        }
        else
        {
            Console.WriteLine($"{result4.Id}. - {result4.Name} - {result4.Price} zł - ilość: {result4.Quantity} - kategoria: {result4.Category}");
        }


        Console.WriteLine("Test GetProductCount");
        Console.WriteLine($"Product count : {warehouseService.GetProductCount()}");


        Console.WriteLine("Test ReceiveProduct");
        bool effect4 = warehouseService.ReceiveProduct(2, 10);
        Console.WriteLine(effect4);
        ProductDisplay(warehouseService.Products);

    }
}
