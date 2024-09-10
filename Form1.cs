using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += Timer1_Tick;

            // Setting the name of user
            NameBox.TextChanged += NameBox_TextChanged;
        }

        private void ExitHandlerClick(object sender, EventArgs e)
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
            } catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UserName.Text = NameBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't set the name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            timer1.Start();

            // start the game
            this.InitializeTheGame();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Move the button upwards
            if (StartGame.Location.Y > 0)
            {
                StartGame.Location = new Point(StartGame.Location.X, StartGame.Location.Y - 5);
            }
            else
            {
                timer1.Stop(); // Stop the timer once the button reaches the top
            }
        }

        private void InitializeTheGame()
        {
            // prepare the board
            this.displayQuestions();
        }

        private void displayQuestions()
        {
            // Display questions
            Question1.Visible = true;
            Question2.Visible = true;
            Question3.Visible = true;


            Question1Content.Visible = true;
            Question2Content.Visible = true;
            Question3Content.Visible = true;

            Question3AnswerOptions.Visible = true;

            // Display the answers
            Answer1.Visible = true;
            Answer2.Visible = true;
            ChoosenAnswer.Visible = true;

            // Display Question 1 and Question 2 answers
            Question1ChoosenAnswer.Visible = true;
            Question2ChoosenAnswer.Visible = true;

            // Display the submit
            SubmitHandler.Visible = true;
        }

        private void SubmitHandler_Click(object sender, EventArgs e)
        {
            // we should save the information typed
            string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Data");

            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }

            string filePath = Path.Combine(dataDirectory, "answers.csv");

            // Prepare the CSV
            string[] csvContent =
            {
                $"UserName,{this.NameBox.Text}",
                "Question,Answer",
                $"{this.Question1Content.Text},{this.Question1ChoosenAnswer.Text}",
                $"{this.Question2Content.Text},{this.Question2ChoosenAnswer.Text}",
                $"{this.Question3Content.Text},{this.ChoosenAnswer.Text}"
            };

            // Write the CSV content to file
            File.WriteAllLines(filePath, csvContent);

            MessageBox.Show("Your answers have been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        }


        private void Question3AnswerOptions_Click(object sender, EventArgs e)
        {
            this.ChoosenAnswer.Text = Question3AnswerOptions.Text;
        }

        private void CheckHandler_Click(object sender, EventArgs e)
        {
            // Check the results

            // Path to the Data directory
            string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Data");

            // Paths to the CSV files
            string answersFilePath = Path.Combine(dataDirectory, "answers.csv");
            string correctAnswersFilePath = Path.Combine(dataDirectory, "CorrectAnswers.csv");

            // Read the answers from the CSV files
            string[] userAnswers = File.ReadAllLines(answersFilePath);
            string[] correctAnswers = File.ReadAllLines(correctAnswersFilePath);

            // Grab answers using enumerator
            var userAnswerEnumerator = userAnswers.Skip(2).Select(line => line.Split(',')[1].Trim());

            // Compare the answers
            List<string> results = new List<string>();

            using (var userEnumerator = userAnswerEnumerator.GetEnumerator())
            using (var correctEnumetor = correctAnswers.Select(line => line).GetEnumerator())
            {
                while (userEnumerator.MoveNext() && correctEnumetor.MoveNext())
                {
                    if (userEnumerator.Current == correctEnumetor.Current)
                    {
                        results.Add($"Correct!");
                    }
                    else
                    {
                        results.Add($"Incorrect! (Your answer: {userEnumerator.Current}, Correct answer: {correctEnumetor.Current})");
                    }
                }
            }

            // Display the results
            this.displayResults(results);

            // clean up
            this.cleanUp();

        }

        private void displayResults(List<string> results)
        {
            if (results == null)
            {
                throw new System.ArgumentNullException(nameof(results), "The result cannot be null!");
            }

            int countCorrectAnswers = results.Count(result => result == "Correct!");
            int countWrongAnswers = countCorrectAnswers > 0 ? results.Count() - countCorrectAnswers : results.Count();

            try
            {

                DialogResult dialogResult = MessageBox.Show($"You have {countCorrectAnswers} correct answers! " +
                    $"{(countWrongAnswers > 0 ? $"You answered wrong answers: {countWrongAnswers}" : "No wrong answers!")}", 
                    "See explanation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        Explanation form2 = new Explanation();
                        form2.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Couldn't show the explanation due to an error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't log results due to an error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanUp()
        {
            this.UserName.Text = "";
            this.Question1ChoosenAnswer.Text = "";
            this.Question2ChoosenAnswer.Text = "";
            this.ChoosenAnswer.Text = "";
        }

        private void ConfirmAnswers_MouseHover(object sender, EventArgs e)
        {
            this.ConfirmAnswersBtnDesc.Visible = true;
        }

        private void ConfirmAnswers_MouseLeave(object sender, EventArgs e)
        {
            this.ConfirmAnswersBtnDesc.Visible = false;
        }

        private void ConfirmAnswers_Click(object sender, EventArgs e)
        {
            this.Question1ChoosenAnswer.Text = Answer1.Text;
            this.Question2ChoosenAnswer.Text = Answer2.Text;
            // TODO: Implement state
            // this.updateProgressBar();
        }

        private void updateProgressBar()
        {
            throw new NotImplementedException();
        }
    }
}
