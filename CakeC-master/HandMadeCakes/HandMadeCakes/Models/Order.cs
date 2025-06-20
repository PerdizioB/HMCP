namespace HandMadeCakes.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? ShippingAddress { get; set; }
        public double TotalAmount { get; set; }

        public List<OrderItem>? Items { get; set; }
    }
}