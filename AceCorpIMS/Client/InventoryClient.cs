using AceCorpIMS.Client.Models;

namespace AceCorpIMS.Client;

public static class InventoryClient
{
    private static readonly List<Inventory> inventories = new()
    {
        new Inventory()
        {
            InventoryId = 1,
            InventoryName = "Office Desk",
            Quantity = 20,
            Price = 74.99M,
            DateReceived = new DateTime(2023, 10, 1)


        },
         new Inventory()
        {
            InventoryId = 2,
            InventoryName = "Office Chair",
            Quantity = 20,
            Price = 49.99M,
            DateReceived = new DateTime(2023, 10, 1)


        },
         new Inventory()
        {
            InventoryId = 3,
            InventoryName = "Office Computer",
            Quantity = 20,
            Price = 299.99M,
            DateReceived = new DateTime(2023, 10, 1)


        },
         new Inventory()
        {
            InventoryId = 4,
            InventoryName = "Copier",
            Quantity = 2,
            Price = 199.99M,
            DateReceived = new DateTime(2023, 10, 1)


        }

    };

    public static Inventory[] GetInventories()
    {
        return inventories.ToArray();
    }

    public static void AddInventory(Inventory inventory)
    {
        inventory.InventoryId = inventories.Max(inventory => inventory.InventoryId) + 1;
        inventories.Add(inventory);
    }

    public static Inventory GetInventory(int InventoryId)
    {
        return inventories.Find(inventory => inventory.InventoryId == InventoryId) ?? throw new Exception("Could not find item!");
    }

    public static void UpdateInventory(Inventory updatedInventory)
    {
        Inventory existingInventory = GetInventory(updatedInventory.InventoryId);
        existingInventory.InventoryName = updatedInventory.InventoryName;
        existingInventory.Quantity = updatedInventory.Quantity;
        existingInventory.Price = updatedInventory.Price;
        existingInventory.DateReceived= updatedInventory.DateReceived;
    }

    public static void DeleteInventory(int IventoryId)
    {
        Inventory inventory = GetInventory(IventoryId);
        inventories.Remove(inventory);
    }

}
