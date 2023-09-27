namespace WinForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            bool val_a_correct = int.TryParse(textBox1.Text, out int a);
            bool val_b_correct = int.TryParse(textBox2.Text, out int b);

            if (!val_a_correct) {
                MessageBox.Show("Value for A is not integer!");
            } else if (!val_b_correct) {
                MessageBox.Show("Value for B is not integer!");
            } else {
                label3.Visible = true;
                label3.Text = a.ToString() + "+" + b.ToString() + "=";
                textBox3.Visible = true;
                textBox3.Text = (a + b).ToString();
            }
        }
    }
}