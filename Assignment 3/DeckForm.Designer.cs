namespace Assignment_3
{
    partial class DeckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardsListBox = new ListBox();
            cardsLabel = new Label();
            deckPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)deckPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardsListBox
            // 
            cardsListBox.FormattingEnabled = true;
            cardsListBox.ItemHeight = 15;
            cardsListBox.Location = new Point(99, 142);
            cardsListBox.Name = "cardsListBox";
            cardsListBox.Size = new Size(120, 94);
            cardsListBox.TabIndex = 1;
            // 
            // cardsLabel
            // 
            cardsLabel.AutoSize = true;
            cardsLabel.Location = new Point(99, 115);
            cardsLabel.Name = "cardsLabel";
            cardsLabel.Size = new Size(37, 15);
            cardsLabel.TabIndex = 0;
            cardsLabel.Text = "&Cards";
            // 
            // deckPictureBox
            // 
            deckPictureBox.Location = new Point(336, 115);
            deckPictureBox.Name = "deckPictureBox";
            deckPictureBox.Size = new Size(123, 174);
            deckPictureBox.TabIndex = 2;
            deckPictureBox.TabStop = false;
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deckPictureBox);
            Controls.Add(cardsLabel);
            Controls.Add(cardsListBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeckForm";
            Text = "DeckForm";
            ((System.ComponentModel.ISupportInitialize)deckPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox cardsListBox;
        private Label cardsLabel;
        private PictureBox deckPictureBox;
    }
}