using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing;

namespace Assignment_3
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private readonly ImageList _imageList;
        private readonly Random rng = new Random();

        public Deck(ImageList imageList)
        {
            _imageList = imageList;
        }

        // The shuffling logic was adapted from AI

        /// <summary>
        /// Build and shuffle the deck. If excludeIds is provided, those card Ids are omitted
        /// from the deck (useful to avoid dealing duplicates of cards already in a hand).
        /// </summary>
        public void Shuffle(IEnumerable<int>? excludeIds = null)
        {
            var exclude = excludeIds != null ? new HashSet<int>(excludeIds.Where(id => id >= 0)) : null;
            cards = new List<Card>();
            for (int i = 0; i < _imageList.Images.Count; i++)
            {
                if (exclude != null && exclude.Contains(i))
                    continue;

                // create Card with its image from the ImageList
                cards.Add(new Card(i, _imageList.Images[i]));
            }

            // Fisher–Yates shuffle using single Random instance
            for (int n = cards.Count - 1; n > 0; n--)
            {
                int k = rng.Next(n + 1);
                Card tmp = cards[n];
                cards[n] = cards[k];
                cards[k] = tmp;
            }
        }

        public Card DealCard()
        {
            if (cards == null || cards.Count == 0)
            {
                // use the Card.NoCard sentinel
                return Card.NoCard;
            }

            var dealt = cards[0];
            cards.RemoveAt(0);
            return dealt;
        }

        public int Count => cards?.Count ?? 0;

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
                        string? line = reader.ReadLine();
                        if (line == null)
                        {
                            return false;
                        }
                        if (int.TryParse(line, out int cardId))
                        {
                            if (cardId == -1)
                            {
                                hand[i] = Card.NoCard;
                            }
                            else if (cardId >= 0 && cardId < _imageList.Images.Count)
                            {
                                hand[i] = new Card(cardId, _imageList.Images[cardId]);
                            }
                            else
                            {
                                // invalid id in file
                                return false;
                            }
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
