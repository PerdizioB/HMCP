﻿namespace HandMadeCakes.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }  // CakeId
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
