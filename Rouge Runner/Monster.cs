using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Runner
{
    public class Monster
    {
        public string Name = "M";
        public int Id;
        public int Health;

        public Monster()
        {
            Health = 100;
            Id = 00;
        }
            
        public string GetName()
        {
            return Name;
        }

        public int GetId()
        {
            return Id;
        }

        public void setHealth(int health)
        {
            Health = health;
        }

        public int getHealth()
        {
            return Health;
        }

    }
}
