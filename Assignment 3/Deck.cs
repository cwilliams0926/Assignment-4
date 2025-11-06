using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Deck
    {
        private List<Card> cards;
        private ImageList _imageList;

        public Deck(ImageList imageList)
        {
            _imageList = imageList;
        }

        public void Shuffle()
        {
            cards = new List<Card>();
            for (int i = 0; i < _imageList.Images.Count; i++)
            {
                cards.Add(new Card(i));
            }

            // This part was made with the help of AI
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Card temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                return new Card(-1);
            }
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }

        public bool SaveHand(string filename, Card[] hand)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Card card in hand)
                    {
                        writer.WriteLine(card.Id);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool LoadHand(string filename, Card[] hand)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    for (int i = 0; i < hand.Length; i++)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            return false;
                        }
                        if (int.TryParse(line, out int cardId))
                        {
                            hand[i] = new Card(cardId);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
