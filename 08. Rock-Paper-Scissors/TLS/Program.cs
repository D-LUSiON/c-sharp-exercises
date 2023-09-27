char[] choices = { 'R', 'P', 'S' };

Console.WriteLine("------------------------------");
Console.WriteLine("-- Rock-Paper-Scissors Game --");
Console.WriteLine("------------------------------\n");

Console.Write("Enter (R) for Rock, (P) for Paper or (S) for Scissors: ");
char user_choice = char.ToUpper(Console.ReadKey(true).KeyChar);

Console.WriteLine("\nYour choice is: {0}", user_choice);

Random random = new Random();
char pc_choice = choices[random.Next(0, choices.Length)];

Console.WriteLine("PC opponent choice is: {0}", pc_choice);

if (user_choice == pc_choice) {
    Console.WriteLine("You both choose the same! Game is a tie!");
} else if (user_choice == 'R' &&  pc_choice == 'P') {
    Console.WriteLine("You have lost! Paper covers Rock!");
} else if (user_choice == 'R' && pc_choice == 'S') {
    Console.WriteLine("You have won! Rock crushes Scissors!");
} else if (user_choice == 'P' && pc_choice == 'R') {
    Console.WriteLine("You have won! Paper covers Rock!");
} else if (user_choice == 'P' && pc_choice == 'S') {
    Console.WriteLine("You have lost! Scissors cuts Paper!");
} else if (user_choice == 'S' && pc_choice == 'R') {
    Console.WriteLine("You have lost! Rock crushes Scissors!");
} else if (user_choice == 'S' && pc_choice == 'P') {
    Console.WriteLine("You have won! Scissors cuts Paper!");
}