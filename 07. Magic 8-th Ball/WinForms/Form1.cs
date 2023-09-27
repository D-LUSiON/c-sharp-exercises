namespace WinForms {
    public partial class Form1 : Form {

        private readonly string[] _shakeTexts = { "Think of a question and click the ball!", "Shaking...", "Done!" };

        private readonly string[] _answers = {
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
        public Form1() {
            InitializeComponent();
        }

        private void reset() {
            shakeProgress.Value = 0;
            shakeProgress.Visible = false;
            shakeText.Text = _shakeTexts[0];
            Form1.ActiveForm.Cursor = Cursors.Default;
        }

        private async void button1_Click(object sender, EventArgs e) {
            string answer = shake();
            showAnswer(answer);
        }

        private string shake() {
            shakeText.Text = _shakeTexts[1];
            int i = 0;
            setProgressPercent(i);
            while (i < 100) {
                Thread.Sleep(100);
                i += 10;
                setProgressPercent(i);
            }
            shakeText.Text = _shakeTexts[2];
            return generateAnswer();
        }

        private void setProgressPercent(int percent = 0) {
            if (!shakeProgress.Visible)
                shakeProgress.Visible = true;
            shakeProgress.Value = percent;
        }

        private string generateAnswer() {
            Random random = new Random();
            int rand = random.Next(0, _answers.Length);
            return _answers[rand];
        }

        private void showAnswer(string answer) {
            MessageBox.Show(answer, "Answer to your question is:");
            reset();
        }
    }
}