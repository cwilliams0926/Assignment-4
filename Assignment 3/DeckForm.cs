using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class DeckForm : Form
    {
        private Deck _deck;
        public DeckForm(Deck deck)
        {
            _deck = deck;
            InitializeComponent();
        }

        public void UpdateDeck()
        {
            cardsListBox.Items.Clear();
            for(int i = 0; i < _deck.Count; i++)
            {
                Card card = _deck.GetCard(i);
                cardsListBox.Items.Add(card);
            }
        }
    }
}
