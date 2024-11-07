using PaperScissorRockGame.Session;

namespace PaperScissorRockGame
{
    public partial class Form1 : Form
    {
        public string ExplanationText = "The game that you are going to play is called `Paper Scissors Rock`.\n" +
            "You play against the Computer. You have to choose:\n" +
            "\t1 - Rock,\n" +
            "\t2 - Paper,\n" +
            "\t3 - Scissors.\n" +
            "Once you submit your choice, the application declares the winner, and you can start over again.";

        private UserController _userController;
        private UserSession _userSession;
        private GameOptions _computerChoice;
        private GameResult _gameResult;
        private Form2 _form2;

        public Form1()
        {
            InitializeComponent();
            _userController = UserFactory.CreateUserController();
            _userSession = new UserSession();

            Form2 form2 = new Form2(_userSession);
            this._form2 = form2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Paper Scissor Rock Game";
            this.Explanation.Text = this.ExplanationText;
            this.AuthorizeUser();
            this.RegisterComputerChoice();
        }

        public void ShowTestSamples()
        {
            int[] results = new int[100];
            for (int i = 0; i < results.Length; i++)
            {
                int ComputerNumberGenerated = this.GetComputerChoice();
                results[i] = ComputerNumberGenerated;
            }

            MessageBox.Show(string.Join(", ", results));
        }

        private int GetComputerChoice()
        {
            Random random = new Random();
            return (int)random.Next(1, 4);
        }

        private void RegisterComputerChoice()
        {
            int computerChoice = this.GetComputerChoice();

            switch (computerChoice)
            {
                case 1:
                    this._computerChoice = GameOptions.Rock;
                    break;
                case 2:
                    this._computerChoice = GameOptions.Paper;
                    break;
                case 3:
                    this._computerChoice = GameOptions.Scissors;
                    break;
                default:
                    this._computerChoice = GameOptions.NotChoosen;
                    break;
            }
        }

        private string GetComputerChoiceAsString()
        {
            return this._computerChoice.ToString();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Action: Exit", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Exit Canceled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            this._userSession.user.UserOption = GameOptions.Rock;
            this.ChoosenItemValue.Text = GameOptions.Rock.ToString();
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            this._userSession.user.UserOption = GameOptions.Paper;
            this.ChoosenItemValue.Text = GameOptions.Paper.ToString();
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            this._userSession.user.UserOption = GameOptions.Scissors;
            this.ChoosenItemValue.Text = GameOptions.Scissors.ToString();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this._userSession.user.UserOption = GameOptions.NotChoosen;
            this.RegisterComputerChoice();
            this.ChoosenItemValue.Text = GameOptions.NotChoosen.ToString();
        }

        private void AuthorizeUser()
        {
            this._form2.ShowDialog();

            // update the user name 
            // Guest | User
            this.UserNameValue.Text = this._userSession.user.Name;
        }

        private void DeclareWinner()
        {
            User user = this._userSession.user;
    
            if (user.UserOption == this._computerChoice)
            {
                this._gameResult = GameResult.Draw;
                user.Draws++;
            }
            else if (
             (user.UserOption == GameOptions.Rock && this._computerChoice == GameOptions.Scissors) ||
             (user.UserOption == GameOptions.Paper && this._computerChoice == GameOptions.Rock) ||
             (user.UserOption == GameOptions.Scissors && this._computerChoice == GameOptions.Paper))
            {
                // User won
                this._gameResult = GameResult.Win;
                user.Wins++;
            }
            else
            {
                this._gameResult = GameResult.Loss;
                user.Losses++;
            }
        }

        private void ConfirmResult_Click(object sender, EventArgs e)
        {
            User user = this._userSession.user;

            this.DeclareWinner();
            MessageBox.Show($"The game result: {this._gameResult}");
            this._userController.RecordGameResult(user.Id, user.UserOption, this._computerChoice, this._gameResult);
            this._userController.RecordUserResult(user);
        }

        private void ShowStatistics_MouseClick(object sender, MouseEventArgs e)
        {
            User user = this._userController.FindUserByName(this._userSession.user.Name!);
            History history = new History(user);
            history.Show();
        }
    }
}
