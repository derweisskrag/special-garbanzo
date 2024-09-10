namespace WindowsFormsApp1
{
    partial class Explanation
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
            this.Question1 = new System.Windows.Forms.Label();
            this.Question1Content = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.Question2Content = new System.Windows.Forms.Label();
            this.Question3Content = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.Label();
            this.LeaveHandler = new System.Windows.Forms.Button();
            this.Explanation1 = new System.Windows.Forms.Label();
            this.Explanation2 = new System.Windows.Forms.Label();
            this.Explanation3 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.CompletedAt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Location = new System.Drawing.Point(13, 13);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(58, 13);
            this.Question1.TabIndex = 0;
            this.Question1.Text = "Question 1";
            // 
            // Question1Content
            // 
            this.Question1Content.AutoSize = true;
            this.Question1Content.Location = new System.Drawing.Point(13, 39);
            this.Question1Content.Name = "Question1Content";
            this.Question1Content.Size = new System.Drawing.Size(0, 13);
            this.Question1Content.TabIndex = 2;
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Location = new System.Drawing.Point(319, 13);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(58, 13);
            this.Question2.TabIndex = 3;
            this.Question2.Text = "Question 2";
            // 
            // Question2Content
            // 
            this.Question2Content.AutoSize = true;
            this.Question2Content.Location = new System.Drawing.Point(322, 39);
            this.Question2Content.Name = "Question2Content";
            this.Question2Content.Size = new System.Drawing.Size(0, 13);
            this.Question2Content.TabIndex = 5;
            // 
            // Question3Content
            // 
            this.Question3Content.AllowDrop = true;
            this.Question3Content.AutoEllipsis = true;
            this.Question3Content.AutoSize = true;
            this.Question3Content.ForeColor = System.Drawing.Color.DarkCyan;
            this.Question3Content.Location = new System.Drawing.Point(590, 39);
            this.Question3Content.Name = "Question3Content";
            this.Question3Content.Size = new System.Drawing.Size(0, 13);
            this.Question3Content.TabIndex = 8;
            // 
            // Question3
            // 
            this.Question3.AutoSize = true;
            this.Question3.Location = new System.Drawing.Point(587, 13);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(58, 13);
            this.Question3.TabIndex = 6;
            this.Question3.Text = "Question 3";
            // 
            // LeaveHandler
            // 
            this.LeaveHandler.Location = new System.Drawing.Point(16, 371);
            this.LeaveHandler.Name = "LeaveHandler";
            this.LeaveHandler.Size = new System.Drawing.Size(148, 67);
            this.LeaveHandler.TabIndex = 10;
            this.LeaveHandler.Text = "Leave";
            this.LeaveHandler.UseVisualStyleBackColor = true;
            this.LeaveHandler.Click += new System.EventHandler(this.LeaveHandler_Click);
            // 
            // Explanation1
            // 
            this.Explanation1.AutoSize = true;
            this.Explanation1.Location = new System.Drawing.Point(13, 118);
            this.Explanation1.Name = "Explanation1";
            this.Explanation1.Size = new System.Drawing.Size(0, 13);
            this.Explanation1.TabIndex = 11;
            // 
            // Explanation2
            // 
            this.Explanation2.AutoSize = true;
            this.Explanation2.Location = new System.Drawing.Point(322, 118);
            this.Explanation2.Name = "Explanation2";
            this.Explanation2.Size = new System.Drawing.Size(0, 13);
            this.Explanation2.TabIndex = 12;
            // 
            // Explanation3
            // 
            this.Explanation3.AutoSize = true;
            this.Explanation3.Location = new System.Drawing.Point(590, 118);
            this.Explanation3.Name = "Explanation3";
            this.Explanation3.Size = new System.Drawing.Size(0, 13);
            this.Explanation3.TabIndex = 13;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(207, 371);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(35, 13);
            this.User.TabIndex = 14;
            this.User.Text = "User: ";
            // 
            // CompletedAt
            // 
            this.CompletedAt.AutoSize = true;
            this.CompletedAt.Location = new System.Drawing.Point(206, 407);
            this.CompletedAt.Name = "CompletedAt";
            this.CompletedAt.Size = new System.Drawing.Size(36, 13);
            this.CompletedAt.TabIndex = 15;
            this.CompletedAt.Text = "Date: ";
            // 
            // Explanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.CompletedAt);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Explanation3);
            this.Controls.Add(this.Explanation2);
            this.Controls.Add(this.Explanation1);
            this.Controls.Add(this.LeaveHandler);
            this.Controls.Add(this.Question3Content);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question2Content);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Question1Content);
            this.Controls.Add(this.Question1);
            this.Name = "Explanation";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Explanation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Label Question1Content;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.Label Question2Content;
        private System.Windows.Forms.Label Question3Content;
        private System.Windows.Forms.Label Question3;
        private System.Windows.Forms.Button LeaveHandler;
        private System.Windows.Forms.Label Explanation1;
        private System.Windows.Forms.Label Explanation2;
        private System.Windows.Forms.Label Explanation3;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label CompletedAt;
    }
}