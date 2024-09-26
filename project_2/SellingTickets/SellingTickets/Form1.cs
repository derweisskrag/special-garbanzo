using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellingTickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void ClearFieldsBtn_Click(object sender, EventArgs e)
        {
            // clearing the fields
            this.InputA.Text = "";
            this.InputB.Text = "";
            this.InputC.Text = "";

            this.InputRevenueA.Text = "";
            this.InputRevenueB.Text = "";
            this.InputRevenueC.Text = "";
            this.InputTotalRevenue.Text = "";
        }

        private void CalculateRevenueBtn_Click(object sender, EventArgs e)
        {
            /* 
             Objective: Compute the revenue

             Rules:

                A ticket of the class A costs 15 dollars;
                class B - 12 dollars, and the class C is 9 dollar.

             Implementation: 
                We get the number from client side and use these rules to
                get revenue, and then render it on the client side
             
             */


            string ticketsOfClassA = this.InputA.Text;
            string ticketsOfClassB = this.InputB.Text;
            string ticketsOfClassC = this.InputC.Text;

            // get prices
            int[] prices = this.getPrices();

            try
            {
                // expect strings convertable to numbers
                int firstClassTickets = int.Parse(ticketsOfClassA);
                int secondClassTickets = int.Parse(ticketsOfClassB);
                int thirdClassTickets = int.Parse(ticketsOfClassC);

                // convert prices to double
                double[] doublePrices = Array.ConvertAll(prices, price => Convert.ToDouble(price));

                // multiply and compute revenue
                double firstClassRevenue = doublePrices[0] * firstClassTickets;
                double secondClassRevenue = doublePrices[1] * secondClassTickets;
                double thirdClassRevenue = doublePrices[2] * thirdClassTickets;

                // compute the total revenue
                double totalRevenue = firstClassRevenue + secondClassRevenue + thirdClassRevenue;

                // format and display revenue with euro sign
                string formattedRevenueA = $"{firstClassRevenue:0.00} \u20AC";
                string formattedRevenueB = $"{secondClassRevenue:0.00} \u20AC";
                string formattedRevenueC = $"{thirdClassRevenue:0.00} \u20AC";
                string formattedTotalRevenue = $"{totalRevenue:0.00} \u20AC";

                // Display results
                this.InputRevenueA.Text = formattedRevenueA;
                this.InputRevenueB.Text = formattedRevenueB;
                this.InputRevenueC.Text = formattedRevenueC;
                this.InputTotalRevenue.Text = formattedTotalRevenue;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't compute the revenue due to an error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[] getPrices()
        {
            return new int[] { 15, 12, 9 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Stadium Seating";
        }
    }
}
