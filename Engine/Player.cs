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

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level): base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }
    }
}
