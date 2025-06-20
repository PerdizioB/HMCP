using HandMadeCakes.Data;
using HandMadeCakes.Models;
using HandMadeCakes.Services.Cart;
using HandMadeCakes.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace HandMadeCakes.Services.Checkout
{
    public class CheckoutService : ICheckoutService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICartService _cartService;

        public CheckoutService(IOrderRepository orderRepository, ICartService cartService)
        {
            _orderRepository = orderRepository;
            _cartService = cartService;
        }

        public async Task<bool> ProcessOrderAsync(CheckoutViewModel checkout)
        {
            var cartItems = _cartService.GetCartItems();

            if (cartItems == null || !cartItems.Any())
                return false; // Carrinho vazio

            var order = new Order
            {
                CustomerName = checkout.Name,
                CustomerEmail = checkout.Email,
                ShippingAddress = checkout.Address,
                OrderDate = System.DateTime.Now,
                Items = cartItems.Select(ci => new OrderItem
                {
                    ProductId = ci.CakeId,
                    Quantity = ci.Quantity,
                    UnitPrice = ci.Price
                }).ToList(),
                TotalAmount = cartItems.Sum(ci => ci.Price * ci.Quantity)
            };

            await _orderRepository.SaveOrderAsync(order);
            _cartService.ClearCart();

            return true;
        }
    }
}