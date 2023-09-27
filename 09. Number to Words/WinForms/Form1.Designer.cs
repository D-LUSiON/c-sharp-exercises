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
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            label1 = new Label();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 12);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.PlaceholderText = "Write an integer number here...";
            inputTextBox.Size = new Size(546, 23);
            inputTextBox.TabIndex = 0;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(12, 77);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(546, 140);
            outputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 2;
            label1.Text = "Your number written with words is:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 231);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(483, 231);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 266);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(label1);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MouseMove += panel1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Label label1;
        private Button clearButton;
        private Button exitButton;
    }
}