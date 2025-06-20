using HandMadeCakes.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

    namespace HandMadeCakes.Data
    {
        public class OrderRepository : IOrderRepository
        {
            private readonly AppDbContext _context;

            public OrderRepository(AppDbContext context)
            {
                _context = context;
            }

            public async Task SaveOrderAsync(Order order)
            {
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
            }
        }
    }