namespace WinForms {

    enum GameChoice {
        Rock,
        Paper,
        Scissors,
    }

    enum GameResult {
        Win,
        Loose,
        Draw
    }

    public partial class Form1 : Form {

        private GameChoice player_choice;
        private GameChoice npc_choice;
        private GameResult result;
        public Form1() {
            InitializeComponent();
        }

        private void buttonRock_Click(object sender, EventArgs e) {
            playerChoice(GameChoice.Rock);
            generateNpcChoice();
            calculateResult();
        }

        private void buttonPaper_Click(object sender, EventArgs e) {
            playerChoice(GameChoice.Paper);
            generateNpcChoice();
            calculateResult();
        }

        private void buttonScissors_Click(object sender, EventArgs e) {
            playerChoice(GameChoice.Scissors);
            generateNpcChoice();
            calculateResult();
        }

        private void playerChoice(GameChoice choice) {
            player_choice = choice;

            switch (player_choice) {
                case GameChoice.Rock:
                    picturePlayerChoice.Image = Properties.Resources.rock_l;
                    break;
                case GameChoice.Paper:
                    picturePlayerChoice.Image = Properties.Resources.paper_l;
                    break;
                case GameChoice.Scissors:
                    picturePlayerChoice.Image = Properties.Resources.scissors_l;
                    break;
            }
        }

        private void generateNpcChoice() {
            string[] choices = Enum.GetNames(typeof(GameChoice));
            Random random = new Random();
            int rand_i = random.Next(0, choices.Length);
            npc_choice = Enum.Parse<GameChoice>(choices[rand_i]);

            switch (npc_choice) {
                case GameChoice.Rock:
                    pictureNpcChoice.Image = Properties.Resources.rock_r;
                    break;
                case GameChoice.Paper:
                    pictureNpcChoice.Image = Properties.Resources.paper_r;
                    break;
                case GameChoice.Scissors:
                    pictureNpcChoice.Image = Properties.Resources.scissors_r;
                    break;
            }
        }

        private void calculateResult() {
            if (player_choice == npc_choice)
                showResultText("Game is a draw!", GameResult.Draw);
            else {
                switch (player_choice) {
                    case GameChoice.Rock:
                        switch (npc_choice) {
                            case GameChoice.Paper:
                                showResultText("Paper covers the Rock! You loose!", GameResult.Loose);
                                break;
                            case GameChoice.Scissors:
                                showResultText("Rock crushes the Scissors! You win!", GameResult.Win);
                                break;
                        }
                        break;
                    case GameChoice.Paper:
                        switch (npc_choice) {
                            case GameChoice.Rock:
                                showResultText("Paper covers the Rock! You win!", GameResult.Win);
                                break;
                            case GameChoice.Scissors:
                                showResultText("Scissors cuts the Paper! You loose!", GameResult.Loose);
                                break;
                        }
                        break;
                    case GameChoice.Scissors:
                        switch (npc_choice) {
                            case GameChoice.Rock:
                                showResultText("Rock crushes the Scissors! You loose!", GameResult.Loose);
                                break;
                            case GameChoice.Paper:
                                showResultText("Scissors cuts the Paper! You win!", GameResult.Win);
                                break;
                        }
                        break;
                }
            }

            buttonReset.Visible = true;
            disableButtons();
        }

        private void showResultText(string text, GameResult result) {
            gameResultText.Text = text;
            switch (result) {
                case GameResult.Win:
                    gameResultText.ForeColor = Color.Green;
                    break;
                case GameResult.Loose:
                    gameResultText.ForeColor = Color.Orange;
                    break;
                case GameResult.Draw:
                    gameResultText.ForeColor = Color.Black;
                    break;
            }
        }

        private void disableButtons() {
            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;
        }

        private void resetGame(object sender, EventArgs e) {
            player_choice = default(GameChoice);
            picturePlayerChoice.Image = null;
            npc_choice = default(GameChoice);
            pictureNpcChoice.Image = null;
            buttonReset.Visible = false;
            gameResultText.Text = string.Empty;
            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;
        }
    }
}