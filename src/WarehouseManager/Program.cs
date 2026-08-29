
class Project
{
    static void Main()
    {
        WarehouseService warehouseService = new WarehouseService();
        Product product = new Product(1, "Wiertarka", 500, 3, ProductCategory.NarzędziaElektryczneIAkumulatorowe );
        warehouseService.AddProduct(product);
        Product product1 = new Product(2, "Wkrętarka", 700, 2, ProductCategory.NarzędziaElektryczneIAkumulatorowe);
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
    }
}
