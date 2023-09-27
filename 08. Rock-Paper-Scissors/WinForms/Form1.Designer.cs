namespace WinForms {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            buttonRock = new Button();
            buttonPaper = new Button();
            buttonScissors = new Button();
            picturePlayerChoice = new PictureBox();
            pictureNpcChoice = new PictureBox();
            buttonReset = new Button();
            gameResultText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picturePlayerChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureNpcChoice).BeginInit();
            SuspendLayout();
            // 
            // buttonRock
            // 
            buttonRock.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRock.Cursor = Cursors.Hand;
            buttonRock.FlatAppearance.BorderSize = 0;
            buttonRock.FlatStyle = FlatStyle.Flat;
            buttonRock.Image = Properties.Resources.rock_l;
            buttonRock.Location = new Point(12, 12);
            buttonRock.Name = "buttonRock";
            buttonRock.Size = new Size(173, 173);
            buttonRock.TabIndex = 0;
            buttonRock.UseVisualStyleBackColor = true;
            buttonRock.Click += buttonRock_Click;
            // 
            // buttonPaper
            // 
            buttonPaper.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPaper.Cursor = Cursors.Hand;
            buttonPaper.FlatAppearance.BorderSize = 0;
            buttonPaper.FlatStyle = FlatStyle.Flat;
            buttonPaper.Image = Properties.Resources.paper_l;
            buttonPaper.Location = new Point(191, 12);
            buttonPaper.Name = "buttonPaper";
            buttonPaper.Size = new Size(173, 173);
            buttonPaper.TabIndex = 1;
            buttonPaper.UseVisualStyleBackColor = true;
            buttonPaper.Click += buttonPaper_Click;
            // 
            // buttonScissors
            // 
            buttonScissors.BackgroundImageLayout = ImageLayout.Stretch;
            buttonScissors.Cursor = Cursors.Hand;
            buttonScissors.FlatAppearance.BorderSize = 0;
            buttonScissors.FlatStyle = FlatStyle.Flat;
            buttonScissors.Image = Properties.Resources.scissors_l;
            buttonScissors.Location = new Point(371, 12);
            buttonScissors.Name = "buttonScissors";
            buttonScissors.Size = new Size(173, 173);
            buttonScissors.TabIndex = 2;
            buttonScissors.UseVisualStyleBackColor = true;
            buttonScissors.Click += buttonScissors_Click;
            // 
            // picturePlayerChoice
            // 
            picturePlayerChoice.BackgroundImageLayout = ImageLayout.Stretch;
            picturePlayerChoice.Location = new Point(181, 245);
            picturePlayerChoice.Name = "picturePlayerChoice";
            picturePlayerChoice.Size = new Size(100, 100);
            picturePlayerChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePlayerChoice.TabIndex = 3;
            picturePlayerChoice.TabStop = false;
            // 
            // pictureNpcChoice
            // 
            pictureNpcChoice.BackgroundImageLayout = ImageLayout.Stretch;
            pictureNpcChoice.Location = new Point(287, 245);
            pictureNpcChoice.Name = "pictureNpcChoice";
            pictureNpcChoice.Size = new Size(100, 100);
            pictureNpcChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureNpcChoice.TabIndex = 4;
            pictureNpcChoice.TabStop = false;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(415, 404);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(129, 34);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Play again";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Visible = false;
            buttonReset.Click += resetGame;
            // 
            // gameResultText
            // 
            gameResultText.BackColor = SystemColors.ButtonFace;
            gameResultText.BorderStyle = BorderStyle.None;
            gameResultText.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gameResultText.Location = new Point(12, 411);
            gameResultText.Name = "gameResultText";
            gameResultText.PlaceholderText = "Make your choice...";
            gameResultText.Size = new Size(397, 22);
            gameResultText.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 450);
            Controls.Add(gameResultText);
            Controls.Add(buttonReset);
            Controls.Add(pictureNpcChoice);
            Controls.Add(picturePlayerChoice);
            Controls.Add(buttonScissors);
            Controls.Add(buttonPaper);
            Controls.Add(buttonRock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Rock-Paper-Scissors";
            ((System.ComponentModel.ISupportInitialize)picturePlayerChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureNpcChoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRock;
        private Button buttonPaper;
        private Button buttonScissors;
        private PictureBox picturePlayerChoice;
        private PictureBox pictureNpcChoice;
        private Button buttonReset;
        private TextBox gameResultText;
    }
}