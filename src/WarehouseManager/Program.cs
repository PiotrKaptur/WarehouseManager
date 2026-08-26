
class Project
{
    static void Main()
    {
        WarehouseService warehouseService = new WarehouseService();
        Product product = new Product("Wiertarka", 500, 3);
        warehouseService.AddProduct(product);
        Product product1 = new Product("Wkrętarka", 700, 2);
        warehouseService.AddProduct(product1);
        Product product2 = new Product("Odkurzacz", 640, 5);
        warehouseService.AddProduct(product2);


        foreach(Product item in warehouseService.Products)
        {
            Console.WriteLine($"{item.Name} - {item.Price} zł - ilość: {item.Quantity}");
        }
    }
}
