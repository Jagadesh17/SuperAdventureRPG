using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; } // Property to hold the details of the item
        public int DropPercentage { get; set; } // Property to hold the drop percentage of the item
        public bool IsDefaultItem { get; set; } // Property to indicate if the item is a default item
        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}
