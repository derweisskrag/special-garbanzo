using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PaperScissorRockGame.Entities;
using PaperScissorRockGame.Session;

namespace PaperScissorRockGame
{
    public partial class Form2 : Form
    {
        public string ExplainAuthorization = "Welcome the Paper Scissor Rock game!\n\nThis form asks for your name! Please," +
            "notice that it does NOT request your password or any credential information.\n\n" +
            "As such, please, refrain from providing any sensitive or personal information." +
            "Your task is to provide `username` or `your name`. " +
            "\n\n\n\tDo NOT provide card numbers, passwords or any confidential information.";

        private UserController _userController;
        public UserSession _userSession;

        public Form2(UserSession session)
        {
            InitializeComponent();
            _userController = UserFactory.CreateUserController();
            this._userSession = session;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Authorization";
            this.ExplanationAuth.Text = this.ExplainAuthorization;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            // get the data 
            // Validate the data
            // store in SQLite table
            string UserName = this.NameInput.Text;

            if (!string.IsNullOrEmpty(UserName) && UserName != "Guest")
            {
                // If exists does not recreate 
                // If doesnt exist, create new and defines Name 
                // User does NOT have any records right now
                User SignedInUser = this._userController.SignIn(UserName);
                this._userSession.SignIn(SignedInUser);
                MessageBox.Show($"{SignedInUser.Name} just signed in!");
                this.Close();
            }
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
    }
}
