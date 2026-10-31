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
        public static List<PlacedOrder> Orders { get; } = new();

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

        public static int PlaceOrder()
        {
            PlacedOrder order = new PlacedOrder
            {
                Number = Random.Shared.Next(1000, 10000),
                Cafe = Cafe ?? "",
                Items = Items.Select(i => new CartItem(i.Name, i.Price, i.Quantity)).ToList(),
                Total = Total,
                Time = DateTime.Now
            };
            Orders.Add(order);
            OrderNumber = order.Number;
            return order.Number;
        }
    }

    public class PlacedOrder
    {
        public const string StatusNew = "Νέα";
        public const string StatusPreparing = "Σε προετοιμασία";
        public const string StatusReady = "Καθ' οδόν προς τη στάση";
        public const string StatusDelivered = "Παραδόθηκε";

        public int Number { get; set; }
        public string Cafe { get; set; } = "";
        public List<CartItem> Items { get; set; } = new();
        public decimal Total { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; } = StatusNew;
        public string? DeliveryStop { get; set; }

        public string Details()
        {
            string text = $"Παραγγελία #{Number} ({Time:HH:mm})\r\n"
                + $"Καφετέρια: {Cafe}\r\n\r\n";
            foreach (CartItem item in Items)
            {
                text += item + "\r\n";
            }
            text += $"\r\nΣύνολο: {Total:0.00} €";
            return text;
        }

        public override string ToString()
        {
            return $"#{Number} — {Time:HH:mm} — {Cafe}";
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
