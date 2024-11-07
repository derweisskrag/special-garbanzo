namespace PaperScissorRockGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameUI = new GroupBox();
            ConfirmResult = new Button();
            UserNameValue = new Label();
            UserNameLabel = new Label();
            Scissors = new Button();
            Paper = new Button();
            Rock = new Button();
            UserOptions = new Label();
            Explanation = new RichTextBox();
            ExitBtn = new Button();
            ResetBtn = new Button();
            ShowStatistics = new Button();
            ChoosenOption = new Label();
            ChoosenItemValue = new Label();
            GameUI.SuspendLayout();
            SuspendLayout();
            // 
            // GameUI
            // 
            GameUI.Controls.Add(ChoosenItemValue);
            GameUI.Controls.Add(ChoosenOption);
            GameUI.Controls.Add(ConfirmResult);
            GameUI.Controls.Add(UserNameValue);
            GameUI.Controls.Add(UserNameLabel);
            GameUI.Controls.Add(Scissors);
            GameUI.Controls.Add(Paper);
            GameUI.Controls.Add(Rock);
            GameUI.Controls.Add(UserOptions);
            GameUI.Location = new Point(12, 12);
            GameUI.Name = "GameUI";
            GameUI.Size = new Size(342, 285);
            GameUI.TabIndex = 0;
            GameUI.TabStop = false;
            GameUI.Text = "Choose your item";
            // 
            // ConfirmResult
            // 
            ConfirmResult.Location = new Point(174, 197);
            ConfirmResult.Name = "ConfirmResult";
            ConfirmResult.Size = new Size(142, 67);
            ConfirmResult.TabIndex = 4;
            ConfirmResult.Text = "ConfirmResult";
            ConfirmResult.UseVisualStyleBackColor = true;
            ConfirmResult.Click += ConfirmResult_Click;
            // 
            // UserNameValue
            // 
            UserNameValue.AutoSize = true;
            UserNameValue.Location = new Point(109, 34);
            UserNameValue.Name = "UserNameValue";
            UserNameValue.Size = new Size(0, 15);
            UserNameValue.TabIndex = 5;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(28, 33);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(67, 15);
            UserNameLabel.TabIndex = 4;
            UserNameLabel.Text = "Your name:";
            // 
            // Scissors
            // 
            Scissors.Location = new Point(241, 124);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(75, 56);
            Scissors.TabIndex = 3;
            Scissors.Text = "SCISSORS";
            Scissors.UseVisualStyleBackColor = true;
            Scissors.Click += Scissors_Click;
            // 
            // Paper
            // 
            Paper.Location = new Point(130, 124);
            Paper.Name = "Paper";
            Paper.Size = new Size(84, 56);
            Paper.TabIndex = 2;
            Paper.Text = "PAPER";
            Paper.UseVisualStyleBackColor = true;
            Paper.Click += Paper_Click;
            // 
            // Rock
            // 
            Rock.Location = new Point(28, 124);
            Rock.Name = "Rock";
            Rock.Size = new Size(81, 56);
            Rock.TabIndex = 1;
            Rock.Text = "ROCK";
            Rock.UseVisualStyleBackColor = true;
            Rock.Click += Rock_Click;
            // 
            // UserOptions
            // 
            UserOptions.AutoSize = true;
            UserOptions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UserOptions.Location = new Point(28, 85);
            UserOptions.Name = "UserOptions";
            UserOptions.Size = new Size(298, 15);
            UserOptions.TabIndex = 0;
            UserOptions.Text = "Please, choose your item (choices are located below)";
            // 
            // Explanation
            // 
            Explanation.Location = new Point(564, 12);
            Explanation.Name = "Explanation";
            Explanation.Size = new Size(224, 195);
            Explanation.TabIndex = 1;
            Explanation.Text = "";
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(681, 375);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(107, 63);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(571, 375);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(104, 63);
            ResetBtn.TabIndex = 3;
            ResetBtn.Text = "Start Over Again?";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // ShowStatistics
            // 
            ShowStatistics.Location = new Point(458, 375);
            ShowStatistics.Name = "ShowStatistics";
            ShowStatistics.Size = new Size(107, 63);
            ShowStatistics.TabIndex = 4;
            ShowStatistics.Text = "Show History";
            ShowStatistics.UseVisualStyleBackColor = true;
            ShowStatistics.MouseClick += ShowStatistics_MouseClick;
            // 
            // ChoosenOption
            // 
            ChoosenOption.AutoSize = true;
            ChoosenOption.Location = new Point(27, 204);
            ChoosenOption.Name = "ChoosenOption";
            ChoosenOption.Size = new Size(64, 15);
            ChoosenOption.TabIndex = 6;
            ChoosenOption.Text = "You chose:";
            // 
            // ChoosenItemValue
            // 
            ChoosenItemValue.AutoSize = true;
            ChoosenItemValue.Location = new Point(28, 236);
            ChoosenItemValue.Name = "ChoosenItemValue";
            ChoosenItemValue.Size = new Size(0, 15);
            ChoosenItemValue.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowStatistics);
            Controls.Add(ResetBtn);
            Controls.Add(ExitBtn);
            Controls.Add(Explanation);
            Controls.Add(GameUI);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            GameUI.ResumeLayout(false);
            GameUI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GameUI;
        private RichTextBox Explanation;
        private Button ExitBtn;
        private Label UserOptions;
        private Button Scissors;
        private Button Paper;
        private Button Rock;
        private Button ResetBtn;
        private Label UserNameValue;
        private Label UserNameLabel;
        private Button ConfirmResult;
        private Button ShowStatistics;
        private Label ChoosenItemValue;
        private Label ChoosenOption;
    }
}
