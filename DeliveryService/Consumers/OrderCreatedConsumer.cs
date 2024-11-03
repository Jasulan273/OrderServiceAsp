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
            try
            {
                Console.WriteLine($"Получено событие: OrderId = {context.Message.OrderId}");

                var newDelivery = new DeliveryRequest
                {
                    OrderId = context.Message.OrderId,
                    Address = "Default Address",
                    RequestDate = DateTime.Now
                };

                _context.DeliveryRequests.Add(newDelivery);
                await _context.SaveChangesAsync();
                Console.WriteLine("Запись успешно добавлена в базу данных.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке события: {ex.Message}");
            }
        }
    }
}
