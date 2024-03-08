public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
       // Initialize the properties with the values passed to the constructor
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"{ItemName} price updated to: {Price:C}");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"{additionalQuantity} {ItemName}(s) added to stock. Total quantity: {QuantityInStock}");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        QuantityInStock -= quantitySold;
        Console.WriteLine($"{quantitySold} {ItemName}(s) sold. Remaining quantity: {QuantityInStock}");
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);


        // Print initial details of all items
        Console.WriteLine("The first information:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell some items and then print the updated details
        item1.SellItem(3);
        item2.SellItem(5);

        Console.WriteLine("specifics following the sale:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Restock an item and print the updated details
        item1.RestockItem(5);

        Console.WriteLine("Details following restocking:");
        item1.PrintDetails();

        // Check if an item is in stock and print a message accordingly
        Console.WriteLine($"Is {item2.ItemName} in stock? {item2.IsInStock()}");

        // Update price and print updated details
        item2.UpdatePrice(900.75);

        Console.WriteLine("information after updating price:");
        item2.PrintDetails();


    }
}