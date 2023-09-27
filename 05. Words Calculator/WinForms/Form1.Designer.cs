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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            paragraphsNum = new Label();
            sentencesNum = new Label();
            wordsNum = new Label();
            label5 = new Label();
            charsCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter some text:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(483, 191);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 234);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of paragraphs:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 3;
            label3.Text = "Number of sentences:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 284);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 4;
            label4.Text = "Number of words:";
            // 
            // paragraphsNum
            // 
            paragraphsNum.AutoSize = true;
            paragraphsNum.Location = new Point(148, 234);
            paragraphsNum.Name = "paragraphsNum";
            paragraphsNum.Size = new Size(13, 15);
            paragraphsNum.TabIndex = 5;
            paragraphsNum.Text = "0";
            // 
            // sentencesNum
            // 
            sentencesNum.AutoSize = true;
            sentencesNum.Location = new Point(148, 259);
            sentencesNum.Name = "sentencesNum";
            sentencesNum.Size = new Size(13, 15);
            sentencesNum.TabIndex = 6;
            sentencesNum.Text = "0";
            // 
            // wordsNum
            // 
            wordsNum.AutoSize = true;
            wordsNum.Location = new Point(148, 284);
            wordsNum.Name = "wordsNum";
            wordsNum.Size = new Size(13, 15);
            wordsNum.TabIndex = 7;
            wordsNum.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 309);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 8;
            label5.Text = "Total characters count:";
            // 
            // charsCount
            // 
            charsCount.AutoSize = true;
            charsCount.Location = new Point(148, 309);
            charsCount.Name = "charsCount";
            charsCount.Size = new Size(13, 15);
            charsCount.TabIndex = 10;
            charsCount.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 336);
            Controls.Add(charsCount);
            Controls.Add(label5);
            Controls.Add(wordsNum);
            Controls.Add(sentencesNum);
            Controls.Add(paragraphsNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Words calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label paragraphsNum;
        private Label sentencesNum;
        private Label wordsNum;
        private Label label5;
        private Label charsCount;
    }
}