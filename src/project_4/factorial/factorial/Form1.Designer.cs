namespace factorial
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
            ExitBtn = new Button();
            ComputeButton = new Button();
            LabelNumber = new Label();
            InputNumber = new TextBox();
            ResultLabel = new Label();
            ResultComputedLabel = new Label();
            Explanation = new RichTextBox();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(665, 358);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(123, 80);
            ExitBtn.TabIndex = 0;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ComputeButton
            // 
            ComputeButton.Location = new Point(525, 358);
            ComputeButton.Name = "ComputeButton";
            ComputeButton.Size = new Size(123, 81);
            ComputeButton.TabIndex = 1;
            ComputeButton.Text = "Calculate";
            ComputeButton.UseVisualStyleBackColor = true;
            ComputeButton.Click += ComputeButton_Click;
            // 
            // LabelNumber
            // 
            LabelNumber.AutoSize = true;
            LabelNumber.Location = new Point(211, 192);
            LabelNumber.Name = "LabelNumber";
            LabelNumber.Size = new Size(102, 15);
            LabelNumber.TabIndex = 2;
            LabelNumber.Text = "Enter the number:";
            // 
            // InputNumber
            // 
            InputNumber.Location = new Point(319, 189);
            InputNumber.Name = "InputNumber";
            InputNumber.Size = new Size(100, 23);
            InputNumber.TabIndex = 3;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(211, 242);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(45, 15);
            ResultLabel.TabIndex = 4;
            ResultLabel.Text = "Result: ";
            // 
            // ResultComputedLabel
            // 
            ResultComputedLabel.AutoSize = true;
            ResultComputedLabel.Location = new Point(319, 242);
            ResultComputedLabel.Name = "ResultComputedLabel";
            ResultComputedLabel.Size = new Size(0, 15);
            ResultComputedLabel.TabIndex = 5;
            // 
            // Explanation
            // 
            Explanation.Location = new Point(12, 12);
            Explanation.Name = "Explanation";
            Explanation.Size = new Size(307, 140);
            Explanation.TabIndex = 6;
            Explanation.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Explanation);
            Controls.Add(ResultComputedLabel);
            Controls.Add(ResultLabel);
            Controls.Add(InputNumber);
            Controls.Add(LabelNumber);
            Controls.Add(ComputeButton);
            Controls.Add(ExitBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBtn;
        private Button ComputeButton;
        private Label LabelNumber;
        private TextBox InputNumber;
        private Label ResultLabel;
        private Label ResultComputedLabel;
        private RichTextBox Explanation;
    }
}
