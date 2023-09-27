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
            numbersInput = new TextBox();
            label2 = new Label();
            sortedOutput = new Label();
            addRandNumBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(273, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter several integer number divided with comma:";
            // 
            // numbersInput
            // 
            numbersInput.Location = new Point(21, 40);
            numbersInput.Name = "numbersInput";
            numbersInput.Size = new Size(334, 23);
            numbersInput.TabIndex = 1;
            numbersInput.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 76);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 2;
            label2.Text = "Sorted numbers are:";
            // 
            // sortedOutput
            // 
            sortedOutput.AutoSize = true;
            sortedOutput.Location = new Point(21, 91);
            sortedOutput.Name = "sortedOutput";
            sortedOutput.Size = new Size(0, 15);
            sortedOutput.TabIndex = 3;
            // 
            // addRandNumBtn
            // 
            addRandNumBtn.Location = new Point(361, 39);
            addRandNumBtn.Name = "addRandNumBtn";
            addRandNumBtn.Size = new Size(140, 24);
            addRandNumBtn.TabIndex = 4;
            addRandNumBtn.Text = "Add random number";
            addRandNumBtn.UseVisualStyleBackColor = true;
            addRandNumBtn.Click += addRandNumBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 168);
            Controls.Add(addRandNumBtn);
            Controls.Add(sortedOutput);
            Controls.Add(label2);
            Controls.Add(numbersInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numbersInput;
        private Label label2;
        private Label sortedOutput;
        private Button addRandNumBtn;
    }
}