
class Project
{
    static void Main()
    {
        WarehouseService warehouseService = new WarehouseService();
        Product product = new Product(1, "Wkrętarka", 500, 0, ProductCategory.NarzędziaPomiaroweIKontrolne);
        warehouseService.AddProduct(product);
        Product product1 = new Product(2, "Wiertarka", 700, 2, ProductCategory.NarzędziaElektryczneIAkumulatorowe);
        warehouseService.AddProduct(product1);
        Product product2 = new Product(3, "Odkurzacz", 640, 5, ProductCategory.NarzędziaElektryczneIAkumulatorowe);
        warehouseService.AddProduct(product2);


        foreach(Product item in warehouseService.Products)
        {
            Console.WriteLine($"{item.Id}. - {item.Name} - {item.Price} zł - ilość: {item.Quantity} - kategoria: {item.Category}");
        }



        Product? foundProduct = warehouseService.FindProductByName("Telewizor");

        if(foundProduct != null)
        {
            Console.WriteLine(foundProduct.Name);
        }
        else
        {
            Console.WriteLine("Nie znaleziono produktu");
        }



        bool result = warehouseService.RemoveProduct("Odkurzacz");
        Console.WriteLine(result);



        foreach(Product item in warehouseService.Products)
        {
             Console.WriteLine($"{item.Id}. - {item.Name} - {item.Price} zł - ilość: {item.Quantity} - kategoria: {item.Category}");
        }


        bool effect = warehouseService.IncreaseQuantity(3, 10);
        Console.WriteLine(effect);


        foreach(Product item in warehouseService.Products)
        {
             Console.WriteLine($"{item.Id}. - {item.Name} - {item.Price} zł - ilość: {item.Quantity} - kategoria: {item.Category}");
        }



        bool effect1 = warehouseService.ReduceQuantity(2, 1);
        Console.WriteLine(effect1);

        foreach(Product item in warehouseService.Products)
        {
             Console.WriteLine($"{item.Id}. - {item.Name} - {item.Price} zł - ilość: {item.Quantity} - kategoria: {item.Category}");
        }

        bool effect2 = warehouseService.ReduceQuantity(2, 35);
        Console.WriteLine(effect2);

        foreach(Product item in warehouseService.Products)
        {
             Console.WriteLine($"{item.Id}. - {item.Name} - {item.Price} zł - ilość: {item.Quantity} - kategoria: {item.Category}");
        }

        bool effect3 = warehouseService.ReduceQuantity(4, 5);
        Console.WriteLine(effect3);

        foreach(Product item in warehouseService.Products)
        {
             Console.WriteLine($"{item.Id}. - {item.Name} - {item.Price} zł - ilość: {item.Quantity} - kategoria: {item.Category}");
        }



        Console.WriteLine("Test");
        List<Product> accessibleProducts = warehouseService.AccessibleProducts();
        foreach(Product product3 in accessibleProducts)
        {
            Console.WriteLine($"{product3.Id}. - {product3.Name} - {product3.Price} zł - ilość: {product3.Quantity} - kategoria: {product3.Category}");
        }

        Console.WriteLine("Test1");
        List<Product> searchByCategory = warehouseService.SearchByCategory(ProductCategory.NarzędziaElektryczneIAkumulatorowe);
        foreach(Product product4 in searchByCategory)
        {
            Console.WriteLine($"{product4.Id}. - {product4.Name} - {product4.Price} zł - ilość: {product4.Quantity} - kategoria: {product4.Category}");
        }


        Console.WriteLine("Test2");
        List<Product> lowStockProducts = warehouseService.LowStockProducts(5);
        foreach(Product product5 in lowStockProducts)
        {
            Console.WriteLine($"{product5.Id}. - {product5.Name} - {product5.Price} zł - ilość: {product5.Quantity} - kategoria: {product5.Category}");
        }

        Console.WriteLine("Test3");
        List<Product> alphabeticalSorting = warehouseService.AlphabeticalSorting();
        foreach(Product product6 in alphabeticalSorting)
        {
            Console.WriteLine($"{product6.Id}. - {product6.Name} - {product6.Price} zł - ilość: {product6.Quantity} - kategoria: {product6.Category}");
        }

        Console.WriteLine("Test4");
        List<Product> sortingByPrice = warehouseService.SortingByPrice();
        foreach(Product product7 in sortingByPrice)
        {
            Console.WriteLine($"{product7.Id}. - {product7.Name} - {product7.Price} zł - ilość: {product7.Quantity} - kategoria: {product7.Category}");
        }
    }
}
