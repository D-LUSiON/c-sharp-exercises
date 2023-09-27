namespace OOP {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}! Nice to meet you!", name);
            Console.ReadKey();
        }
    }
}