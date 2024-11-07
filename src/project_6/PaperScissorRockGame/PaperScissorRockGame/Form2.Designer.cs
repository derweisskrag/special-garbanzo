namespace PaperScissorRockGame
{
    partial class Form2
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
            ExplanationAuth = new RichTextBox();
            AuthUI = new GroupBox();
            LeaveBtn = new Button();
            Confirm = new Button();
            NameInput = new TextBox();
            LabelName = new Label();
            ReadExplantionLabel = new Label();
            AuthUI.SuspendLayout();
            SuspendLayout();
            // 
            // ExplanationAuth
            // 
            ExplanationAuth.Location = new Point(550, 95);
            ExplanationAuth.Name = "ExplanationAuth";
            ExplanationAuth.Size = new Size(238, 306);
            ExplanationAuth.TabIndex = 0;
            ExplanationAuth.Text = "";
            // 
            // AuthUI
            // 
            AuthUI.Controls.Add(LeaveBtn);
            AuthUI.Controls.Add(Confirm);
            AuthUI.Controls.Add(NameInput);
            AuthUI.Controls.Add(LabelName);
            AuthUI.Location = new Point(219, 80);
            AuthUI.Name = "AuthUI";
            AuthUI.Size = new Size(238, 206);
            AuthUI.TabIndex = 1;
            AuthUI.TabStop = false;
            AuthUI.Text = "Authorize";
            // 
            // LeaveBtn
            // 
            LeaveBtn.Location = new Point(19, 162);
            LeaveBtn.Name = "LeaveBtn";
            LeaveBtn.Size = new Size(207, 31);
            LeaveBtn.TabIndex = 3;
            LeaveBtn.Text = "Leave";
            LeaveBtn.UseVisualStyleBackColor = true;
            LeaveBtn.MouseClick += LeaveBtn_MouseClick;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(19, 128);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(207, 28);
            Confirm.TabIndex = 2;
            Confirm.Text = "Sign In";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(14, 79);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(100, 23);
            NameInput.TabIndex = 1;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(14, 45);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(97, 15);
            LabelName.TabIndex = 0;
            LabelName.Text = "Enter your name:";
            // 
            // ReadExplantionLabel
            // 
            ReadExplantionLabel.AutoSize = true;
            ReadExplantionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReadExplantionLabel.Location = new Point(602, 55);
            ReadExplantionLabel.Name = "ReadExplantionLabel";
            ReadExplantionLabel.Size = new Size(129, 15);
            ReadExplantionLabel.TabIndex = 2;
            ReadExplantionLabel.Text = "Read the explanation!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReadExplantionLabel);
            Controls.Add(AuthUI);
            Controls.Add(ExplanationAuth);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            AuthUI.ResumeLayout(false);
            AuthUI.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ExplanationAuth;
        private GroupBox AuthUI;
        private Button Confirm;
        private TextBox NameInput;
        private Label LabelName;
        private Button LeaveBtn;
        private Label ReadExplantionLabel;
    }
}