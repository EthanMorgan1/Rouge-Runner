using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Runner
{
    public class Utility
    {
        public Utility()
        {

        }

        /// <summary>
        /// Creates the player's name that they want
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string SetPlayerName(string name)
        {
            
            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Must have a name! Please try putting your name again!");
                name = Console.ReadLine();
            }
          
            return name;
        }


       public void Combat(Player player, Monster monster)
       {
            int playerHp = player.GetHealth();
            int MonsterHp = monster.getHealth();

            Random random = new Random();

            if(random.Next(1,8) <= 6)
            {
                monster.setHealth(MonsterHp - 15);
                Console.WriteLine("Monster Hit");
            }
            else
            {
                player.SetHealth(playerHp - 15);
                Console.WriteLine("Player Hit");
            }
       }
    }
}
