using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperScissorRockGame
{
    public partial class History : Form
    {
        private User user;


        public History(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
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

        private void History_Load(object sender, EventArgs e)
        {
            // fetch all the data
            this.Description.Text = $"Welcome to the History tab, {user.Name}!\n\n" +
                $"\tYour Wins: {user.Wins}\n" +
                $"\tYour Losses: {user.Losses}\n" +
                $"\tYour Draws: {user.Draws}\n\n";
        }
    }
}
