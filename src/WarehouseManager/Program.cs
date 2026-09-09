
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
        ConsoleMenu consoleMenu = new ConsoleMenu(warehouseService);

        consoleMenu.Menu();
    }
}
