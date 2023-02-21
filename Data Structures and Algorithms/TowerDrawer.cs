using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal class TowerDrawer
    {
        private int[][] spots;
        private int size;

        public void setBaseTower(int tsize)
        {
            size=tsize;
            spots = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                spots[i] = new int[tsize];
            }

            for (int i=0; i<tsize; i++)
            {
                spots[0][i] = i+1;
            }
            drawTower();
        }

        public void moveItem(int location, int target)
        {
            int movableItem = -1;
            for (int i = size-1; i >-1; i--)
            {
                if (spots[location][i] == 0)
                {
                    movableItem = spots[location][i];
                    spots[location][i] = 0;
                    break;
                }else if(i == size - 1)
                {
                    movableItem = spots[location][0];
                    spots[location][0] = 0;
                }
            }

            for (int i = 0; i < size; i++)
            {
                if (spots[target][i] == 0)
                {
                    spots[target][i] = movableItem;
                    break;
                }
            }
            drawTower();
        }

        private void drawTower()
        {
            Console.WriteLine("**********************");
            foreach(int[] arr in spots)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] > 0)
                    {
                        string body = new String('#', arr[i] * 2 - 1);
                        string offset = new String(' ', ((size * 2 - 1) - body.Length)/2);
                        Console.WriteLine(offset+body);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine(new String('-', size * 2 - 1));
            }

        }
    }
}
