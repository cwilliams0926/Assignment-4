namespace Assignment_3
{
    public partial class MainForm : Form
    {
        private const int HAND_SIZE = 5;
        private Deck deck;
        private Card?[] hand = new Card?[HAND_SIZE];

        // file dialog stuff
        private const string DEFAULT_EXT = "txt";
        private const string FILE_FILTER = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        public MainForm()
        {
            InitializeComponent();
            deck = new Deck(cardImageList);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openFileDialog.DefaultExt = DEFAULT_EXT;
            openFileDialog.Filter = FILE_FILTER;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.DefaultExt = DEFAULT_EXT;
            saveFileDialog.Filter = FILE_FILTER;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DealStartingHand();
        }
        private void dealButton_Click(object sender, EventArgs e)
        {
            DealHand();
        }

        private void DealStartingHand()
        {
            for (int i = 0; i < HAND_SIZE; i++)
            {
                GetKeepBox(i).Checked = false;
            }

            deck.Shuffle();

            // Deal five cards from the deck
            for (int i = 0; i < HAND_SIZE; i++)
            {
                hand[i] = deck.DealCard();
            }

            UpdateHandImages();
        }

        private void DealHand()
        {
            // If no cards are kept we need a fresh shuffled deck
            bool anyKept = false;
            for (int i = 0; i < HAND_SIZE; i++)
            {
                if (GetKeepBox(i).Checked)
                {
                    anyKept = true;
                    break;
                }
            }

            if (!anyKept)
            {
                deck.Shuffle();
            }

            // For each slot that is NOT kept, replace it with the next card from the deck
            for (int i = 0; i < HAND_SIZE; i++)
            {
                if (!GetKeepBox(i).Checked)
                {
                    hand[i] = deck.DealCard(); // may be null if deck is exhausted
                }
            }

            UpdateHandImages();
        }

        private void UpdateHandImages()
        {
            for (int i = 0; i < HAND_SIZE; i++)
            {
                var pic = GetPictureBox(i);
                var card = hand[i];

                if (card != null && card.Id >= 0 && card.Id < cardImageList.Images.Count)
                {
                    pic.Image = cardImageList.Images[card.Id];
                }
                else
                {
                    pic.Image = null;
                }
            }
        }

        private PictureBox GetPictureBox(int i)
        {
            switch (i)
            {
                case 0:
                    return cardPictureBox1;
                case 1:
                    return cardPictureBox2;
                case 2:
                    return cardPictureBox3;
                case 3:
                    return cardPictureBox4;
                case 4:
                    return cardPictureBox5;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        private CheckBox GetKeepBox(int i)
        {
            switch (i)
            {
                case 0:
                    return keepCheckBox1;
                case 1:
                    return keepCheckBox2;
                case 2:
                    return keepCheckBox3;
                case 3:
                    return keepCheckBox4;
                case 4:
                    return keepCheckBox5;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                // Deck.SaveHand expects a non-null Card[] so I use Card(-1) to denote no card
                Card[] toSave = new Card[HAND_SIZE];
                for (int i = 0; i < HAND_SIZE; i++)
                {
                    toSave[i] = hand[i] ?? new Card(-1);
                }

                if (!deck.SaveHand(saveFileDialog.FileName, toSave))
                {
                    // Fancy error messages were stolen from stack overflow
                    MessageBox.Show("Failed to save hand.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                Card[] loaded = new Card[HAND_SIZE];

                if (!deck.LoadHand(openFileDialog.FileName, loaded))
                {
                    MessageBox.Show("Failed to load hand.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert loaded cards into hand slots and reset keep boxes
                for (int i = 0; i < HAND_SIZE; i++)
                {
                    var c = loaded[i];
                    hand[i] = (c != null && c.Id >= 0 && c.Id < cardImageList.Images.Count) ? c : null;
                    GetKeepBox(i).Checked = false;
                }

                UpdateHandImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
