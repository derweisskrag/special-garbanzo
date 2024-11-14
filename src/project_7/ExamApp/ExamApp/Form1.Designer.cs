namespace ExamApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dashboard = new System.Windows.Forms.GroupBox();
            this.PrepareForExamBtn = new System.Windows.Forms.Button();
            this.ViewAllExamsBtn = new System.Windows.Forms.Button();
            this.UserDashBoardBtn = new System.Windows.Forms.Button();
            this.TakeExamBtn = new System.Windows.Forms.Button();
            this.AuthorizationGroup = new System.Windows.Forms.GroupBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.GuestDashBoardBtn = new System.Windows.Forms.Button();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.Dashboard.SuspendLayout();
            this.AuthorizationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.PrepareForExamBtn);
            this.Dashboard.Controls.Add(this.ViewAllExamsBtn);
            this.Dashboard.Controls.Add(this.UserDashBoardBtn);
            this.Dashboard.Controls.Add(this.TakeExamBtn);
            this.Dashboard.Location = new System.Drawing.Point(12, 25);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(273, 271);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.TabStop = false;
            this.Dashboard.Text = "Dashboard";
            // 
            // PrepareForExamBtn
            // 
            this.PrepareForExamBtn.Location = new System.Drawing.Point(7, 20);
            this.PrepareForExamBtn.Name = "PrepareForExamBtn";
            this.PrepareForExamBtn.Size = new System.Drawing.Size(81, 47);
            this.PrepareForExamBtn.TabIndex = 3;
            this.PrepareForExamBtn.Text = "Prepare For Exam";
            this.PrepareForExamBtn.UseVisualStyleBackColor = true;
            // 
            // ViewAllExamsBtn
            // 
            this.ViewAllExamsBtn.Location = new System.Drawing.Point(189, 19);
            this.ViewAllExamsBtn.Name = "ViewAllExamsBtn";
            this.ViewAllExamsBtn.Size = new System.Drawing.Size(75, 48);
            this.ViewAllExamsBtn.TabIndex = 2;
            this.ViewAllExamsBtn.Text = "View all Exams";
            this.ViewAllExamsBtn.UseVisualStyleBackColor = true;
            // 
            // UserDashBoardBtn
            // 
            this.UserDashBoardBtn.Location = new System.Drawing.Point(189, 217);
            this.UserDashBoardBtn.Name = "UserDashBoardBtn";
            this.UserDashBoardBtn.Size = new System.Drawing.Size(78, 48);
            this.UserDashBoardBtn.TabIndex = 1;
            this.UserDashBoardBtn.Text = "Your Dashboard";
            this.UserDashBoardBtn.UseVisualStyleBackColor = true;
            // 
            // TakeExamBtn
            // 
            this.TakeExamBtn.Location = new System.Drawing.Point(18, 217);
            this.TakeExamBtn.Name = "TakeExamBtn";
            this.TakeExamBtn.Size = new System.Drawing.Size(70, 48);
            this.TakeExamBtn.TabIndex = 0;
            this.TakeExamBtn.Text = "Take Exam";
            this.TakeExamBtn.UseVisualStyleBackColor = true;
            this.TakeExamBtn.Click += new System.EventHandler(this.TakeExamBtn_Click);
            // 
            // AuthorizationGroup
            // 
            this.AuthorizationGroup.Controls.Add(this.SignInBtn);
            this.AuthorizationGroup.Controls.Add(this.SignUpBtn);
            this.AuthorizationGroup.Location = new System.Drawing.Point(545, 25);
            this.AuthorizationGroup.Name = "AuthorizationGroup";
            this.AuthorizationGroup.Size = new System.Drawing.Size(200, 100);
            this.AuthorizationGroup.TabIndex = 1;
            this.AuthorizationGroup.TabStop = false;
            this.AuthorizationGroup.Text = "Authorization";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(21, 64);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 1;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(110, 64);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SignUpBtn.TabIndex = 0;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(566, 132);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 2;
            this.LogOutBtn.Text = "LogOut";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            // 
            // GuestDashBoardBtn
            // 
            this.GuestDashBoardBtn.Location = new System.Drawing.Point(201, 303);
            this.GuestDashBoardBtn.Name = "GuestDashBoardBtn";
            this.GuestDashBoardBtn.Size = new System.Drawing.Size(78, 43);
            this.GuestDashBoardBtn.TabIndex = 3;
            this.GuestDashBoardBtn.Text = "Guest Dashboard";
            this.GuestDashBoardBtn.UseVisualStyleBackColor = true;
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Location = new System.Drawing.Point(655, 365);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(133, 73);
            this.LeaveBtn.TabIndex = 4;
            this.LeaveBtn.Text = "Leave";
            this.LeaveBtn.UseVisualStyleBackColor = true;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.GuestDashBoardBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.AuthorizationGroup);
            this.Controls.Add(this.Dashboard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Dashboard.ResumeLayout(false);
            this.AuthorizationGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Dashboard;
        private System.Windows.Forms.Button TakeExamBtn;
        private System.Windows.Forms.GroupBox AuthorizationGroup;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button ViewAllExamsBtn;
        private System.Windows.Forms.Button UserDashBoardBtn;
        private System.Windows.Forms.Button GuestDashBoardBtn;
        private System.Windows.Forms.Button PrepareForExamBtn;
        private System.Windows.Forms.Button LeaveBtn;
    }
}

