namespace UnitConverter {
    internal class Program {
        static void Main(string[] args) {
            int meters;
            bool meters_correct;

            do {
                Console.Write("Enter length in meters: ");
                string a = Console.ReadLine();
                meters_correct = int.TryParse(a, out meters);

                if (!meters_correct) {
                    Console.WriteLine("You've entered wrong value! Try again!");
                } else {
                    Console.WriteLine("{0} meter(s) equals {1} yards or {2} miles.", meters, meters * 1.0936133, meters * 0.000621371192);
                    Console.ReadKey();
                }
            } while (!meters_correct);
        }
    }
}