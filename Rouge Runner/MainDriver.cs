namespace Rouge_Runner
{
    public class Driver
    {
        public static Utility util = new Utility();
        public static Player player = new Player();
        public static Dungeon dungeon = new Dungeon();
        public static Items items = new Items();
        private static void Main(string[] args)
        {
            StartofGameSetUp();

            Console.WriteLine(player.ToString() + "\n");
            Console.WriteLine("(A) move left    (D) move right \n");
           
            dungeon.PrintMap();
            Console.WriteLine("\n");

            while(dungeon.index != dungeon.cellList.Count)
            {
                dungeon.MovePlayer();
                Console.Clear();
                Console.WriteLine(player.ToString());
                Console.WriteLine("(A) move left    (D) move right \n");
                dungeon.PrintMap();
                Console.WriteLine("\n");
                if(player.GetHealth() < 0)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
      
                if (dungeon.cellList[dungeon.index - 1] == "|P _ M|" ) //Does see the monster
                {
                    Zombie monster = new Zombie();
                    Console.WriteLine("Monster");
                    util.Combat(player, monster);
                }
                else if (dungeon.cellList[dungeon.index - 1] == "|P I M|")
                {
                    Zombie monster = new Zombie();
                   
                    Console.WriteLine("Monster");
                    util.Combat(player, monster);
                    util.WeaponChance();
                }
                else if (dungeon.cellList[dungeon.index - 1] == "|P I _|")
                {
                    util.WeaponChance();
                }
            }
 
        }

        public static void StartofGameSetUp()
        {
           
            Console.WriteLine("What is your name?");

                

            player.SetName(Console.ReadLine());

            Random ran = new Random();

            int random = ran.Next(2, 3);

            for (int i = 0; i < random; i++)
            {
                dungeon.GenerateCellList();
            }

            dungeon.ShuffleCells(dungeon.cellList);

            Console.Clear();

        }




    }
}
    
