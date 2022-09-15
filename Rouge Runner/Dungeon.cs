using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rouge_Runner
{
    public static class DungeonExtension
    {
        private static Random random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
           
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

        }

    }

    public class Dungeon
    {
        public List<string> cellList = new List<string>();
        public int index = 1;

        public Dungeon()
        {

        }

        public List<string> GenerateCellList()
        {
            cellList.Add("|_ _ M|");

            cellList.Add("|_ I _|");

            cellList.Add("|_ I M|");

            return cellList;
        }

        public void ShuffleCells(List<string> list)
        {
           
            string startingCell = "|P _ _|";

            cellList.Shuffle();

            cellList.Insert(0, startingCell);

            cellList.Insert(cellList.Count, "|_ _ B|");

        }

        public void PrintMap()
        {
            foreach (var cell in cellList)
            {
                Console.Write(cell + " ");
            }
        }


        public void MovePlayer()
        {
           
            string container = "";

            var move = Console.ReadKey();

            if (move.Key == ConsoleKey.D)
            {
                if (cellList[index] == "|_ _ M|")
                {
                    
                    container = "|_ _ M|";

                    cellList[index] = "|P _ M|";

                    cellList[index - 1] = "|_ _ _|";

                    index++;

                }
                else if (cellList[index] == "|_ I M|")
                {
                    
                    container = "|_ I M|";

                    cellList[index] = "|P I M|";

                    cellList[index - 1] = "|_ _ _|";

                    index++;
                }
                else if (cellList[index] == "|_ I _|")
                {
                   

                    container = "|_ I _|";

                    cellList[index] = "|P I _|";

                    cellList[index - 1] = "|_ _ _|";

                    index++;
                }
                else if(cellList[index] == "|_ _ _|")
                {
                    cellList[index] = "|P _ _|";

                    cellList[index - 1] = "|_ _ _|";

                    index++;

                }
                else if (cellList[index] == "|_ _ B|")
                {
                    cellList[index] = "|P _ B|";

                    cellList[index - 1] = "|_ _ _|";

                    index++;
                }
            }
            else if (move.Key == ConsoleKey.A)
            {
                if (cellList[index - 2] == "|_ _ _|")
                {
                    index--;
                    cellList[index] = "|_ _ _|";
                    cellList[index - 1] = "|P _ _|";
                }
            }
           
        }

    }
}
