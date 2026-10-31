using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicBus
{
    public static class CafeOrder
    {
        public static string? Cafe { get; private set; }
        public static List<CartItem> Items { get; } = new();
        public static int? OrderNumber { get; set; }

        public static decimal Total => Items.Sum(i => i.Price * i.Quantity);

        public static void Start(string cafe)
        {
            Cafe = cafe;
            Items.Clear();
            OrderNumber = null;
        }

        public static void Add(string name, decimal price, int quantity)
        {
            CartItem? existing = Items.FirstOrDefault(i => i.Name == name);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem(name, price, quantity));
            }
        }
    }

    public class CartItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; set; }

        public CartItem(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Quantity} x {Name} — {Price * Quantity:0.00} €";
        }
    }

    public class CafeProduct
    {
        public string Name { get; }
        public decimal Price { get; }

        public CafeProduct(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} — {Price:0.00} €";
        }
    }
}
