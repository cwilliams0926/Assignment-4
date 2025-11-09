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
            for (int i = 0; i < _deck.Count; i++)
            {
                Card card = _deck.GetCard(i);
                cardsListBox.Items.Add(card);
            }
        }

        private void DeckForm_Load(object sender, EventArgs e)
        {
            UpdateDeck();
        }

        private void cardsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card? card = (Card?)cardsListBox.SelectedItem;
            deckPictureBox.Image = card?.CardImage;
        }

        private void cardsLabel_Click(object sender, EventArgs e)
        {

        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (cardsListBox.SelectedIndex < 0)
                return;
            
            if (cardsListBox.SelectedIndex - 1 < 0 || cardsListBox.SelectedIndex - 1 >= _deck.Count)
                return;

            _deck.SwapCards(cardsListBox.SelectedIndex, cardsListBox.SelectedIndex - 1);
            UpdateDeck();
            cardsListBox.SetSelected(cardsListBox.SelectedIndex - 1, true);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (cardsListBox.SelectedIndex < 0)
                return;

            if (cardsListBox.SelectedIndex + 1 < 0 || cardsListBox.SelectedIndex + 1 >= _deck.Count)
                return;

            _deck.SwapCards(cardsListBox.SelectedIndex, cardsListBox.SelectedIndex + 1);
            UpdateDeck();
            cardsListBox.SetSelected(cardsListBox.SelectedIndex + 1, true);
        }
    }
}
