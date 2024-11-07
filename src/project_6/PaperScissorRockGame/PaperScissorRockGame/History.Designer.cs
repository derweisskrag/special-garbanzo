namespace PaperScissorRockGame
{
    partial class History
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
            LeaveBtn = new Button();
            Description = new RichTextBox();
            SuspendLayout();
            // 
            // LeaveBtn
            // 
            LeaveBtn.Location = new Point(666, 367);
            LeaveBtn.Name = "LeaveBtn";
            LeaveBtn.Size = new Size(122, 71);
            LeaveBtn.TabIndex = 0;
            LeaveBtn.Text = "Leave";
            LeaveBtn.UseVisualStyleBackColor = true;
            LeaveBtn.Click += LeaveBtn_Click;
            // 
            // Description
            // 
            Description.Location = new Point(12, 12);
            Description.Name = "Description";
            Description.Size = new Size(639, 426);
            Description.TabIndex = 1;
            Description.Text = "";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Description);
            Controls.Add(LeaveBtn);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button LeaveBtn;
        private RichTextBox Description;
    }
}