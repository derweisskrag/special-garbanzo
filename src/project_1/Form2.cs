using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Explanation : Form
    {
        public Explanation()
        {
            InitializeComponent();
        }

        private void Explanation_Load(object sender, EventArgs e)
        {
            this.loadResources();
        }

        private void loadResources()
        {
            string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Data");
            string explanationPath = Path.Combine(dataPath, "Questions");

            try
            {
                // define paths
                string pathQuestions = Path.Combine(dataPath, "Questions.csv");
                string pathAnswers = Path.Combine(dataPath, "CorrectAnswers.csv");
                string pathUserAnswers = Path.Combine(dataPath, "answers.csv");
                string pathQuestion1Explanation = Path.Combine(explanationPath, "Question1/explanation.txt");
                string pathQuestion2Explanation = Path.Combine(explanationPath, "Question2/explanation.txt");
                string pathQuestion3Explanation = Path.Combine(explanationPath, "Question3/explanation.txt");

                // read data
                string[] questions = File.ReadAllLines(pathQuestions);
                string[] answers = File.ReadAllLines(pathAnswers);
                string[] usersAnswers = File.ReadAllLines(pathUserAnswers);

                string[] Question1Explanation = File.ReadAllLines(pathQuestion1Explanation);
                string[] Question2Explanation = File.ReadAllLines(pathQuestion2Explanation);
                string[] Question3Explanation = File.ReadAllLines(pathQuestion3Explanation);

                // load user
                var user = usersAnswers[0];
                this.User.Text += user == "" ? user.Split(',')[1] : "Guest";
                this.CompletedAt.Text += DateTime.Now;

                // fill the content
                this.Question1Content.Text = questions[0];
                this.Question2Content.Text = questions[1];
                this.Question3Content.Text = questions[2];

               

                // handle the explanation texts
                List<string[]> explanations = new List<string[]>();

                explanations.Add(Question1Explanation);
                explanations.Add(Question2Explanation);
                explanations.Add(Question3Explanation);


                this.loadExplanation(explanations);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't find the resources: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeaveHandler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Leave?", "Confirm Leave", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else if (result == DialogResult.Cancel) {
                MessageBox.Show("Canceled Leave");
            }
        }

        private void loadExplanation(List<string[]> explanations)
        {
            using (var explanationsEnumerator = explanations.GetEnumerator())
            {
                int index = 1;

                while (explanationsEnumerator.MoveNext())
                {
                    foreach (var line in explanationsEnumerator.Current) {
                        switch (index)
                        {
                            case 1:
                                this.AddLineToLabel(this.Explanation1, line);
                                break;
                            case 2:
                                this.AddLineToLabel(this.Explanation2, line);
                                break;
                            case 3:
                                this.AddLineToLabel(this.Explanation3, line); 
                                break;
                            default:
                                break;
                        }
                    }

                    index++;
                }
            }
        }

        private void AddLineToLabel(Label label, string line)
        {
            label.Text += line + Environment.NewLine;
        }
    }
}
