using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal class Deck
    {
        private int[] deckArr = new int[52];
        private Random rnd = new Random();

        private Dictionary<int, string> suitMap = new Dictionary<int, string>() { {0, "Spades"}, { 1, "Hearts"}, { 2, "Diamonds" }, { 3, "Clubs" } };
        private Dictionary<int, string> faceCardMap = new Dictionary<int, string>() { { 0, "Ace" }, { 10, "Jack" }, { 11, "Queen" }, { 12, "King" } };

        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                deckArr[i] = i;
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < 52; i++)
            {
                int temp = deckArr[i];
                int switchIndex = rnd.Next(0, 52);
                deckArr[i] = deckArr[switchIndex];
                deckArr[switchIndex] = temp;
            }
        }

        public void PrintTopFour()
        {
            for (int i = 0; i < 4; i++)
            {
                string cardName = (deckArr[i] % 13 + 1).ToString();
                if (faceCardMap.ContainsKey(deckArr[i]%13))
                    cardName = faceCardMap[deckArr[i]%13];
                Console.WriteLine($"{cardName} of {suitMap[deckArr[i]/13]}");
            }
        }
    }
}
