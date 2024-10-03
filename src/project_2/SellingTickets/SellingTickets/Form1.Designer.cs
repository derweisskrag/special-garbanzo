namespace SellingTickets
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
            this.CalculateRevenueBtn = new System.Windows.Forms.Button();
            this.ClearFieldsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TicketsSoldClasses = new System.Windows.Forms.GroupBox();
            this.ClassATicket = new System.Windows.Forms.Label();
            this.ClassBTicket = new System.Windows.Forms.Label();
            this.ClassCTicket = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.InputC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputRevenueC = new System.Windows.Forms.TextBox();
            this.InputRevenueB = new System.Windows.Forms.TextBox();
            this.InputRevenueA = new System.Windows.Forms.TextBox();
            this.RevenueC = new System.Windows.Forms.Label();
            this.RevenueB = new System.Windows.Forms.Label();
            this.RevenueA = new System.Windows.Forms.Label();
            this.TotalRevenue = new System.Windows.Forms.Label();
            this.InputTotalRevenue = new System.Windows.Forms.TextBox();
            this.TicketsSoldClasses.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateRevenueBtn
            // 
            this.CalculateRevenueBtn.Location = new System.Drawing.Point(167, 351);
            this.CalculateRevenueBtn.Name = "CalculateRevenueBtn";
            this.CalculateRevenueBtn.Size = new System.Drawing.Size(91, 50);
            this.CalculateRevenueBtn.TabIndex = 0;
            this.CalculateRevenueBtn.Text = "Calculate Revenue";
            this.CalculateRevenueBtn.UseVisualStyleBackColor = true;
            this.CalculateRevenueBtn.Click += new System.EventHandler(this.CalculateRevenueBtn_Click);
            // 
            // ClearFieldsBtn
            // 
            this.ClearFieldsBtn.Location = new System.Drawing.Point(355, 351);
            this.ClearFieldsBtn.Name = "ClearFieldsBtn";
            this.ClearFieldsBtn.Size = new System.Drawing.Size(75, 50);
            this.ClearFieldsBtn.TabIndex = 1;
            this.ClearFieldsBtn.Text = "Clear";
            this.ClearFieldsBtn.UseVisualStyleBackColor = true;
            this.ClearFieldsBtn.Click += new System.EventHandler(this.ClearFieldsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(522, 351);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(74, 50);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TicketsSoldClasses
            // 
            this.TicketsSoldClasses.Controls.Add(this.InputC);
            this.TicketsSoldClasses.Controls.Add(this.InputB);
            this.TicketsSoldClasses.Controls.Add(this.InputA);
            this.TicketsSoldClasses.Controls.Add(this.ClassCTicket);
            this.TicketsSoldClasses.Controls.Add(this.ClassBTicket);
            this.TicketsSoldClasses.Controls.Add(this.ClassATicket);
            this.TicketsSoldClasses.Location = new System.Drawing.Point(89, 50);
            this.TicketsSoldClasses.Name = "TicketsSoldClasses";
            this.TicketsSoldClasses.Size = new System.Drawing.Size(206, 186);
            this.TicketsSoldClasses.TabIndex = 3;
            this.TicketsSoldClasses.TabStop = false;
            this.TicketsSoldClasses.Text = "Tickets Sold";
            // 
            // ClassATicket
            // 
            this.ClassATicket.AutoSize = true;
            this.ClassATicket.Location = new System.Drawing.Point(20, 45);
            this.ClassATicket.Name = "ClassATicket";
            this.ClassATicket.Size = new System.Drawing.Size(48, 13);
            this.ClassATicket.TabIndex = 0;
            this.ClassATicket.Text = "Class A: ";
            // 
            // ClassBTicket
            // 
            this.ClassBTicket.AutoSize = true;
            this.ClassBTicket.Location = new System.Drawing.Point(20, 92);
            this.ClassBTicket.Name = "ClassBTicket";
            this.ClassBTicket.Size = new System.Drawing.Size(48, 13);
            this.ClassBTicket.TabIndex = 1;
            this.ClassBTicket.Text = "Class B: ";
            // 
            // ClassCTicket
            // 
            this.ClassCTicket.AutoSize = true;
            this.ClassCTicket.Location = new System.Drawing.Point(20, 135);
            this.ClassCTicket.Name = "ClassCTicket";
            this.ClassCTicket.Size = new System.Drawing.Size(51, 13);
            this.ClassCTicket.TabIndex = 2;
            this.ClassCTicket.Text = "Class C:  ";
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(74, 42);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 20);
            this.InputA.TabIndex = 3;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(74, 89);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 20);
            this.InputB.TabIndex = 4;
            // 
            // InputC
            // 
            this.InputC.Location = new System.Drawing.Point(74, 135);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(100, 20);
            this.InputC.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputTotalRevenue);
            this.groupBox1.Controls.Add(this.TotalRevenue);
            this.groupBox1.Controls.Add(this.InputRevenueC);
            this.groupBox1.Controls.Add(this.InputRevenueB);
            this.groupBox1.Controls.Add(this.InputRevenueA);
            this.groupBox1.Controls.Add(this.RevenueC);
            this.groupBox1.Controls.Add(this.RevenueB);
            this.groupBox1.Controls.Add(this.RevenueA);
            this.groupBox1.Location = new System.Drawing.Point(426, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revenue Generated";
            // 
            // InputRevenueC
            // 
            this.InputRevenueC.Location = new System.Drawing.Point(74, 135);
            this.InputRevenueC.Name = "InputRevenueC";
            this.InputRevenueC.Size = new System.Drawing.Size(100, 20);
            this.InputRevenueC.TabIndex = 5;
            // 
            // InputRevenueB
            // 
            this.InputRevenueB.Location = new System.Drawing.Point(74, 89);
            this.InputRevenueB.Name = "InputRevenueB";
            this.InputRevenueB.Size = new System.Drawing.Size(100, 20);
            this.InputRevenueB.TabIndex = 4;
            // 
            // InputRevenueA
            // 
            this.InputRevenueA.Location = new System.Drawing.Point(74, 42);
            this.InputRevenueA.Name = "InputRevenueA";
            this.InputRevenueA.Size = new System.Drawing.Size(100, 20);
            this.InputRevenueA.TabIndex = 3;
            // 
            // RevenueC
            // 
            this.RevenueC.AutoSize = true;
            this.RevenueC.Location = new System.Drawing.Point(20, 135);
            this.RevenueC.Name = "RevenueC";
            this.RevenueC.Size = new System.Drawing.Size(51, 13);
            this.RevenueC.TabIndex = 2;
            this.RevenueC.Text = "Class C:  ";
            // 
            // RevenueB
            // 
            this.RevenueB.AutoSize = true;
            this.RevenueB.Location = new System.Drawing.Point(20, 92);
            this.RevenueB.Name = "RevenueB";
            this.RevenueB.Size = new System.Drawing.Size(48, 13);
            this.RevenueB.TabIndex = 1;
            this.RevenueB.Text = "Class B: ";
            // 
            // RevenueA
            // 
            this.RevenueA.AutoSize = true;
            this.RevenueA.Location = new System.Drawing.Point(20, 45);
            this.RevenueA.Name = "RevenueA";
            this.RevenueA.Size = new System.Drawing.Size(48, 13);
            this.RevenueA.TabIndex = 0;
            this.RevenueA.Text = "Class A: ";
            // 
            // TotalRevenue
            // 
            this.TotalRevenue.AutoSize = true;
            this.TotalRevenue.Location = new System.Drawing.Point(17, 197);
            this.TotalRevenue.Name = "TotalRevenue";
            this.TotalRevenue.Size = new System.Drawing.Size(37, 13);
            this.TotalRevenue.TabIndex = 6;
            this.TotalRevenue.Text = "Total: ";
            // 
            // InputTotalRevenue
            // 
            this.InputTotalRevenue.Location = new System.Drawing.Point(74, 194);
            this.InputTotalRevenue.Name = "InputTotalRevenue";
            this.InputTotalRevenue.Size = new System.Drawing.Size(100, 20);
            this.InputTotalRevenue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TicketsSoldClasses);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearFieldsBtn);
            this.Controls.Add(this.CalculateRevenueBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TicketsSoldClasses.ResumeLayout(false);
            this.TicketsSoldClasses.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalculateRevenueBtn;
        private System.Windows.Forms.Button ClearFieldsBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox TicketsSoldClasses;
        private System.Windows.Forms.TextBox InputC;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.Label ClassCTicket;
        private System.Windows.Forms.Label ClassBTicket;
        private System.Windows.Forms.Label ClassATicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InputRevenueC;
        private System.Windows.Forms.TextBox InputRevenueB;
        private System.Windows.Forms.TextBox InputRevenueA;
        private System.Windows.Forms.Label RevenueC;
        private System.Windows.Forms.Label RevenueB;
        private System.Windows.Forms.Label RevenueA;
        private System.Windows.Forms.TextBox InputTotalRevenue;
        private System.Windows.Forms.Label TotalRevenue;
    }
}

