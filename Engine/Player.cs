using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }             // Property to hold the player's gold
        public int ExperiencePoints { get; set; } // Property to hold the player's experience points
        public int Level { get; set; }             // Property to hold the player's level
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level): base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;

            Inventory = new List<InventoryItem>(); //These two lines set the value of the new properties to empty lists. If we didn’t do this, the value for those properties would be “null” – nothing.
            Quests = new List<PlayerQuest>(); //By setting them to an empty list, we can add items to them later, because you can add objects to an empty list, but you can’t add object to nothing (null).
        }
    }
}
