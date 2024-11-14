using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class Results : Form
    {
        private List<Question> questions;

        public Results(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void LeaveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to leave?", "Confirm leaving", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void Results_Load(object sender, EventArgs e)
        {
            foreach (Question question in questions)
            {
                this.ResultsExplanation.Text += $"Question: {question.Title}\n\t\tYour choice was {question.UserAnswer}\n\t\tCorrect Answer was {question.CorrectAnswer}\n";
            }
        }
    }
}
