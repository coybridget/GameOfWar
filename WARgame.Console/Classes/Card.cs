using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WARgame.Console.Classes
{
    public class Card
    {
        //WAR
        //Take one Deck of 52 cards
        //shuffle and divide cards amongst players
        //each player puts down a card at the same time. the higher card wins the other players card and
        //places the new cards in a seperate new pile
        //if card is the same each player places three cards face down and then draws a fourth card
        //whoevers card is highest wins all the cards
        //the goal is to win all the cards
        //when either player runs out of cards in their hand they shuffle from their new pile


        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string suit, int value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}