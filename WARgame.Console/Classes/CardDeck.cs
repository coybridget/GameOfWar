using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WARgame.Console.Classes
{
    public class CardDeck
    {

        private List<Card> Cards { get; set; } = new List<Card>();

        public CardDeck()
        {
            for (int i = 1; i < 14; i++)
            {
                Card diamond = new Card("diamonds", i);
                Card heart = new Card("hearts", i);
                Card spade = new Card("spades", i);
                Card club = new Card("clubs", i);

                Cards.Add(diamond);
                Cards.Add(heart);
                Cards.Add(spade);
                Cards.Add(club);
            }
        }

        public void Shuffle()
        {
            Random r = new Random();

            List<Card> cards = Cards;
            for (int n = cards.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
        }

        public Card Draw()
        {
            Card topCard = this.Cards[0];
            this.Cards.RemoveAt(0);
            return topCard;
        }

        public int CardsRemaining()
        {
            return Cards.Count;
          }
        }
  }