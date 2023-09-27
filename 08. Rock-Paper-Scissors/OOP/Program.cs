namespace RockPaperScissorsGame {
    internal class Program {
        static void Main(string[] args) {
            bool continueGame = true;

            while (continueGame) {
                Game game = new Game();

                Console.WriteLine("Do you want another game? (Y/n)");
                string c = Console.ReadKey().KeyChar.ToString().ToUpper();

                if (c == "N")
                    continueGame = false;

            }
            
        }
    }

    enum choices {
        Rock = 'R',
        Paper = 'P',
        Scissors = 'S',
    }

    class Game {

        private string _user_choice;
        private string _pc_choice;

        public Game() {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("-- Rock-Paper-Scissors Game --");
            Console.WriteLine("------------------------------\n");

            this.GetPCChoice();
            this.GetUserChoice();
            this.CompareChoices();
        }

        private void GetPCChoice() {
            Random random = new Random();
            string[] choises_names = Enum.GetNames(typeof(choices));
            int rnd_int = random.Next(0, choises_names.Length);
            this._pc_choice = choises_names[rnd_int];
        }

        private void GetUserChoice() {
            Console.Write("Enter (R) for Rock, (P) for Paper or (S) for Scissors: ");
            char user_choice = char.ToUpper(Console.ReadKey(true).KeyChar);
            this._user_choice = ((choices)user_choice).ToString();
        }

        void CompareChoices() {
            Console.WriteLine("\nYou choose {0}", this._user_choice);
            Console.WriteLine("PC opponent choose: {0}", this._pc_choice);

            if (this._user_choice == this._pc_choice) {
                Console.WriteLine("You both choose the same! Game is a tie!");
            } else if (this._user_choice == "Rock" && this._pc_choice == "Paper") {
                Console.WriteLine("You have lost! Paper covers Rock!");
            } else if (this._user_choice == "Rock" && this._pc_choice == "Scissors") {
                Console.WriteLine("You have won! Rock crushes Scissors!");
            } else if (this._user_choice == "Paper" && this._pc_choice == "Rock") {
                Console.WriteLine("You have won! Paper covers Rock!");
            } else if (this._user_choice == "Paper" && this._pc_choice == "Scissors") {
                Console.WriteLine("You have lost! Scissors cuts Paper!");
            } else if (this._user_choice == "Scissors" && this._pc_choice == "Rock") {
                Console.WriteLine("You have lost! Rock crushes Scissors!");
            } else if (this._user_choice == "Scissors" && this._pc_choice == "Paper") {
                Console.WriteLine("You have won! Scissors cuts Paper!");
            }

        }




    }
}