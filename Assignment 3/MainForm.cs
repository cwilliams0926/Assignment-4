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

            if (cardImageList.Images.Count < HAND_SIZE)
            {
                MessageBox.Show("Not enough images to deal a full hand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start with a fresh shuffled deck for a brand new hand
            deck.Shuffle();

            // Deal five cards from the deck
            for (int i = 0; i < HAND_SIZE; i++)
            {
                var dealt = deck.DealCard();
                hand[i] = dealt.Id >= 0 ? dealt : null;
            }

            UpdateHandImages();
        }

        private void DealHand()
        {
            // Determine which slots are kept and the IDs to exclude
            var keptIds = Enumerable.Range(0, HAND_SIZE)
                                    .Where(i => GetKeepBox(i).Checked)
                                    .Select(i => hand[i]?.Id ?? -1)
                                    .Where(id => id >= 0)
                                    .ToList();

            int needed = Enumerable.Range(0, HAND_SIZE).Count(i => !GetKeepBox(i).Checked);

            // Ensure deck has enough cards to fill the unkept slots.
            // If not, rebuild/shuffle it excluding the kept IDs.
            if (deck.Count < needed)
            {
                deck.Shuffle(keptIds);
            }
            else
            {
                // If no cards are kept we can use a full fresh deck (optional)
                if (!keptIds.Any())
                    deck.Shuffle();
            }

            // For each slot that is NOT kept, replace it from the deck
            for (int i = 0; i < HAND_SIZE; i++)
            {
                if (!GetKeepBox(i).Checked)
                {
                    var dealt = deck.DealCard();
                    hand[i] = dealt.Id >= 0 ? dealt : null;
                }
            }

            UpdateHandImages();
        }

        private void UpdateHandImages()
        {
            // made it null safe since hand slots can be null
            cardPictureBox1.Image = hand[0]?.CardImage;
            cardPictureBox2.Image = hand[1]?.CardImage;
            cardPictureBox3.Image = hand[2]?.CardImage;
            cardPictureBox4.Image = hand[3]?.CardImage;
            cardPictureBox5.Image = hand[4]?.CardImage;
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
                // Deck.SaveHand expects a non-null Card[] so I use Card(-1) for no card
                Card[] toSave = new Card[HAND_SIZE];
                for (int i = 0; i < HAND_SIZE; i++)
                {
                    toSave[i] = hand[i] ?? Card.NoCard;
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

        private void cardPictureBox1_Click(object sender, EventArgs e)
        {
            keepCheckBox1.Checked = !keepCheckBox1.Checked;
        }

        private void cardPictureBox2_Click(object sender, EventArgs e)
        {
            keepCheckBox2.Checked = !keepCheckBox2.Checked;
        }

        private void cardPictureBox3_Click(object sender, EventArgs e)
        {
            keepCheckBox3.Checked = !keepCheckBox3.Checked;
        }

        private void cardPictureBox4_Click(object sender, EventArgs e)
        {
            keepCheckBox4.Checked = !keepCheckBox4.Checked;
        }

        private void cardPictureBox5_Click(object sender, EventArgs e)
        {
            keepCheckBox5.Checked = !keepCheckBox5.Checked;
        }
    }
}
