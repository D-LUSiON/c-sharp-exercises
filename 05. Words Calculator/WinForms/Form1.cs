using System.Text.RegularExpressions;

namespace WinForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (textBox1.Text == string.Empty) {
                paragraphsNum.Text = 0.ToString();
                sentencesNum.Text = 0.ToString();
                wordsNum.Text = 0.ToString();
                charsCount.Text = 0.ToString();
            } else {
                paragraphsNum.Text = Regex.Replace(textBox1.Text, @"(\n\s?){2,}", "\n").Split("\n").Length.ToString();
                sentencesNum.Text = textBox1.Text.Replace("\n", string.Empty).Split(".").Length.ToString();
                wordsNum.Text = textBox1.Text.Replace("[^a-zA-Z0-9]+", string.Empty).Split(" ").Length.ToString();
                charsCount.Text = textBox1.Text.Length.ToString();
            }
        }
    }
}