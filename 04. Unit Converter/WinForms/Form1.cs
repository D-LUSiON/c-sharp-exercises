using System.Diagnostics.Metrics;

namespace WinForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void lengthInMeters_KeyUp(object sender, KeyEventArgs e) {
            if (lengthInMeters.Text != string.Empty) {
                bool meters_correct = float.TryParse(lengthInMeters.Text, out float meters);

                if (!meters_correct)
                    MessageBox.Show("Please, enter correct value!");
                else {
                    lengthInYards.Text = (meters * 1.0936133).ToString();
                    lengthInMiles.Text = (meters * 0.000621371192).ToString();
                }
            } else {
                lengthInYards.Text = string.Empty;
                lengthInMiles.Text = string.Empty;
            }
        }

        private void lengthInYards_KeyUp(object sender, KeyEventArgs e) {
            if (lengthInYards.Text != string.Empty) {
                bool yards_correct = float.TryParse(lengthInYards.Text, out float yards);

                if (!yards_correct)
                    MessageBox.Show("Please, enter correct value!");
                else {
                    lengthInMeters.Text = (yards * 0.9144).ToString();
                    lengthInMiles.Text = (yards * 0.000568181818).ToString();
                }
            } else {
                lengthInMeters.Text = string.Empty;
                lengthInMiles.Text= string.Empty;
            }
        }

        private void lengthInMiles_KeyUp(object sender, KeyEventArgs e) {
            if (lengthInMiles.Text != string.Empty) {
                bool miles_correct = float.TryParse(lengthInMiles.Text, out float miles);

                if (!miles_correct)
                    MessageBox.Show("Please, enter correct value!");
                else {
                    lengthInMeters.Text = (miles * 1609.344).ToString();
                    lengthInYards.Text = (miles * 1760).ToString();
                }
            } else {
                lengthInMeters.Text= string.Empty;
                lengthInYards.Text= string.Empty;
            }
        }
    }
}