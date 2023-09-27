using System;
using System.Runtime.InteropServices;

namespace WinForms {
    public partial class Form1 : Form {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private string[] units = {
            "Zero",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen",
            "Fourteen",
            "Fifteen",
            "Sixteen",
            "Seventeen",
            "Eighteen",
            "Nineteen",
        };

        private string[] tens = {
            "",
            "",
            "Twenty",
            "Thirty",
            "Forty",
            "Fifty",
            "Sixty",
            "Seventy",
            "Eighty",
            "Ninety",
        };

        public Form1() {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e) {
            if (inputTextBox.Text == string.Empty) {
                outputTextBox.Text = string.Empty;
            } else {
                bool isNumber = Int64.TryParse(inputTextBox.Text, out Int64 value);
                if (!isNumber) {
                    outputTextBox.Text = "Error converting integer to words! Please, enter ONLY digits!";
                } else {
                    outputTextBox.Text = intToWords(value);
                }
            }
        }

        private string intToWords(Int64 value) {
            if (value < 20) {
                return units[value];
            }

            if (value < 100) {
                return tens[value / 10] + ((value % 10 > 0) ? " " + intToWords(value % 10) : "");
            }

            if (value < 1000) {
                return units[value / 100] + " Hundred" + ((value % 100 > 0) ? " and " + intToWords(value % 100) : "");
            }

            if (value < 1000000) {
                return intToWords(value / 1000) + " Thousand" + ((value % 1000 > 0) ? " " + intToWords(value % 1000) : "");
            }

            if (value < 1000000000) {
                return intToWords(value / 1000000) + " Million" + ((value % 1000000 > 0) ? " " + intToWords(value % 1000000) : "");
            } else {
                return "One Billion or larger";
            }
        }
    }
}