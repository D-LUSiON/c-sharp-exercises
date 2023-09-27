namespace NumberToWords {
    internal class Program {
        static void Main(string[] args) {
            NumberToWords converter = new NumberToWords();
        }
    }

    class NumberToWords {
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

        private int min;
        private int max;
        private int number;
        private bool enable_restrictions = false;

        public NumberToWords(int min = 0, int max = 999999999) {
            this.min = min;
            this.max = max;

            ShowGreeting();
            AskForRestrictions();

            do {
                AskForNumber();
                string number_as_words = ConvertToWords(number);

                if (number > 1000000000)
                    Console.WriteLine(number_as_words);
                else
                    Console.WriteLine("The number \"{0}\" is written with words as \"{1}\"", number, number_as_words);
            } while (AskForAnotherNumber());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        public void ShowGreeting() {
            Console.WriteLine("Welcome to Number to Words converter!");
        }

        public void AskForRestrictions() {
            Console.Write("Do you want to restrict how large is the number? (Y/n): ");
            string c = Console.ReadKey(true).Key.ToString().ToLower();
            Console.WriteLine("{0}\n", c == "enter" ? "y" : (c == "escape" ? "n" : c));
            enable_restrictions = c == "y" || c == "enter";
            Console.WriteLine("Restrictions will{0} be enabled!", enable_restrictions ? "" : " NOT");

            if (enable_restrictions) {
                do {
                    bool correct_value = false;
                    do {
                        Console.Write("Enter positive minimum value that is greater than or equals zero: ");
                        correct_value = int.TryParse(Console.ReadLine(), out min);

                        if (!correct_value)
                            Console.WriteLine("You've not entered correct value! Please, try again!");
                    } while (!correct_value);

                    do {
                        Console.Write("Enter maximum value (smaller than or equals 2'147'483'647): ");
                        correct_value = int.TryParse(Console.ReadLine(), out max);

                        if (!correct_value)
                            Console.WriteLine("You've not entered correct value! Please, try again!");
                    } while (!correct_value);

                    if (min >= max)
                        Console.WriteLine("Minimum value SHOUD BE smaller than Maximum value! Please, enter them again!");
                } while (min >= max);
            }
        }

        public void AskForNumber() {
            bool number_correct = false;
            do {
                if (enable_restrictions)
                    Console.Write("Enter number between {0} and {1}: ", min, max);
                else
                    Console.Write("Enter positive number (larger than or equal to zero): ");
                number_correct = int.TryParse(Console.ReadLine(), out number);

                if (!number_correct || !NumberInRange(number))
                    Console.WriteLine("The number you've entered is not valid! Please, try again!");
            } while (!number_correct || !NumberInRange(number));
        }

        private bool NumberInRange(int num) {
            return !enable_restrictions || (num >= min && num <= max);
        }

        public string ConvertToWords(int num) {
            if (num < 20) {
                return units[num];
            }

            if (num < 100) {
                return tens[num / 10] + ((num % 10 > 0) ? " " + ConvertToWords(num % 10) : "");
            }

            if (num < 1000) {
                return units[num / 100] + " Hundred" + ((num % 100 > 0) ? " and " + ConvertToWords(num % 100) : "");
            }

            if (num < 1000000) {
                return ConvertToWords(num / 1000) + " Thousand" + ((num % 1000 > 0) ? " " + ConvertToWords(num % 1000) : "");
            }

            if (num < 1000000000) {
                return ConvertToWords(num / 1000000) + " Million" + ((num % 1000000 > 0) ? " " + ConvertToWords(num % 1000000) : "");
            } else {
                return "One Billion or larger";
            }
        }

        private bool AskForAnotherNumber() {
            Console.Write("Do you want to convert another number? (Y/n): ");
            string c = Console.ReadKey(true).Key.ToString().ToLower();
            Console.WriteLine("{0}\n", c == "enter" ? "y" : (c == "escape" ? "n" : c));
            return c == "y" || c == "enter";
        }
    }
}
