string num;
bool num_correct = false;
int int_num;

string[] units = {
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

string[] tens = {
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

Console.WriteLine("Welcome to Number to Words converter!");

do {
    Console.Write("Enter integer number between 0 and 100: ");
    num = Console.ReadLine();
    num_correct = int.TryParse(num, out int_num);

    if (!num_correct || int_num < 0 || int_num > 100)
        Console.WriteLine("The number you've entered is not valid! Please, try again!");
    else {
        string num_str = "";

        if (int_num < 20) {
            num_str = units[int_num];
        } else if (int_num < 100) {
            num_str = tens[((int_num - (int_num % 10)) / 10)] + " " + units[int_num % 10];
        } else if (int_num == 100) {
            num_str = units[int_num / 100] + " Hundred";
        }

        Console.WriteLine("The number \"{0}\" is written with words as \"{1}\"", num, num_str);
    }
} while (!num_correct || int_num < 0 || int_num > 100);
