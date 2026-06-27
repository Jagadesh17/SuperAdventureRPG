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

        public Location(int id, string name,string description) 
        { 
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
