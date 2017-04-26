using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WARgame.Console.Classes
{
    public class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public CardDeck StartingDeck { get; set; }
        //public bool InWar { get; set; }
        public Game Winner { get; set; }

        public Game(string playerOneName, string playerTwoName)
        {
            PlayerOne = new Player(playerOneName);
            PlayerTwo = new Player(playerTwoName);

            StartingDeck = new CardDeck();
            StartingDeck.Shuffle();

        }

        public void Deal()
        {
            while (StartingDeck.CardsRemaining() != 0)
            {
                PlayerOne.AddSingleCard(StartingDeck.Draw());
                PlayerTwo.AddSingleCard(StartingDeck.Draw());
            }
        }

        public void Play()
        {
            List<Card> playerOneDropCards = new List<Card>();
            List<Card> playerTwoDropCards = new List<Card>();

            while ((PlayerOne.HasAtLeastOneCard && PlayerTwo.HasAtLeastOneCard))
            {
                Card playerOneCard = PlayerOne.DrawTopCard();
                System.Console.WriteLine($"Player one top card is {playerOneCard.Value} of {playerOneCard.Suit}");
                playerOneDropCards.Add(playerOneCard);

                Card playerTwoCard = PlayerTwo.DrawTopCard();
                playerTwoDropCards.Add(playerTwoCard);
                System.Console.WriteLine($"Player two top card is {playerTwoCard.Value} of {playerTwoCard.Suit}");


                if ((playerOneDropCards[playerOneDropCards.Count - 1].Value) > (playerTwoDropCards[playerTwoDropCards.Count - 1].Value))
                {
                    System.Console.WriteLine($"Player one has the high card \n");
                    PlayerOne.AddCardsToHand(playerOneDropCards);
                    playerOneDropCards.Clear();
                    PlayerOne.AddCardsToHand(playerTwoDropCards);
                    playerTwoDropCards.Clear();
                }
                else if ((playerTwoDropCards[playerTwoDropCards.Count - 1].Value) > (playerOneDropCards[playerOneDropCards.Count - 1].Value))
                {
                    System.Console.WriteLine($"Player two has the high card \n");
                    PlayerTwo.AddCardsToHand(playerOneDropCards);
                    playerTwoDropCards.Clear();
                    PlayerTwo.AddCardsToHand(playerOneDropCards);
                    playerOneDropCards.Clear();
                }

                else
                {
                    System.Console.WriteLine($"WAR!!!!!!! \n");

                
                    playerOneDropCards.AddRange(PlayerOne.DrawTopCards(2));
                    playerTwoDropCards.AddRange(PlayerTwo.DrawTopCards(2));

                    continue;
                }

            }
            if (PlayerOne.HasAtLeastOneCard)
            {
                System.Console.WriteLine("Player One is the winner!");
            }
            else
            {
                System.Console.WriteLine("Player Two is the winner!");
            }
        }
    }
}
