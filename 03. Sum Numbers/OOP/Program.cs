namespace SumNumbers {
    internal class Program {
        static void Main(string[] args) {
            bool first_number_correct, second_number_correct;
            int first_number, second_number;

            do {
                Console.Write("Enter first number: ");
                string a = Console.ReadLine();
                first_number_correct = int.TryParse(a, out first_number);

                if (!first_number_correct) {
                    Console.WriteLine("The number you entered is incorrect! Please, try again!");
                }
            } while (!first_number_correct);

            do {
                Console.Write("Enter second number: ");
                string a = Console.ReadLine();
                second_number_correct = int.TryParse(a, out second_number);
                if (!second_number_correct) {
                    Console.WriteLine("The number you entered is incorrect! Please, try again!");
                }
            } while (!second_number_correct);

            Console.WriteLine("{0} + {1} = {2}", first_number, second_number, first_number + second_number);
            Console.ReadKey();
        }
    }
}