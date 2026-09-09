class ConsoleMenu
{
    WarehouseService _warehouseService {get; set;}
    public ConsoleMenu(WarehouseService warehouseService)
    {
         _warehouseService = warehouseService;
    }
    public void Menu()
    {
        string? choice;
        do
        {
            Console.WriteLine("---MENU MAGAZYNU---");
            Console.WriteLine("1. WYŚWIETL PRODUKTY");
            Console.WriteLine("2. DODAJ PRODUKT");
            Console.WriteLine("3. PRZYJMIJ TOWAR");
            Console.WriteLine("4. WYDAJ TOWAR");
            Console.WriteLine("0. ZAKOŃCZ PROGRAM");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Project.ProductDisplay(_warehouseService.Products);
                        break;
                    }
                case "2":
                    {
                        ProductCategory selectedCategory = ProductCategory.NarzędziaRęczne;
                        Console.WriteLine("Dodawanie produktu");
                        Console.WriteLine("ID:");
                        if(int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("Poprawne ID");
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowe ID");
                            break;
                        }
                        Console.WriteLine("Nazwa:");
                        string? name = Console.ReadLine();
                        if(string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Nieprawidłowa nazwa");
                            break;
                        }
                        Console.WriteLine("Cena:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal price))
                        {
                            Console.WriteLine("Poprawne price");
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna price");
                            break;
                        }
                        Console.WriteLine("Ilość:");
                        if(int.TryParse(Console.ReadLine(), out int quantity))
                        {
                            Console.WriteLine("Poprawne quantity");
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawne quantity");
                            break;
                        }
                        Console.WriteLine("Wybierz kategorie:");
                        Console.WriteLine("1. Narzędzia ręczne");
                        Console.WriteLine("2. Narzędzia elektryczne i akumulatorowe");
                        Console.WriteLine("3. Narzędzia pomiarowe i kontrolne");
                        Console.WriteLine("4. Wyposarzenie pomocnicze i organizacja");
                        if(int.TryParse(Console.ReadLine(), out int category))
                        {
                            if(category <= 0 || category > 4)
                            {
                                Console.WriteLine("Niepoprawne category");
                                break;
                            }
                            Console.WriteLine("Prawidłowe category");
                            switch(category)
                            {
                                case 1:
                                    {
                                        selectedCategory = ProductCategory.NarzędziaRęczne;
                                        break;
                                    }
                                case 2:
                                    {
                                        selectedCategory = ProductCategory.NarzędziaElektryczneIAkumulatorowe;
                                        break;
                                    }
                                case 3:
                                    {
                                        selectedCategory = ProductCategory.NarzędziaPomiaroweIKontrolne;
                                        break;
                                    }
                                case 4:
                                    {
                                        selectedCategory = ProductCategory.WyposażeniePomocniczeIOrganizacja;
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawne category");
                            break;
                        }
                        Product product = new Product(id, name, price, quantity, selectedCategory);
                        bool result = _warehouseService.AddProduct(product);
                        Console.WriteLine(result ? "Produkt został dodany" : "Nie udało się dodać produktu");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Przyjmowanie towaru");
                        Project.ProductDisplay(_warehouseService.Products);
                        Console.WriteLine("Podaj ID produktu");
                        if(!int.TryParse(Console.ReadLine(), out int productId))
                        {
                            Console.WriteLine("Błędne dane");
                            break;
                        }
                        Console.WriteLine("Podaj ilość przyjmowanego towaru");
                        if(!int.TryParse(Console.ReadLine(), out int productQuantity))
                        {
                            Console.WriteLine("Błędne dane");
                            break;
                        }
                        bool result = _warehouseService.ReceiveProduct(productId, productQuantity);
                        Console.WriteLine(result? "Towar został dodany" : "Nie udało się dodać towaru");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Wybrano wydanie towaru");
                        break;
                    }
                case "0":
                    {
                        Console.WriteLine("Zakończenie programu");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nieprawidłowy wybór");
                        break;
                    }
            }
        }while(choice != "0");
    }
}