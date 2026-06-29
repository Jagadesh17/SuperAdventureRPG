using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; } // Property to hold the quest's ID
        public string Name { get; set; } // Property to hold the quest's name
        public string Description { get; set; } // Property to hold the quest's description
        public int RewardExperiencePoints { get; set; } // Property to hold the amount of experience points rewarded for completing the quest
        public int RewardGold { get; set; } // Property to hold the amount of gold rewarded for completing the quest
        public Item RewardItem { get; set; } // Property to hold the item rewarded for completing the quest
        public List<QuestCompletionItem> QuestCompletionItems { get; set; } // Property to hold the list of items required to complete the quest

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>(); // Initialize the list of quest completion items to an empty list
        }
    }
}
