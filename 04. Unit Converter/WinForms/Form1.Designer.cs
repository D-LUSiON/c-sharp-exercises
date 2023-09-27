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
            label2 = new Label();
            label3 = new Label();
            lengthInMeters = new TextBox();
            lengthInYards = new TextBox();
            lengthInMiles = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Length in meters:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 69);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Length in yards:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 123);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 5;
            label3.Text = "Length in miles:";
            // 
            // lengthInMeters
            // 
            lengthInMeters.Location = new Point(16, 33);
            lengthInMeters.Name = "lengthInMeters";
            lengthInMeters.Size = new Size(221, 23);
            lengthInMeters.TabIndex = 7;
            lengthInMeters.TextAlign = HorizontalAlignment.Right;
            lengthInMeters.KeyUp += lengthInMeters_KeyUp;
            // 
            // lengthInYards
            // 
            lengthInYards.Location = new Point(16, 87);
            lengthInYards.Name = "lengthInYards";
            lengthInYards.Size = new Size(221, 23);
            lengthInYards.TabIndex = 8;
            lengthInYards.TextAlign = HorizontalAlignment.Right;
            lengthInYards.KeyUp += lengthInYards_KeyUp;
            // 
            // lengthInMiles
            // 
            lengthInMiles.Location = new Point(16, 141);
            lengthInMiles.Name = "lengthInMiles";
            lengthInMiles.Size = new Size(221, 23);
            lengthInMiles.TabIndex = 9;
            lengthInMiles.TextAlign = HorizontalAlignment.Right;
            lengthInMiles.KeyUp += lengthInMiles_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 178);
            Controls.Add(lengthInMiles);
            Controls.Add(lengthInYards);
            Controls.Add(lengthInMeters);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unit Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lengthInMeters;
        private TextBox lengthInYards;
        private TextBox lengthInMiles;
    }
}