using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IStone_Card_Game
{
    public class Deck 
    {
        private Card[] deck;
        private int currentCard;
        private const int NumberOfCards = 52;
        //private int NumberOfCards = MainWindow.NumberOfCards;
        private Random randomNumber;

        public Deck()
        {
            string[] numbers = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                                "Éight", "Nine", "Ten", "Jack", "Queen", "King" };

            //string[] numbers = {"01", "02", "03", "04", "05", "06", "07",
            //                    "08", "09", "10", "11", "12", "13" };

            string[] color = { "Hearts", "Clubs", "Diamonds", "Spades" };

            deck = new Card[NumberOfCards];
            currentCard = 0;
            randomNumber = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(numbers[count % 13], color[count / 13]);
        }


        public void Shuffle()
        {
            currentCard = 0;

            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNumber.Next(NumberOfCards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;

                Console.WriteLine(NumberOfCards);
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }

    }
}
