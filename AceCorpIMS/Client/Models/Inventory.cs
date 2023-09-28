

using System.ComponentModel.DataAnnotations;

namespace AceCorpIMS.Client.Models;

    // create the fields needed for the application
    public class Inventory
    {
    
    public int InventoryId { get; set; }

    [Required]
    [StringLength(50)]
    public required string InventoryName { get; set; }

    [Range(1, 100)]
    public int Quantity { get; set; }

    [Range(1, 2000)]
    public decimal Price { get; set; }

    [Required]
    public DateTime DateReceived { get; set; }
}
