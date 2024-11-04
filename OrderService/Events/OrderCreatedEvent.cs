namespace OrderService.Events
{
    public class OrderCreatedEvent
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow; 
    }
}
