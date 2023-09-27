namespace WinForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string textToShow = textBox1.Text == string.Empty ? "Please, enter your name!" : "Hello, " + textBox1.Text + "!";
            MessageBox.Show(textToShow);
        }
    }
}