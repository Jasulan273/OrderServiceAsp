namespace DeliveryService.Models
{
    public class DeliveryRequest
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Address { get; set; } = string.Empty;
        public DateTime RequestDate { get; set; }
    }
}
