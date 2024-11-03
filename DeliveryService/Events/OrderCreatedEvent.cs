namespace DeliveryService.Events
{
    public class OrderCreatedEvent
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}