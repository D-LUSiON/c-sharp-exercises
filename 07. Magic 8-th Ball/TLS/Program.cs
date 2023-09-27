string[] answers = {
    "It is certain.",
    "It is decidedly so.",
    "Without a doubt.",
    "Yes definitely.",
    "You may rely on it.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
    "Reply hazy, try again.",
    "Ask again later.",
    "Better not tell you now.",
    "Cannot predict now.",
    "Concentrate and ask again.",
    "Don't count on it.",
    "My reply is no.",
    "My sources say no.",
    "Outlook not so good.",
    "Very doubtful.",
};

Console.WriteLine("Think of some question in your mind and then press any key to receive answer to it!");
Console.WriteLine("...waiting for you to press any key...");
Console.ReadKey();

Random random = new Random();
int rand = random.Next(0, answers.Length);

Console.WriteLine(answers[rand]);