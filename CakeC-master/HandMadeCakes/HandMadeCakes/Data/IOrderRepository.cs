using HandMadeCakes.Models;

namespace HandMadeCakes.Data
{
    public interface IOrderRepository
    {
        Task SaveOrderAsync(Order order);

    }
}
