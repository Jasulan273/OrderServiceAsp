using MassTransit;
using DeliveryService.Models;
using DeliveryService.Data;
using DeliveryService.Events;
namespace DeliveryService.Consumers
{
public class OrderCreatedConsumer : IConsumer<OrderCreatedEvent>
{
    private readonly DeliveryContext _context;

    public OrderCreatedConsumer(DeliveryContext context)
    {
        _context = context;
    }

    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        var newDelivery = new DeliveryRequest
        {
            OrderId = context.Message.OrderId,
            Address = "Default Address",
            RequestDate = DateTime.Now
        };
        _context.DeliveryRequests.Add(newDelivery);
        await _context.SaveChangesAsync();
    }
}
}