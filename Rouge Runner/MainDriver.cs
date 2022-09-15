namespace Rouge_Runner
{
    public class Driver
    {
        public static Utility util = new Utility();
        public static Player player = new Player();
        public static Dungeon dungeon = new Dungeon();
        private static void Main(string[] args)
        {
            StartofGameSetUp();

            Console.WriteLine(player.ToString() + "\n");
           
            dungeon.PrintMap();
            Console.WriteLine("\n");

            while(dungeon.index != dungeon.cellList.Count)
            {
                dungeon.MovePlayer();
                Console.Clear();
                Console.WriteLine(player.ToString());
                dungeon.PrintMap();
                Console.WriteLine("\n");
                if (dungeon.cellList[dungeon.index - 1] == "|P _ M|" || dungeon.cellList[dungeon.index - 1] == "|P I M|") //Does see the monster
                {
                    Zombie monster = new Zombie();
                    Console.WriteLine("Monster");
                    while(monster.getHealth() > 0 && player.GetHealth() > 0)
                    {
                        util.Combat(player, monster);
                    }
                }
                if(player.GetHealth() < 0)
                {
                    Console.WriteLine("Game Over");
                    break;
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
    
