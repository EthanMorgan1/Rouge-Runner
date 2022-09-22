using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Runner
{
    public class Items
    {
       public enum Weapons {
            One_Handed_Sword,
            Shield,
            Bow,
            PoleArm,
            Dagger,
            Two_Handed_Sword,
            One_Handed_Axe,
            Two_Handed_Axe,
            One_Handed_Mace,
            Two_Handed_Mace
        }

        public enum ArmorTypes {
            Cloth,
            Leather,
            Mail,
            Plate
        }

        public List<string> weapons_list = new List<string>();

        public int Damage { get; set; }
        public int Deffense { get; set; }

        
    }
}
