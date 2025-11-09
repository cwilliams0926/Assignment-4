
namespace Assignment_3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dealButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            keepCheckBox1 = new CheckBox();
            keepCheckBox2 = new CheckBox();
            keepCheckBox3 = new CheckBox();
            keepCheckBox4 = new CheckBox();
            keepCheckBox5 = new CheckBox();
            cardPictureBox1 = new PictureBox();
            cardPictureBox2 = new PictureBox();
            cardPictureBox3 = new PictureBox();
            cardPictureBox4 = new PictureBox();
            cardPictureBox5 = new PictureBox();
            cardImageList = new ImageList(components);
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            showDeckButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dealButton
            // 
            dealButton.Location = new Point(57, 49);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(103, 45);
            dealButton.TabIndex = 0;
            dealButton.Text = "&Deal";
            dealButton.UseVisualStyleBackColor = true;
            dealButton.Click += dealButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(528, 49);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(103, 45);
            saveButton.TabIndex = 1;
            saveButton.Text = "&Save Hand";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(637, 49);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(103, 44);
            loadButton.TabIndex = 2;
            loadButton.Text = "&Load Hand";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // keepCheckBox1
            // 
            keepCheckBox1.AutoSize = true;
            keepCheckBox1.Location = new Point(57, 192);
            keepCheckBox1.Name = "keepCheckBox1";
            keepCheckBox1.Size = new Size(61, 19);
            keepCheckBox1.TabIndex = 3;
            keepCheckBox1.Text = "Keep &1";
            keepCheckBox1.UseVisualStyleBackColor = true;
            // 
            // keepCheckBox2
            // 
            keepCheckBox2.AutoSize = true;
            keepCheckBox2.Location = new Point(209, 192);
            keepCheckBox2.Name = "keepCheckBox2";
            keepCheckBox2.Size = new Size(61, 19);
            keepCheckBox2.TabIndex = 4;
            keepCheckBox2.Text = "Keep &2";
            keepCheckBox2.UseVisualStyleBackColor = true;
            // 
            // keepCheckBox3
            // 
            keepCheckBox3.AutoSize = true;
            keepCheckBox3.Location = new Point(367, 192);
            keepCheckBox3.Name = "keepCheckBox3";
            keepCheckBox3.Size = new Size(61, 19);
            keepCheckBox3.TabIndex = 5;
            keepCheckBox3.Text = "Keep &3";
            keepCheckBox3.UseVisualStyleBackColor = true;
            // 
            // keepCheckBox4
            // 
            keepCheckBox4.AutoSize = true;
            keepCheckBox4.Location = new Point(519, 192);
            keepCheckBox4.Name = "keepCheckBox4";
            keepCheckBox4.Size = new Size(61, 19);
            keepCheckBox4.TabIndex = 6;
            keepCheckBox4.Text = "Keep &4";
            keepCheckBox4.UseVisualStyleBackColor = true;
            // 
            // keepCheckBox5
            // 
            keepCheckBox5.AutoSize = true;
            keepCheckBox5.Location = new Point(679, 192);
            keepCheckBox5.Name = "keepCheckBox5";
            keepCheckBox5.Size = new Size(61, 19);
            keepCheckBox5.TabIndex = 7;
            keepCheckBox5.Text = "Keep &5";
            keepCheckBox5.UseVisualStyleBackColor = true;
            // 
            // cardPictureBox1
            // 
            cardPictureBox1.Location = new Point(57, 228);
            cardPictureBox1.Name = "cardPictureBox1";
            cardPictureBox1.Size = new Size(100, 155);
            cardPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox1.TabIndex = 8;
            cardPictureBox1.TabStop = false;
            cardPictureBox1.Click += cardPictureBox1_Click;
            // 
            // cardPictureBox2
            // 
            cardPictureBox2.Location = new Point(209, 228);
            cardPictureBox2.Name = "cardPictureBox2";
            cardPictureBox2.Size = new Size(100, 155);
            cardPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox2.TabIndex = 9;
            cardPictureBox2.TabStop = false;
            cardPictureBox2.Click += cardPictureBox2_Click;
            // 
            // cardPictureBox3
            // 
            cardPictureBox3.Location = new Point(367, 228);
            cardPictureBox3.Name = "cardPictureBox3";
            cardPictureBox3.Size = new Size(100, 155);
            cardPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox3.TabIndex = 10;
            cardPictureBox3.TabStop = false;
            cardPictureBox3.Click += cardPictureBox3_Click;
            // 
            // cardPictureBox4
            // 
            cardPictureBox4.Location = new Point(519, 228);
            cardPictureBox4.Name = "cardPictureBox4";
            cardPictureBox4.Size = new Size(100, 155);
            cardPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox4.TabIndex = 11;
            cardPictureBox4.TabStop = false;
            cardPictureBox4.Click += cardPictureBox4_Click;
            // 
            // cardPictureBox5
            // 
            cardPictureBox5.Location = new Point(679, 228);
            cardPictureBox5.Name = "cardPictureBox5";
            cardPictureBox5.Size = new Size(100, 155);
            cardPictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox5.TabIndex = 12;
            cardPictureBox5.TabStop = false;
            cardPictureBox5.Click += cardPictureBox5_Click;
            // 
            // cardImageList
            // 
            cardImageList.ColorDepth = ColorDepth.Depth32Bit;
            cardImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardImageList.ImageStream");
            cardImageList.TransparentColor = Color.Transparent;
            cardImageList.Images.SetKeyName(0, "King of Clubs.png");
            cardImageList.Images.SetKeyName(1, "Ace of Clubs.png");
            cardImageList.Images.SetKeyName(2, "2 of Clubs.png");
            cardImageList.Images.SetKeyName(3, "3 of Clubs.png");
            cardImageList.Images.SetKeyName(4, "4 of Clubs.png");
            cardImageList.Images.SetKeyName(5, "5 of Clubs.png");
            cardImageList.Images.SetKeyName(6, "6 of Clubs.png");
            cardImageList.Images.SetKeyName(7, "7 of Clubs.png");
            cardImageList.Images.SetKeyName(8, "8 of Clubs.png");
            cardImageList.Images.SetKeyName(9, "9 of Clubs.png");
            cardImageList.Images.SetKeyName(10, "10 of Clubs.png");
            cardImageList.Images.SetKeyName(11, "Jack of Clubs.png");
            cardImageList.Images.SetKeyName(12, "Queen of Clubs.png");
            cardImageList.Images.SetKeyName(13, "King of Diamonds.png");
            cardImageList.Images.SetKeyName(14, "Ace of Diamonds.png");
            cardImageList.Images.SetKeyName(15, "2 of Diamonds.png");
            cardImageList.Images.SetKeyName(16, "3 of Diamonds.png");
            cardImageList.Images.SetKeyName(17, "4 of Diamonds.png");
            cardImageList.Images.SetKeyName(18, "5 of Diamonds.png");
            cardImageList.Images.SetKeyName(19, "6 of Diamonds.png");
            cardImageList.Images.SetKeyName(20, "7 of Diamonds.png");
            cardImageList.Images.SetKeyName(21, "8 of Diamonds.png");
            cardImageList.Images.SetKeyName(22, "9 of Diamonds.png");
            cardImageList.Images.SetKeyName(23, "10 of Diamonds.png");
            cardImageList.Images.SetKeyName(24, "Jack of Diamonds.png");
            cardImageList.Images.SetKeyName(25, "Queen of Diamonds.png");
            cardImageList.Images.SetKeyName(26, "King of Hearts.png");
            cardImageList.Images.SetKeyName(27, "Ace of Hearts.png");
            cardImageList.Images.SetKeyName(28, "2 of Hearts.png");
            cardImageList.Images.SetKeyName(29, "3 of Hearts.png");
            cardImageList.Images.SetKeyName(30, "4 of Hearts.png");
            cardImageList.Images.SetKeyName(31, "5 of Hearts.png");
            cardImageList.Images.SetKeyName(32, "6 of Hearts.png");
            cardImageList.Images.SetKeyName(33, "7 of Hearts.png");
            cardImageList.Images.SetKeyName(34, "8 of Hearts.png");
            cardImageList.Images.SetKeyName(35, "9 of Hearts.png");
            cardImageList.Images.SetKeyName(36, "10 of Hearts.png");
            cardImageList.Images.SetKeyName(37, "Jack of Hearts.png");
            cardImageList.Images.SetKeyName(38, "Queen of Hearts.png");
            cardImageList.Images.SetKeyName(39, "King of Spades.png");
            cardImageList.Images.SetKeyName(40, "Ace of Spades.png");
            cardImageList.Images.SetKeyName(41, "2 of Spades.png");
            cardImageList.Images.SetKeyName(42, "3 of Spades.png");
            cardImageList.Images.SetKeyName(43, "4 of Spades.png");
            cardImageList.Images.SetKeyName(44, "5 of Spades.png");
            cardImageList.Images.SetKeyName(45, "6 of Spades.png");
            cardImageList.Images.SetKeyName(46, "7 of Spades.png");
            cardImageList.Images.SetKeyName(47, "8 of Spades.png");
            cardImageList.Images.SetKeyName(48, "9 of Spades.png");
            cardImageList.Images.SetKeyName(49, "10 of Spades.png");
            cardImageList.Images.SetKeyName(50, "Jack of Spades.png");
            cardImageList.Images.SetKeyName(51, "Queen of Spades.png");
            // 
            // showDeckButton
            // 
            showDeckButton.Location = new Point(166, 49);
            showDeckButton.Name = "showDeckButton";
            showDeckButton.Size = new Size(114, 45);
            showDeckButton.TabIndex = 13;
            showDeckButton.Text = "S&how Deck";
            showDeckButton.UseVisualStyleBackColor = true;
            showDeckButton.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showDeckButton);
            Controls.Add(cardPictureBox5);
            Controls.Add(cardPictureBox4);
            Controls.Add(cardPictureBox3);
            Controls.Add(cardPictureBox2);
            Controls.Add(cardPictureBox1);
            Controls.Add(keepCheckBox5);
            Controls.Add(keepCheckBox4);
            Controls.Add(keepCheckBox3);
            Controls.Add(keepCheckBox2);
            Controls.Add(keepCheckBox1);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(dealButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Poker Hand Simulator";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)cardPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button dealButton;
        private Button saveButton;
        private Button loadButton;
        private CheckBox keepCheckBox1;
        private CheckBox keepCheckBox2;
        private CheckBox keepCheckBox3;
        private CheckBox keepCheckBox4;
        private CheckBox keepCheckBox5;
        private PictureBox cardPictureBox1;
        private PictureBox cardPictureBox2;
        private PictureBox cardPictureBox3;
        private PictureBox cardPictureBox4;
        private PictureBox cardPictureBox5;
        private ImageList cardImageList;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button showDeckButton;
    }
}
