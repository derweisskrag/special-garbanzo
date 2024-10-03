namespace bmi_measure
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
            this.Weight = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(251, 133);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(47, 13);
            this.Weight.TabIndex = 0;
            this.Weight.Text = "Weight: ";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(254, 178);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(44, 13);
            this.Height.TabIndex = 1;
            this.Height.Text = "Height: ";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(420, 130);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(97, 65);
            this.CalculateBtn.TabIndex = 2;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // WeightInput
            // 
            this.WeightInput.Location = new System.Drawing.Point(304, 130);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(100, 20);
            this.WeightInput.TabIndex = 3;
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(304, 175);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 20);
            this.HeightInput.TabIndex = 4;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(254, 226);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(263, 100);
            this.Result.TabIndex = 5;
            this.Result.Text = "";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(664, 381);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(124, 57);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(664, 310);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(124, 55);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WeightInput);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Name = "Form1";
            this.Text = "BMI computation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

