using System;
using System.Collections.Generic;
using System.Linq;

namespace DayElevenAndTwelveAssignment
{
    internal class DeckOfCards
    {
        string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
        string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        Random random = new Random();
        Dictionary<int, List<string>> deal = new Dictionary<int, List<string>>();

        private void ShowDeals(Dictionary<int, List<string>> deal)
        {
            foreach (var k in deal)
            {
                Console.WriteLine($">>{k.Key}: {string.Join(", ", k.Value)} ");
            }
        }
        private List<string> SuffleCards()
        {
            var cards = new List<string>();
            for (int j = 0; j < 9; j++)
            {
                while (true)
                {
                    int randomSuit = random.Next(0, 4);
                    int randomRank = random.Next(0, 13);
                    string newCard = $"{suit[randomSuit]}-{rank[randomRank]}";
                    if (!cards.Contains(newCard))
                    {
                        cards.Add(newCard);
                        break;
                    }
                }
            }
            return cards;
        }
        public void Solution()
        {
            for (int i = 0; i < 4; i++)
            {
                var cards = this.SuffleCards();
                deal.Add(i, cards);
            }
            this.ShowDeals(deal);
        }
    }
}
