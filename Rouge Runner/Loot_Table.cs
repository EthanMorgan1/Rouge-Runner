using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Runner
{
    internal class Loot_Table
    {

        public Dictionary<int, string> _table = 
            new Dictionary<int, string>();

        private static Hashtable openWith = new Hashtable();
        int i = 0;

        public void addItem(Items item)
        {
            openWith.Add(item, i);
            i++;
        }

        public Loot_Table()
        {
            Shield shield = new Shield();
            addItem(shield);
        }
        
    }
}
