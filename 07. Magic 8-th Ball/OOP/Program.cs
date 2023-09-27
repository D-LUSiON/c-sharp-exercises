namespace Magic8thBall {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Think of some question in your mind and then press any key to receive answer to it!");
            Console.WriteLine("...waiting for you to press any key...\n");
            Console.ReadKey();

            Magic8thBall ball = new Magic8thBall();
            string answer = ball.Shake();

            Console.WriteLine("The answer to your question is: {0}\n", answer);
        }
    }

    class Magic8thBall {
        private string[] _answers = {
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

        public string Shake() {
            Random random = new Random();
            int rand = random.Next(0, this._answers.Length);
            return this._answers[rand];
        }
    }
}