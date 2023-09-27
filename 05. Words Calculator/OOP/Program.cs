namespace OOP {
    internal class Program {
        static void Main(string[] args) {
            char[] delimiter = {' ', ',', '.', '-', '\t', '\n', ':', ';', '(', ')', '{', '}', '[', ']', '\'', '\"'};
            string sentence;

            do {
                Console.Write("Enter some long sentence: ");
                sentence = Console.ReadLine();

                if (sentence == null || sentence == "") {
                    Console.WriteLine("You didn't enter any text! Please, try again!");
                } else {
                    string[] sentence_split = sentence.Split(delimiter);
                    Console.WriteLine("The sentence you've entered contains {0} words.", sentence_split.Length);
                    Console.ReadKey();
                }
            } while (sentence == null || sentence == "");
        }
    }
}