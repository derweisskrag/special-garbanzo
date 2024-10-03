using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.CompilerServices;

namespace bmi_measure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            // complete the computation
            // get the values
            float weight = float.Parse(this.WeightInput.Text);
            float height = float.Parse(this.HeightInput.Text);

            // compute 
            float result = this.CalculateBMI(weight, height);

            string status = result switch
            {
                < 18.5 => "Underweight",
                >= 18.5 and < 25 => "Normal weight",
                >= 25 and < 30 => "Overweight",
                _ => "Obese"
            };

            // display
            this.Result.Text = $"BMI: {result}\nStatus: {status}";
        }





        private float CalculateBMI(float weight, float height)
        {
            if(weight < 0 || height < 0)
            {
                MessageBox.Show("Please, enter the correct weight and height (in pounds)!", "Confirm",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return weight / (height * height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private float CalculateBMI_inline(float w, float h)
        {
            if (w < 0 || h < 0)
            {
                MessageBox.Show("Please, enter the correct weight and height (in pounds)!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return w / (h * h);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Action: Exit", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Exit Canceled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // clear the inputs for data inputs
            this.WeightInput.Text = "";
            this.HeightInput.Text = "";

            // clear the explanation
            this.Result.Text = "";
        }
    }
}
