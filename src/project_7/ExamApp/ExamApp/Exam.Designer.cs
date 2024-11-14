namespace ExamApp
{
    partial class Exam
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
            this.ExamCtlPanel = new System.Windows.Forms.GroupBox();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.ViewResultBtn = new System.Windows.Forms.Button();
            this.StartExamBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.QuestionSlide = new System.Windows.Forms.GroupBox();
            this.OptionDValue = new System.Windows.Forms.Label();
            this.OptionCValue = new System.Windows.Forms.Label();
            this.OptionBValue = new System.Windows.Forms.Label();
            this.OptionAValue = new System.Windows.Forms.Label();
            this.OptionD = new System.Windows.Forms.RadioButton();
            this.OptionC = new System.Windows.Forms.RadioButton();
            this.OptionB = new System.Windows.Forms.RadioButton();
            this.OptionA = new System.Windows.Forms.RadioButton();
            this.QuestionValue = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.TimerLabelTitle = new System.Windows.Forms.Label();
            this.QuestionNr = new System.Windows.Forms.Label();
            this.ExamCtlPanel.SuspendLayout();
            this.QuestionSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExamCtlPanel
            // 
            this.ExamCtlPanel.Controls.Add(this.LeaveBtn);
            this.ExamCtlPanel.Controls.Add(this.ViewResultBtn);
            this.ExamCtlPanel.Controls.Add(this.StartExamBtn);
            this.ExamCtlPanel.Location = new System.Drawing.Point(12, 12);
            this.ExamCtlPanel.Name = "ExamCtlPanel";
            this.ExamCtlPanel.Size = new System.Drawing.Size(200, 100);
            this.ExamCtlPanel.TabIndex = 0;
            this.ExamCtlPanel.TabStop = false;
            this.ExamCtlPanel.Text = "Exam Control Panel";
            this.ExamCtlPanel.Enter += new System.EventHandler(this.ExamCtlPanel_Enter);
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Location = new System.Drawing.Point(6, 62);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(75, 23);
            this.LeaveBtn.TabIndex = 1;
            this.LeaveBtn.Text = "Leave";
            this.LeaveBtn.UseVisualStyleBackColor = true;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // ViewResultBtn
            // 
            this.ViewResultBtn.Location = new System.Drawing.Point(119, 62);
            this.ViewResultBtn.Name = "ViewResultBtn";
            this.ViewResultBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewResultBtn.TabIndex = 1;
            this.ViewResultBtn.Text = "View Result";
            this.ViewResultBtn.UseVisualStyleBackColor = true;
            this.ViewResultBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewResultBtn_MouseClick);
            // 
            // StartExamBtn
            // 
            this.StartExamBtn.Location = new System.Drawing.Point(119, 19);
            this.StartExamBtn.Name = "StartExamBtn";
            this.StartExamBtn.Size = new System.Drawing.Size(75, 23);
            this.StartExamBtn.TabIndex = 0;
            this.StartExamBtn.Text = "StartExam";
            this.StartExamBtn.UseVisualStyleBackColor = true;
            this.StartExamBtn.Click += new System.EventHandler(this.StartExamBtn_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(688, 12);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar.TabIndex = 1;
            // 
            // QuestionSlide
            // 
            this.QuestionSlide.Controls.Add(this.QuestionNr);
            this.QuestionSlide.Controls.Add(this.OptionDValue);
            this.QuestionSlide.Controls.Add(this.OptionCValue);
            this.QuestionSlide.Controls.Add(this.OptionBValue);
            this.QuestionSlide.Controls.Add(this.OptionAValue);
            this.QuestionSlide.Controls.Add(this.OptionD);
            this.QuestionSlide.Controls.Add(this.OptionC);
            this.QuestionSlide.Controls.Add(this.OptionB);
            this.QuestionSlide.Controls.Add(this.OptionA);
            this.QuestionSlide.Controls.Add(this.QuestionValue);
            this.QuestionSlide.Controls.Add(this.QuestionLabel);
            this.QuestionSlide.Location = new System.Drawing.Point(235, 12);
            this.QuestionSlide.Name = "QuestionSlide";
            this.QuestionSlide.Size = new System.Drawing.Size(383, 309);
            this.QuestionSlide.TabIndex = 2;
            this.QuestionSlide.TabStop = false;
            this.QuestionSlide.Text = "Question";
            this.QuestionSlide.Enter += new System.EventHandler(this.QuestionSlide_Enter);
            // 
            // OptionDValue
            // 
            this.OptionDValue.AutoSize = true;
            this.OptionDValue.Location = new System.Drawing.Point(82, 234);
            this.OptionDValue.Name = "OptionDValue";
            this.OptionDValue.Size = new System.Drawing.Size(0, 13);
            this.OptionDValue.TabIndex = 9;
            // 
            // OptionCValue
            // 
            this.OptionCValue.AutoSize = true;
            this.OptionCValue.Location = new System.Drawing.Point(82, 187);
            this.OptionCValue.Name = "OptionCValue";
            this.OptionCValue.Size = new System.Drawing.Size(0, 13);
            this.OptionCValue.TabIndex = 8;
            // 
            // OptionBValue
            // 
            this.OptionBValue.AutoSize = true;
            this.OptionBValue.Location = new System.Drawing.Point(79, 147);
            this.OptionBValue.Name = "OptionBValue";
            this.OptionBValue.Size = new System.Drawing.Size(0, 13);
            this.OptionBValue.TabIndex = 7;
            // 
            // OptionAValue
            // 
            this.OptionAValue.AutoSize = true;
            this.OptionAValue.Location = new System.Drawing.Point(79, 106);
            this.OptionAValue.Name = "OptionAValue";
            this.OptionAValue.Size = new System.Drawing.Size(0, 13);
            this.OptionAValue.TabIndex = 6;
            // 
            // OptionD
            // 
            this.OptionD.AutoSize = true;
            this.OptionD.Location = new System.Drawing.Point(19, 234);
            this.OptionD.Name = "OptionD";
            this.OptionD.Size = new System.Drawing.Size(33, 17);
            this.OptionD.TabIndex = 5;
            this.OptionD.TabStop = true;
            this.OptionD.Text = "D";
            this.OptionD.UseVisualStyleBackColor = true;
            this.OptionD.CheckedChanged += new System.EventHandler(this.OptionD_CheckedChanged);
            // 
            // OptionC
            // 
            this.OptionC.AutoSize = true;
            this.OptionC.Location = new System.Drawing.Point(19, 187);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(32, 17);
            this.OptionC.TabIndex = 4;
            this.OptionC.TabStop = true;
            this.OptionC.Text = "C";
            this.OptionC.UseVisualStyleBackColor = true;
            this.OptionC.CheckedChanged += new System.EventHandler(this.OptionC_CheckedChanged);
            // 
            // OptionB
            // 
            this.OptionB.AutoSize = true;
            this.OptionB.Location = new System.Drawing.Point(19, 147);
            this.OptionB.Name = "OptionB";
            this.OptionB.Size = new System.Drawing.Size(32, 17);
            this.OptionB.TabIndex = 3;
            this.OptionB.TabStop = true;
            this.OptionB.Text = "B";
            this.OptionB.UseVisualStyleBackColor = true;
            this.OptionB.CheckedChanged += new System.EventHandler(this.OptionB_CheckedChanged);
            // 
            // OptionA
            // 
            this.OptionA.AutoSize = true;
            this.OptionA.Location = new System.Drawing.Point(19, 106);
            this.OptionA.Name = "OptionA";
            this.OptionA.Size = new System.Drawing.Size(32, 17);
            this.OptionA.TabIndex = 2;
            this.OptionA.TabStop = true;
            this.OptionA.Text = "A";
            this.OptionA.UseVisualStyleBackColor = true;
            this.OptionA.CheckedChanged += new System.EventHandler(this.OptionA_CheckedChanged);
            // 
            // QuestionValue
            // 
            this.QuestionValue.AllowDrop = true;
            this.QuestionValue.AutoSize = true;
            this.QuestionValue.Location = new System.Drawing.Point(108, 43);
            this.QuestionValue.Name = "QuestionValue";
            this.QuestionValue.Size = new System.Drawing.Size(0, 16);
            this.QuestionValue.TabIndex = 1;
            this.QuestionValue.UseCompatibleTextRendering = true;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(16, 43);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(66, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "QUESTION:";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(369, 336);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 3;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NextBtn_MouseClick);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(288, 336);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(75, 23);
            this.PrevBtn.TabIndex = 4;
            this.PrevBtn.Text = "Prev";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(451, 336);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(75, 23);
            this.FinishBtn.TabIndex = 5;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(758, 74);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 13);
            this.timerLabel.TabIndex = 6;
            // 
            // TimerLabelTitle
            // 
            this.TimerLabelTitle.AutoSize = true;
            this.TimerLabelTitle.Location = new System.Drawing.Point(688, 73);
            this.TimerLabelTitle.Name = "TimerLabelTitle";
            this.TimerLabelTitle.Size = new System.Drawing.Size(33, 13);
            this.TimerLabelTitle.TabIndex = 7;
            this.TimerLabelTitle.Text = "Time:";
            // 
            // QuestionNr
            // 
            this.QuestionNr.AutoSize = true;
            this.QuestionNr.Location = new System.Drawing.Point(16, 72);
            this.QuestionNr.Name = "QuestionNr";
            this.QuestionNr.Size = new System.Drawing.Size(27, 13);
            this.QuestionNr.TabIndex = 10;
            this.QuestionNr.Text = "Nr.: ";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimerLabelTitle);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.QuestionSlide);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ExamCtlPanel);
            this.Name = "Exam";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.ExamCtlPanel.ResumeLayout(false);
            this.QuestionSlide.ResumeLayout(false);
            this.QuestionSlide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ExamCtlPanel;
        private System.Windows.Forms.Button ViewResultBtn;
        private System.Windows.Forms.Button StartExamBtn;
        private System.Windows.Forms.Button LeaveBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.GroupBox QuestionSlide;
        private System.Windows.Forms.RadioButton OptionA;
        private System.Windows.Forms.Label QuestionValue;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label OptionDValue;
        private System.Windows.Forms.Label OptionCValue;
        private System.Windows.Forms.Label OptionBValue;
        private System.Windows.Forms.Label OptionAValue;
        private System.Windows.Forms.RadioButton OptionD;
        private System.Windows.Forms.RadioButton OptionC;
        private System.Windows.Forms.RadioButton OptionB;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label QuestionNr;
        private System.Windows.Forms.Label TimerLabelTitle;
    }
}