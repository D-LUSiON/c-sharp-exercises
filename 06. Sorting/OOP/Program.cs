namespace Sorting {
    internal class Program {
        static void Main(string[] args) {
            int numbers_count = 10;
            char[] delimiter = { ',', ' ', '\n', '\t' };

            string numbers;
            bool numbers_correct_count = false;

            do {
                Console.Write("Enter {0} integer numbers divided by comma (,): ", numbers_count);
                numbers = Console.ReadLine();

                if (numbers.IndexOf('.') > -1) {
                    Console.WriteLine("Please, enter only INTEGER numbers!");
                } else {
                    numbers = numbers.Replace(" ", "");

                    string[] number_split = numbers.Split(delimiter);

                    numbers_correct_count = number_split.Length == numbers_count;

                    if (!numbers_correct_count) {
                        Console.WriteLine("You've entered {0} numbers. Please, enter EXACTLY {1} numbers!", numbers.Length, numbers_count);
                    } else {
                        int[] integers = Array.ConvertAll(number_split, number => int.Parse(number));
                        
                        for (int i = 0; i < integers.Length - 1; i++) {
                            for (int j = i + 1; j < integers.Length; j++) {
                                if (integers[i] > integers[j]) {
                                    int tmp = integers[i];
                                    integers[i] = integers[j];
                                    integers[j] = tmp;
                                }
                            }
                        }

                        Console.WriteLine("Sorted numbers: {0}", string.Join(' ', integers));
                    }
                }


            } while (numbers.Length == 0 || !numbers_correct_count);
        }
    }
}