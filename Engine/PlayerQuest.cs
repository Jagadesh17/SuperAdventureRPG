using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; } // Property to hold the details of the quest
        public bool IsCompleted { get; set; } // Property to indicate if the quest is completed
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
