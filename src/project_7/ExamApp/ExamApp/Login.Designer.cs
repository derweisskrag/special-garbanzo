namespace ExamApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.Explanation = new System.Windows.Forms.RichTextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.ResetBtn);
            this.LoginBox.Controls.Add(this.SignInBtn);
            this.LoginBox.Controls.Add(this.PasswordInput);
            this.LoginBox.Controls.Add(this.LoginInput);
            this.LoginBox.Controls.Add(this.PasswordLabel);
            this.LoginBox.Controls.Add(this.LoginLabel);
            this.LoginBox.Location = new System.Drawing.Point(12, 23);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(252, 217);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login Form";
            // 
            // Explanation
            // 
            this.Explanation.Location = new System.Drawing.Point(514, 23);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(274, 394);
            this.Explanation.TabIndex = 1;
            this.Explanation.Text = "";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(18, 68);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(54, 13);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Your login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(21, 112);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(77, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Your password";
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(129, 68);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(100, 20);
            this.LoginInput.TabIndex = 2;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(129, 112);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 20);
            this.PasswordInput.TabIndex = 3;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(141, 159);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(24, 158);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(33, 393);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Leave";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.LoginBox);
            this.Name = "Login";
            this.Text = "Login";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.RichTextBox Explanation;
        private System.Windows.Forms.Button ExitBtn;
    }
}