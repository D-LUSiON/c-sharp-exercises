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
            shakeBtn = new Button();
            shakeProgress = new ProgressBar();
            shakeText = new TextBox();
            SuspendLayout();
            // 
            // shakeBtn
            // 
            shakeBtn.BackgroundImage = Properties.Resources._8_th_ball_icon;
            shakeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            shakeBtn.Location = new Point(250, 112);
            shakeBtn.Name = "shakeBtn";
            shakeBtn.Size = new Size(140, 140);
            shakeBtn.TabIndex = 0;
            shakeBtn.UseVisualStyleBackColor = true;
            shakeBtn.Click += button1_Click;
            // 
            // shakeProgress
            // 
            shakeProgress.Location = new Point(100, 308);
            shakeProgress.Name = "shakeProgress";
            shakeProgress.Size = new Size(440, 6);
            shakeProgress.TabIndex = 2;
            shakeProgress.Visible = false;
            // 
            // shakeText
            // 
            shakeText.BackColor = SystemColors.ButtonFace;
            shakeText.BorderStyle = BorderStyle.None;
            shakeText.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            shakeText.Location = new Point(12, 266);
            shakeText.Name = "shakeText";
            shakeText.Size = new Size(600, 33);
            shakeText.TabIndex = 3;
            shakeText.Text = "Think of a question and click the ball!";
            shakeText.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(shakeText);
            Controls.Add(shakeProgress);
            Controls.Add(shakeBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Magic 8-th Ball";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button shakeBtn;
        private ProgressBar shakeProgress;
        private TextBox textBox1;
        private TextBox shakeText;
    }
}