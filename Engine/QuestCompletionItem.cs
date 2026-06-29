using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class QuestCompletionItem
    {
        public Item Details { get; set; } // Property to hold the details of the item
        public int Quantity { get; set; } // Property to hold the quantity of the item
        public QuestCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
