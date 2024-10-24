namespace GuessGame
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
            this.GuessContainer = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.GuessLabel = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AnalyticsContainer = new System.Windows.Forms.GroupBox();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.GiveUpButton = new System.Windows.Forms.Button();
            this.ComputerGuessResult = new System.Windows.Forms.Label();
            this.ComputerGuessResultValue = new System.Windows.Forms.Label();
            this.GuessContainer.SuspendLayout();
            this.AnalyticsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuessContainer
            // 
            this.GuessContainer.Controls.Add(this.ComputerGuessResultValue);
            this.GuessContainer.Controls.Add(this.ComputerGuessResult);
            this.GuessContainer.Controls.Add(this.GiveUpButton);
            this.GuessContainer.Controls.Add(this.Status);
            this.GuessContainer.Controls.Add(this.StartButton);
            this.GuessContainer.Controls.Add(this.GuessLabel);
            this.GuessContainer.Controls.Add(this.UserInput);
            this.GuessContainer.Controls.Add(this.ConfirmButton);
            this.GuessContainer.Location = new System.Drawing.Point(12, 12);
            this.GuessContainer.Name = "GuessContainer";
            this.GuessContainer.Size = new System.Drawing.Size(212, 175);
            this.GuessContainer.TabIndex = 0;
            this.GuessContainer.TabStop = false;
            this.GuessContainer.Text = "Guess Number";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(18, 70);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GuessLabel
            // 
            this.GuessLabel.AutoSize = true;
            this.GuessLabel.Location = new System.Drawing.Point(15, 37);
            this.GuessLabel.Name = "GuessLabel";
            this.GuessLabel.Size = new System.Drawing.Size(60, 13);
            this.GuessLabel.TabIndex = 2;
            this.GuessLabel.Text = "Your guess";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(94, 34);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(100, 20);
            this.UserInput.TabIndex = 1;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(119, 71);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(637, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(151, 69);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            // 
            // AnalyticsContainer
            // 
            this.AnalyticsContainer.Controls.Add(this.Results);
            this.AnalyticsContainer.Location = new System.Drawing.Point(588, 12);
            this.AnalyticsContainer.Name = "AnalyticsContainer";
            this.AnalyticsContainer.Size = new System.Drawing.Size(200, 269);
            this.AnalyticsContainer.TabIndex = 2;
            this.AnalyticsContainer.TabStop = false;
            this.AnalyticsContainer.Text = "Analytics";
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(6, 34);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(188, 229);
            this.Results.TabIndex = 0;
            this.Results.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(488, 369);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(143, 69);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 90);
            this.button1.TabIndex = 4;
            this.button1.Text = "Does Nothing You Can chill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(15, 112);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(81, 13);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status: Inactive";
            // 
            // GiveUpButton
            // 
            this.GiveUpButton.Location = new System.Drawing.Point(119, 107);
            this.GiveUpButton.Name = "GiveUpButton";
            this.GiveUpButton.Size = new System.Drawing.Size(75, 23);
            this.GiveUpButton.TabIndex = 5;
            this.GiveUpButton.Text = "Give Up";
            this.GiveUpButton.UseVisualStyleBackColor = true;
            this.GiveUpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GiveUpButton_MouseClick);
            // 
            // ComputerGuessResult
            // 
            this.ComputerGuessResult.AutoSize = true;
            this.ComputerGuessResult.Location = new System.Drawing.Point(15, 147);
            this.ComputerGuessResult.Name = "ComputerGuessResult";
            this.ComputerGuessResult.Size = new System.Drawing.Size(91, 13);
            this.ComputerGuessResult.TabIndex = 6;
            this.ComputerGuessResult.Text = "Computer Guess: ";
            // 
            // ComputerGuessResultValue
            // 
            this.ComputerGuessResultValue.AutoSize = true;
            this.ComputerGuessResultValue.Location = new System.Drawing.Point(119, 147);
            this.ComputerGuessResultValue.Name = "ComputerGuessResultValue";
            this.ComputerGuessResultValue.Size = new System.Drawing.Size(0, 13);
            this.ComputerGuessResultValue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AnalyticsContainer);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GuessContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GuessContainer.ResumeLayout(false);
            this.GuessContainer.PerformLayout();
            this.AnalyticsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GuessContainer;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label GuessLabel;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.GroupBox AnalyticsContainer;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button GiveUpButton;
        private System.Windows.Forms.Label ComputerGuessResult;
        private System.Windows.Forms.Label ComputerGuessResultValue;
    }
}

