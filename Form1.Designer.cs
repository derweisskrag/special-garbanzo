namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ExitHandler = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UserName = new System.Windows.Forms.Label();
            this.Question1 = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.TextBox();
            this.Question1Content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.TextBox();
            this.Question2Content = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.Label();
            this.Question3Content = new System.Windows.Forms.Label();
            this.Question3AnswerOptions = new System.Windows.Forms.ListBox();
            this.ChoosenAnswer = new System.Windows.Forms.Label();
            this.SubmitHandler = new System.Windows.Forms.Button();
            this.Question1ChoosenAnswer = new System.Windows.Forms.Label();
            this.Question2ChoosenAnswer = new System.Windows.Forms.Label();
            this.CheckHandler = new System.Windows.Forms.Button();
            this.EnteredUserName = new System.Windows.Forms.Label();
            this.EnteredAnswer1Label = new System.Windows.Forms.Label();
            this.EnteredAnswer2Label = new System.Windows.Forms.Label();
            this.ChosenAnswerLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ConfirmAnswers = new System.Windows.Forms.Button();
            this.ConfirmAnswersBtnDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitHandler
            // 
            this.ExitHandler.Location = new System.Drawing.Point(568, 398);
            this.ExitHandler.Name = "ExitHandler";
            this.ExitHandler.Size = new System.Drawing.Size(122, 53);
            this.ExitHandler.TabIndex = 0;
            this.ExitHandler.Text = "Exit";
            this.ExitHandler.UseVisualStyleBackColor = true;
            this.ExitHandler.Click += new System.EventHandler(this.ExitHandlerClick);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Enter your name:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(105, 6);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(107, 20);
            this.NameBox.TabIndex = 2;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(283, 165);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(101, 75);
            this.StartGame.TabIndex = 3;
            this.StartGame.Text = "START";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(112, 46);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(70, 13);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "Your name... ";
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Location = new System.Drawing.Point(25, 196);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(64, 13);
            this.Question1.TabIndex = 6;
            this.Question1.Text = "Question 1: ";
            this.Question1.Visible = false;
            // 
            // Answer1
            // 
            this.Answer1.Location = new System.Drawing.Point(28, 251);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(100, 20);
            this.Answer1.TabIndex = 7;
            this.Answer1.Visible = false;
            // 
            // Question1Content
            // 
            this.Question1Content.AutoSize = true;
            this.Question1Content.Location = new System.Drawing.Point(25, 224);
            this.Question1Content.Name = "Question1Content";
            this.Question1Content.Size = new System.Drawing.Size(151, 13);
            this.Question1Content.TabIndex = 8;
            this.Question1Content.Text = "What is the capital of Estonia?";
            this.Question1Content.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please, provide the answer using lowercased letters!";
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Location = new System.Drawing.Point(242, 195);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(61, 13);
            this.Question2.TabIndex = 10;
            this.Question2.Text = "Question 2:";
            this.Question2.Visible = false;
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(245, 251);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(100, 20);
            this.Answer2.TabIndex = 11;
            this.Answer2.Visible = false;
            // 
            // Question2Content
            // 
            this.Question2Content.AutoSize = true;
            this.Question2Content.Location = new System.Drawing.Point(242, 227);
            this.Question2Content.Name = "Question2Content";
            this.Question2Content.Size = new System.Drawing.Size(130, 13);
            this.Question2Content.TabIndex = 12;
            this.Question2Content.Text = "Evaluate: false == ![] in JS";
            this.Question2Content.Visible = false;
            // 
            // Question3
            // 
            this.Question3.AutoSize = true;
            this.Question3.Location = new System.Drawing.Point(422, 195);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(61, 13);
            this.Question3.TabIndex = 13;
            this.Question3.Text = "Question 3:";
            this.Question3.Visible = false;
            // 
            // Question3Content
            // 
            this.Question3Content.AutoSize = true;
            this.Question3Content.Location = new System.Drawing.Point(422, 224);
            this.Question3Content.Name = "Question3Content";
            this.Question3Content.Size = new System.Drawing.Size(274, 13);
            this.Question3Content.TabIndex = 14;
            this.Question3Content.Text = "Which is of the following is NOT programming language?";
            this.Question3Content.Visible = false;
            // 
            // Question3AnswerOptions
            // 
            this.Question3AnswerOptions.FormattingEnabled = true;
            this.Question3AnswerOptions.Items.AddRange(new object[] {
            "JS",
            "HTML",
            "C#",
            "Rust",
            ""});
            this.Question3AnswerOptions.Location = new System.Drawing.Point(425, 251);
            this.Question3AnswerOptions.Name = "Question3AnswerOptions";
            this.Question3AnswerOptions.Size = new System.Drawing.Size(120, 95);
            this.Question3AnswerOptions.TabIndex = 15;
            this.Question3AnswerOptions.Visible = false;
            this.Question3AnswerOptions.Click += new System.EventHandler(this.Question3AnswerOptions_Click);
            // 
            // ChoosenAnswer
            // 
            this.ChoosenAnswer.AutoSize = true;
            this.ChoosenAnswer.Location = new System.Drawing.Point(618, 258);
            this.ChoosenAnswer.Name = "ChoosenAnswer";
            this.ChoosenAnswer.Size = new System.Drawing.Size(17, 13);
            this.ChoosenAnswer.TabIndex = 16;
            this.ChoosenAnswer.Text = "\"\"";
            this.ChoosenAnswer.Visible = false;
            // 
            // SubmitHandler
            // 
            this.SubmitHandler.Location = new System.Drawing.Point(12, 361);
            this.SubmitHandler.Name = "SubmitHandler";
            this.SubmitHandler.Size = new System.Drawing.Size(116, 54);
            this.SubmitHandler.TabIndex = 17;
            this.SubmitHandler.Text = "Submit Result";
            this.SubmitHandler.UseVisualStyleBackColor = true;
            this.SubmitHandler.Visible = false;
            this.SubmitHandler.Click += new System.EventHandler(this.SubmitHandler_Click);
            // 
            // Question1ChoosenAnswer
            // 
            this.Question1ChoosenAnswer.AutoSize = true;
            this.Question1ChoosenAnswer.Location = new System.Drawing.Point(87, 288);
            this.Question1ChoosenAnswer.Name = "Question1ChoosenAnswer";
            this.Question1ChoosenAnswer.Size = new System.Drawing.Size(17, 13);
            this.Question1ChoosenAnswer.TabIndex = 18;
            this.Question1ChoosenAnswer.Text = "\"\"";
            this.Question1ChoosenAnswer.Visible = false;
            // 
            // Question2ChoosenAnswer
            // 
            this.Question2ChoosenAnswer.AutoSize = true;
            this.Question2ChoosenAnswer.Location = new System.Drawing.Point(279, 288);
            this.Question2ChoosenAnswer.Name = "Question2ChoosenAnswer";
            this.Question2ChoosenAnswer.Size = new System.Drawing.Size(17, 13);
            this.Question2ChoosenAnswer.TabIndex = 19;
            this.Question2ChoosenAnswer.Text = "\"\"";
            this.Question2ChoosenAnswer.Visible = false;
            // 
            // CheckHandler
            // 
            this.CheckHandler.Location = new System.Drawing.Point(134, 367);
            this.CheckHandler.Name = "CheckHandler";
            this.CheckHandler.Size = new System.Drawing.Size(139, 42);
            this.CheckHandler.TabIndex = 20;
            this.CheckHandler.Text = "Check Results";
            this.CheckHandler.UseVisualStyleBackColor = true;
            this.CheckHandler.Click += new System.EventHandler(this.CheckHandler_Click);
            // 
            // EnteredUserName
            // 
            this.EnteredUserName.AutoSize = true;
            this.EnteredUserName.Location = new System.Drawing.Point(15, 45);
            this.EnteredUserName.Name = "EnteredUserName";
            this.EnteredUserName.Size = new System.Drawing.Size(63, 13);
            this.EnteredUserName.TabIndex = 21;
            this.EnteredUserName.Text = "Your Name:";
            // 
            // EnteredAnswer1Label
            // 
            this.EnteredAnswer1Label.AutoSize = true;
            this.EnteredAnswer1Label.Location = new System.Drawing.Point(12, 288);
            this.EnteredAnswer1Label.Name = "EnteredAnswer1Label";
            this.EnteredAnswer1Label.Size = new System.Drawing.Size(69, 13);
            this.EnteredAnswer1Label.TabIndex = 22;
            this.EnteredAnswer1Label.Text = "Your answer:";
            // 
            // EnteredAnswer2Label
            // 
            this.EnteredAnswer2Label.AutoSize = true;
            this.EnteredAnswer2Label.Location = new System.Drawing.Point(204, 288);
            this.EnteredAnswer2Label.Name = "EnteredAnswer2Label";
            this.EnteredAnswer2Label.Size = new System.Drawing.Size(69, 13);
            this.EnteredAnswer2Label.TabIndex = 23;
            this.EnteredAnswer2Label.Text = "Your answer:";
            // 
            // ChosenAnswerLabel
            // 
            this.ChosenAnswerLabel.AutoSize = true;
            this.ChosenAnswerLabel.Location = new System.Drawing.Point(551, 258);
            this.ChosenAnswerLabel.Name = "ChosenAnswerLabel";
            this.ChosenAnswerLabel.Size = new System.Drawing.Size(61, 13);
            this.ChosenAnswerLabel.TabIndex = 24;
            this.ChosenAnswerLabel.Text = "You chose:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(582, 12);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar.TabIndex = 25;
            // 
            // ConfirmAnswers
            // 
            this.ConfirmAnswers.AccessibleDescription = "Saves your answers!";
            this.ConfirmAnswers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmAnswers.Location = new System.Drawing.Point(579, 46);
            this.ConfirmAnswers.Name = "ConfirmAnswers";
            this.ConfirmAnswers.Size = new System.Drawing.Size(111, 87);
            this.ConfirmAnswers.TabIndex = 26;
            this.ConfirmAnswers.Text = "Confirm Your Answers";
            this.ConfirmAnswers.UseVisualStyleBackColor = false;
            this.ConfirmAnswers.Click += new System.EventHandler(this.ConfirmAnswers_Click);
            this.ConfirmAnswers.MouseLeave += new System.EventHandler(this.ConfirmAnswers_MouseLeave);
            this.ConfirmAnswers.MouseHover += new System.EventHandler(this.ConfirmAnswers_MouseHover);
            // 
            // ConfirmAnswersBtnDesc
            // 
            this.ConfirmAnswersBtnDesc.AutoSize = true;
            this.ConfirmAnswersBtnDesc.Location = new System.Drawing.Point(579, 156);
            this.ConfirmAnswersBtnDesc.Name = "ConfirmAnswersBtnDesc";
            this.ConfirmAnswersBtnDesc.Size = new System.Drawing.Size(96, 13);
            this.ConfirmAnswersBtnDesc.TabIndex = 27;
            this.ConfirmAnswersBtnDesc.Text = "Saves your results!";
            this.ConfirmAnswersBtnDesc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 463);
            this.Controls.Add(this.ConfirmAnswersBtnDesc);
            this.Controls.Add(this.ConfirmAnswers);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ChosenAnswerLabel);
            this.Controls.Add(this.EnteredAnswer2Label);
            this.Controls.Add(this.EnteredAnswer1Label);
            this.Controls.Add(this.EnteredUserName);
            this.Controls.Add(this.CheckHandler);
            this.Controls.Add(this.Question2ChoosenAnswer);
            this.Controls.Add(this.Question1ChoosenAnswer);
            this.Controls.Add(this.SubmitHandler);
            this.Controls.Add(this.ChoosenAnswer);
            this.Controls.Add(this.Question3AnswerOptions);
            this.Controls.Add(this.Question3Content);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question2Content);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question1Content);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ExitHandler);
            this.Name = "Form1";
            this.Text = "Quizz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitHandler;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.TextBox Answer1;
        private System.Windows.Forms.Label Question1Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.TextBox Answer2;
        private System.Windows.Forms.Label Question2Content;
        private System.Windows.Forms.Label Question3;
        private System.Windows.Forms.Label Question3Content;
        private System.Windows.Forms.ListBox Question3AnswerOptions;
        private System.Windows.Forms.Label ChoosenAnswer;
        private System.Windows.Forms.Button SubmitHandler;
        private System.Windows.Forms.Label Question1ChoosenAnswer;
        private System.Windows.Forms.Label Question2ChoosenAnswer;
        private System.Windows.Forms.Button CheckHandler;
        private System.Windows.Forms.Label EnteredUserName;
        private System.Windows.Forms.Label EnteredAnswer1Label;
        private System.Windows.Forms.Label EnteredAnswer2Label;
        private System.Windows.Forms.Label ChosenAnswerLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ConfirmAnswers;
        private System.Windows.Forms.Label ConfirmAnswersBtnDesc;
    }
}

