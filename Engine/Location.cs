using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; } // Property to hold the location's ID
        public string Name { get; set; } // Property to hold the location's name
        public string Description { get; set; } // Property to hold the location's description
        public Item ItemRequiredToEnter { get; set; } // Property to hold the item required to enter the location
        public Quest QuestAvailableHere { get; set; } // Property to hold the quest available at the location
        public Monster MonsterLivingHere { get; set; } // Property to hold the monster living at the location
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, string name,string description,Item itemRequiredToEnter=null ,Quest questAvailableHere=null, Monster monsterLivingHere=null) 
        { 
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
