namespace Assignment_3
{
    public partial class MainForm : Form
    {
        private const int HAND_SIZE = 5;
        private const int NO_CARDS = -1;
        private List<int> deck = new List<int>();
        private int[] hand = new int[HAND_SIZE];
        private Random rng = new Random();

        // file dialog stuff
        private const string DEFAULT_EXT = "txt";
        private const string FILE_FILTER = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        public MainForm()
        {
            InitializeComponent();
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
            DealHand();
        }

        private void DealHand()
        {
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
                deck.Clear();
                for (int i = 0; i < cardImageList.Images.Count; i++)
                {
                    deck.Add(i);
                }
                Shuffle(deck);
            }

            for (int i = 0; i < HAND_SIZE; i++)
            {
                if (!GetKeepBox(i).Checked)
                {
                    if (deck.Count > 0)
                    {
                        hand[i] = deck[0];
                        deck.RemoveAt(0);
                    }
                    else
                    {
                        hand[i] = NO_CARDS;
                    }
                }
            }

            UpdateHandImages();
        }

        private void Shuffle<T>(IList<T> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);

                // tuple swap
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        private void UpdateHandImages()
        {
            for (int i = 0; i < HAND_SIZE; i++)
            {
                var pic = GetPictureBox(i);
                int index = hand[i];
                if (index >= 0 && index < cardImageList.Images.Count) // if index is valid
                {
                    pic.Image = cardImageList.Images[index];
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
                using (var sw = new StreamWriter(saveFileDialog.FileName)) // ensures file closes
                {
                    for (int i = 0; i < HAND_SIZE; i++) // writes hand indices to a separate line in the file
                    {
                        sw.WriteLine(hand[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName); // array for all lines in the file

                // loop over each card slot, parse the line, set the hand array, reset the keep checkboxes
                for(int i = 0; i < HAND_SIZE; i++)
                {
                    hand[i] = (i < lines.Length && int.TryParse(lines[i], out int val)
                        && val >= 0 && val < cardImageList.Images.Count) ? val : NO_CARDS;
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
