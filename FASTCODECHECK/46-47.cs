using System;
using System.Collections.Generic;
using System.Linq;

public class Storehouse
{
    public int WarehouseNumber { get; set; }
    public string ProductType { get; set; }
    public int Quantity { get; set; }

    public Storehouse(int warehouseNumber, string productType, int quantity)
    {
        WarehouseNumber = warehouseNumber;
        ProductType = productType;
        Quantity = quantity;
    }
}
public class Program
{
    private static List<Storehouse> storehouses = new List<Storehouse>();

    public static void Main(string[] args)
    {
        CreateAndFillDatabase();

        Console.Write("Введите вид продукции для поиска: ");
        string productTypeToSearch = Console.ReadLine();
        SearchProduct(productTypeToSearch);

        SortStorehouses();

        Console.Write("Введите необходимое количество продукции: ");
        int requiredQuantity = int.Parse(Console.ReadLine());
        CheckSufficientStock(productTypeToSearch, requiredQuantity);
    }

    private static void CreateAndFillDatabase()
    {
        storehouses.Add(new Storehouse(1, "Товар A", 100));
        storehouses.Add(new Storehouse(2, "Товар B", 200));
        storehouses.Add(new Storehouse(3, "Товар A", 150));
        storehouses.Add(new Storehouse(4, "Товар C", 50));
        storehouses.Add(new Storehouse(5, "Товар B", 300));

        Console.WriteLine("База данных успешно создана.");
    }
    private static void SearchProduct(string productType)
    {
        var foundProducts = storehouses.Where(s => s.ProductType.Equals(productType, StringComparison.OrdinalIgnoreCase)).ToList();

        if (foundProducts.Any())
        {
            Console.WriteLine($"Найденные склады для продукции '{productType}':");
            foreach (var storehouse in foundProducts)
            {
                Console.WriteLine($"Склад №{storehouse.WarehouseNumber}, Количество: {storehouse.Quantity}");
            }
        }
        else
        {
            Console.WriteLine($"Продукция '{productType}' не найдена на складах.");
        }
    }
    private static void SortStorehouses()
    {
        var sortedStorehouses = storehouses.OrderBy(s => s.WarehouseNumber).ToList();

        Console.WriteLine("Склады отсортированы по номеру:");
        foreach (var storehouse in sortedStorehouses)
        {
            Console.WriteLine($"Склад №{storehouse.WarehouseNumber}, Вид продукции: {storehouse.ProductType}, Количество: {storehouse.Quantity}");
        }
    }

    private static void CheckSufficientStock(string productType, int requiredQuantity)
    {
        var totalQuantity = storehouses.Where(s => s.ProductType.Equals(productType, StringComparison.OrdinalIgnoreCase))
                                       .Sum(s => s.Quantity);

        if (totalQuantity >= requiredQuantity)
        {
            Console.WriteLine($"Достаточно запасов для '{productType}'. Общая доступная сумма: {totalQuantity}");
        }
        else
        {
            Console.WriteLine($"Недостаточно запасов для '{productType}'. Не хватает: {requiredQuantity - totalQuantity}");
        }
    }
}

