using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WARgame.Console.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public bool HasAtLeastOneCard
        {
            get
            {
                return Hand.Count > 0;
            }
        }
        private List<Card> Hand { get; set; } = new List<Card>();


        public Card DrawTopCard()
        {
            Card topCard = this.Hand[0];
            this.Hand.RemoveAt(0);
            return topCard;
        }

        public List<Card> DrawTopCards(int numberOfCardsToDraw)
        {
           List<Card> topCards = this.Hand.GetRange(0,numberOfCardsToDraw);
           this.Hand.RemoveRange(0, numberOfCardsToDraw);
           return topCards;
        }

        public void AddSingleCard(Card cardAdded)
        {
            Hand.Add(cardAdded);
        }

        public void AddCardsToHand(List<Card> cardToAdd)
        {
            Hand.AddRange(cardToAdd);
        }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}
