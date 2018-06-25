using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Create constructor (called Deck; always named after the class)
        public Deck()
        {
            //Create new empty list of cards
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        //Shuffling method; give optional perameter for number of times shuffle runs, out variable displays how many times shuffle occured
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                //create temporary list for storing shuffled items
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    //Add cards to a temporary list
                    TempList.Add(Cards[randomIndex]);
                    //delete cards from the original list
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
