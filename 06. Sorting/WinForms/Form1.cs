using System.Text.RegularExpressions;

namespace WinForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            string clean_input = Regex.Replace(numbersInput.Text, @"[\n\s]+", string.Empty);
            if (clean_input.Length == 0) {
                showMessage(string.Empty, false);
            } else if (Regex.Count(clean_input, @"[^0-9\, ]") > 0) {
                showMessage("Please, enter only numbers divided by comma!", true);
            } else {
                List<int> numbers = convertInputToList(clean_input);
                numbers = bubbleSortList(numbers);
                
                showMessage(String.Join(", ", numbers.ToArray()), false);
            }
        }

        private void showMessage(string message, bool isError) {
            sortedOutput.ForeColor = isError ? Color.Red : Color.Black;
            sortedOutput.Text = message;
        }

        private List<int> convertInputToList(string input) {
            List<int> numbers = new List<int>();
            input.Split(',').ToList<string>().ForEach(num => {
                int.TryParse(num, out int a);
                numbers.Add(a);
            });
            return numbers;
        }

        private List<int> bubbleSortList(List<int> input) {
            for (int i = 0; i < input.Count - 2; i++) {
                for (int j = 1; j < input.Count - 1; j++) {
                    if (input[i] > input[j]) {
                        int a = input[j];
                        input[j] = input[i];
                        input[i] = a;
                    }
                }
            }
            return input;
        }

        private void addRandNumBtn_Click(object sender, EventArgs e) {
            Random random = new Random();
            int randomNum = random.Next(0, 9999);
            string input = numbersInput.Text;

            input += (input.Length == 0 ? "" : ",") + randomNum.ToString();

            numbersInput.Text = input;
        }
    }
}