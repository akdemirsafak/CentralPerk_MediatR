namespace CentralPerk.API.Models;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; } //bit in database
}