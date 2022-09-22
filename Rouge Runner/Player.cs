using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Runner
{
    public class Player
    {
        public static string Name = "   ";

        public static int Health;

        public int Damage;

        public List<int> inventory = new List<int>();

        public Player()
        {
            Name = "Player";
            Health = 100;
            Damage = 10;
        }

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Damage = 10;
        }

        public void SetName(string name)
        {
            Player.Name = name;
        }

        public string GetName()
        {
            return Player.Name;
        }

        public int GetHealth()
        {
            return Health;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        public void SetDamage(int damage)
        {
            Damage = damage;
        }

        public int GetDamage()
        {
            return Damage;
        }

        public override string ToString()
        {
            string returnString = " ";

            returnString += "===== " + Player.Name + " =====\n";
            returnString += " HP = " + Player.Health + "\n";
            

            return returnString;
        }
    }
}
