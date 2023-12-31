﻿﻿using System;

namespace Enemies
{
   /// <summary> public class Zombie </summary>
    class Zombie
    {
        private int health;
        private string name = "(No name)";
         /// <summary> public constructor: public Zombie() Initializes in 0 </summary>
        public Zombie()
        {
            health = 0;
        }
     /// <summary> public constructor with parameter: public Zombie(value) Initializes in 0 </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
          /// <summary> public property Name / get: retrieve name / set: set name </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
        /// <summary> public method public int GetHealth() that returns the value of health of the Zombie object </summary>
        public int GetHealth()
        {
            return health;
        }
         /// <summary> public method public int GetHealth() that returns the value of health of the Zombie object </summary>
        public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}",name,health);
        }

    }    
}