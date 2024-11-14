namespace ExamApp
{
    partial class Results
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
            this.ResultsExplanation = new System.Windows.Forms.RichTextBox();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsExplanation
            // 
            this.ResultsExplanation.Location = new System.Drawing.Point(12, 12);
            this.ResultsExplanation.Name = "ResultsExplanation";
            this.ResultsExplanation.Size = new System.Drawing.Size(776, 392);
            this.ResultsExplanation.TabIndex = 0;
            this.ResultsExplanation.Text = "";
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Location = new System.Drawing.Point(714, 415);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(75, 23);
            this.LeaveBtn.TabIndex = 1;
            this.LeaveBtn.Text = "Leave";
            this.LeaveBtn.UseVisualStyleBackColor = true;
            this.LeaveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeaveBtn_MouseClick);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.ResultsExplanation);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultsExplanation;
        private System.Windows.Forms.Button LeaveBtn;
    }
}