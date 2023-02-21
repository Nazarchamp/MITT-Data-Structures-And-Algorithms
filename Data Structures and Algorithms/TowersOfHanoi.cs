using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Data_Structures_and_Algorithms
{
    internal static class TowersOfHanoi
    {
        public static void SolveTower(int[] towers, string targetPos, string unusedPos, string curPos)
        {
            if(towers.Length == 1)
            {
                WriteLine($"Move {towers[0]} from {curPos} to {targetPos}");
            }
            else
            {
                // Solve tower without bottom with curpos of our curpos, and target of the remainng tower position
                SolveTower(towers[0..(towers.Length-1)], unusedPos, targetPos, curPos);
                WriteLine($"Move {towers[towers.Length-1]} from {curPos} to {targetPos}");
                // Solve tower without bottom wit curpos of the remaining tower position and target of our target
                SolveTower(towers[0..(towers.Length - 1)], targetPos, curPos, unusedPos);
            }
        }

    }
}
