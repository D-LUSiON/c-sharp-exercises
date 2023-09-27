string numbers;
bool numbers_correct = false;

do {
    Console.Write("Enter 10 integer numbers divided by comma (,): ");
    numbers = Console.ReadLine();

    if (numbers.Length == 0) {
        Console.WriteLine("Please, enter at least one number!");
    } else {
        numbers = numbers.Replace(" ", "");
        string[] numbers_split = numbers.Split(',');
        numbers_correct = numbers_split.Length == 10;

        if (!numbers_correct) {
            Console.WriteLine("Enter EXACTLY 10 integer numbers, please!");
        } else {
            int[] numbers_int = new int[numbers_split.Length];

            for (int i = 0; i < numbers_split.Length; i++) {
                numbers_int[i] = int.Parse(numbers_split[i]);
            }

            Array.Sort(numbers_int);
            Console.WriteLine("Sorted numbers: {0}", string.Join(", ", numbers_int));
        }
    }
} while (numbers.Length == 0 || !numbers_correct);


