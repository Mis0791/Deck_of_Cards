using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck(){          //this is a method that once inside the class can be accessed by other methods 
            Cards = new List<Card>();
            string[] suits = {"Hearts", "Diamonds", " Clubs", "Spades"};
            string[] names = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "King", "Queen", "Jack"};

            for (int n = 0; n < names.Length; n++){
                for (int s = 0; s < suits.Length; s++){
                    Card newCard = new Card(names[n], n + 1, suits[s]); 
                    Cards.Add(newCard);
                }
            }
        }

        public Card DrawCard(){
            Card cardToReturn = Cards[0];
            Cards.RemoveAt(0);
            return cardToReturn;
        }

        public void Shuffle(){
            Random rand = new Random();
            //run throguh the whole deck swap 2 random cards
            for (int i = 0; i < Cards.Count; i++){
                int swap = rand.Next(0, Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[swap];
                Cards[swap] = temp;
            }
        }

        public override string ToString(){
            return Cards.Count.ToString();
        }

        public Deck(List<Card> otherCards){
            Cards = otherCards;
        }

        public void PrintAllCards(){
            foreach (Card c in Cards){
                System.Console.WriteLine(c);
            }
        }
    }
}