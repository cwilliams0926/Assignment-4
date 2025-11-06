
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
            // 
            // cardPictureBox2
            // 
            cardPictureBox2.Location = new Point(209, 228);
            cardPictureBox2.Name = "cardPictureBox2";
            cardPictureBox2.Size = new Size(100, 155);
            cardPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox2.TabIndex = 9;
            cardPictureBox2.TabStop = false;
            // 
            // cardPictureBox3
            // 
            cardPictureBox3.Location = new Point(367, 228);
            cardPictureBox3.Name = "cardPictureBox3";
            cardPictureBox3.Size = new Size(100, 155);
            cardPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox3.TabIndex = 10;
            cardPictureBox3.TabStop = false;
            // 
            // cardPictureBox4
            // 
            cardPictureBox4.Location = new Point(519, 228);
            cardPictureBox4.Name = "cardPictureBox4";
            cardPictureBox4.Size = new Size(100, 155);
            cardPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox4.TabIndex = 11;
            cardPictureBox4.TabStop = false;
            // 
            // cardPictureBox5
            // 
            cardPictureBox5.Location = new Point(679, 228);
            cardPictureBox5.Name = "cardPictureBox5";
            cardPictureBox5.Size = new Size(100, 155);
            cardPictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox5.TabIndex = 12;
            cardPictureBox5.TabStop = false;
            // 
            // cardImageList
            // 
            cardImageList.ColorDepth = ColorDepth.Depth32Bit;
            cardImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardImageList.ImageStream");
            cardImageList.TransparentColor = Color.Transparent;
            cardImageList.Images.SetKeyName(0, "p1.png");
            cardImageList.Images.SetKeyName(1, "p2.png");
            cardImageList.Images.SetKeyName(2, "p3.png");
            cardImageList.Images.SetKeyName(3, "p4.png");
            cardImageList.Images.SetKeyName(4, "p5.png");
            cardImageList.Images.SetKeyName(5, "p6.png");
            cardImageList.Images.SetKeyName(6, "p7.png");
            cardImageList.Images.SetKeyName(7, "p8.png");
            cardImageList.Images.SetKeyName(8, "p9.png");
            cardImageList.Images.SetKeyName(9, "p10.png");
            cardImageList.Images.SetKeyName(10, "p11.png");
            cardImageList.Images.SetKeyName(11, "p12.png");
            cardImageList.Images.SetKeyName(12, "p13.png");
            cardImageList.Images.SetKeyName(13, "p14.png");
            cardImageList.Images.SetKeyName(14, "p15.png");
            cardImageList.Images.SetKeyName(15, "p16.png");
            cardImageList.Images.SetKeyName(16, "p17.png");
            cardImageList.Images.SetKeyName(17, "p18.png");
            cardImageList.Images.SetKeyName(18, "p19.png");
            cardImageList.Images.SetKeyName(19, "p20.png");
            cardImageList.Images.SetKeyName(20, "p21.png");
            cardImageList.Images.SetKeyName(21, "p22.png");
            cardImageList.Images.SetKeyName(22, "p23.png");
            cardImageList.Images.SetKeyName(23, "p24.png");
            cardImageList.Images.SetKeyName(24, "p25.png");
            cardImageList.Images.SetKeyName(25, "p26.png");
            cardImageList.Images.SetKeyName(26, "p27.png");
            cardImageList.Images.SetKeyName(27, "p28.png");
            cardImageList.Images.SetKeyName(28, "p29.png");
            cardImageList.Images.SetKeyName(29, "p30.png");
            cardImageList.Images.SetKeyName(30, "p31.png");
            cardImageList.Images.SetKeyName(31, "p32.png");
            cardImageList.Images.SetKeyName(32, "p33.png");
            cardImageList.Images.SetKeyName(33, "p34.png");
            cardImageList.Images.SetKeyName(34, "p35.png");
            cardImageList.Images.SetKeyName(35, "p36.png");
            cardImageList.Images.SetKeyName(36, "p37.png");
            cardImageList.Images.SetKeyName(37, "p38.png");
            cardImageList.Images.SetKeyName(38, "p39.png");
            cardImageList.Images.SetKeyName(39, "p40.png");
            cardImageList.Images.SetKeyName(40, "p41.png");
            cardImageList.Images.SetKeyName(41, "p42.png");
            cardImageList.Images.SetKeyName(42, "p43.png");
            cardImageList.Images.SetKeyName(43, "p44.png");
            cardImageList.Images.SetKeyName(44, "p45.png");
            cardImageList.Images.SetKeyName(45, "p46.png");
            cardImageList.Images.SetKeyName(46, "p47.png");
            cardImageList.Images.SetKeyName(47, "p48.png");
            cardImageList.Images.SetKeyName(48, "p49.png");
            cardImageList.Images.SetKeyName(49, "p50.png");
            cardImageList.Images.SetKeyName(50, "p51.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
