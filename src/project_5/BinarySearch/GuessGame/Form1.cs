using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{   
    // Enum for options (low or high)
    enum GuessOption
    {
        High,
        Low,
        Match,
        ErrorGuess
    }

    public partial class Form1 : Form
    {
        // later I will use SQLite. Now I try this as my storage
        private Dictionary<int, GuessOption> GuessTable = new Dictionary<int, GuessOption>();
        private int ComputerGuess = 0;
        private int attempts = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Guess Game";
        }

        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you play?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result) 
            { 
                case DialogResult.Yes:
                    this.StartGame();
                    break;
                case DialogResult.No:
                    break;   
            }

        }

        private void StartGame()
        {
            // create RNG 
            // Store the guess
            Random random = new Random();
            int ComputerGuess = random.Next(1, 101);
            
            // Store it
            this.ComputerGuess = ComputerGuess;
            this.Status.Text = "Active";
        }

        private int CompareGuess(int a, int b)
        {
            return a > b ? 1 : a < b ? -1 : 0;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // user tries to guess
            // write classic binary search
            int UserGuess = int.Parse(this.UserInput.Text);
            
            // compare the guess
            int ComparedResult = this.CompareGuess(this.ComputerGuess, UserGuess);

            // store
            switch (ComparedResult)
            {
                case 1:
                    this.GuessTable.Add(UserGuess, GuessOption.High); break;
                case -1:
                    this.GuessTable.Add(UserGuess, GuessOption.Low); break;
                case 0:
                    this.GuessTable.Add(UserGuess, GuessOption.Match); break;
                default:
                    this.GuessTable.Add(UserGuess, GuessOption.ErrorGuess); break;
            }

            if(ComparedResult == 0)
            {
                DialogResult result = MessageBox.Show("You guessed correctly!\nNow you can reset the game and start over again!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(result == DialogResult.OK)
                {
                    this.Status.Text = "Finished! Start over again!";
                }

            } else
            {
                string hint = ComparedResult == 1 ? "higher" : "lower";
                MessageBox.Show($"Your guess is wrong! Try guessing {hint}.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            // update the log
            this.UpdateDisplay(UserGuess);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you reset the game?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // nothing
            // Did you enjoy this button?
        }

        private void DisplayButton_MouseClick(object sender, MouseEventArgs e)
        {
            // display
        }

        private void Reset()
        {
            this.GuessTable.Clear();
        }

        private void UpdateDisplay(int UserGuess)
        {
            try
            {
                GuessOption result = this.GuessTable[UserGuess];
                this.Results.Text += $"\nattempt {this.attempts}\n\tResult: {result}";
                this.attempts++;
            }catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GiveUpButton_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you give up?", "Confirm Give Up", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Status.Text = "Gave up! Inactive";
                this.ComputerGuessResultValue.Text = $"{this.ComputerGuess}";
                MessageBox.Show($"Computer Guess was {this.ComputerGuess}");
            }
        }

        public int ExampleMethod(int x, int y)
        {
            return x + y;
        }
    }
}
