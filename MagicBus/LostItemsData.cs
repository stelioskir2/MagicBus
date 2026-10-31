using System;
using System.Collections.Generic;

namespace MagicBus
{
    public class FoundItem
    {
        public string Name { get; set; } = "";
        public string Floor { get; set; } = "";
        public DateTime FoundAt { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"{Name} — {Floor}";
        }
    }

    public static class LostItemsData
    {
        public static List<FoundItem> Items { get; } = new();
    }
}