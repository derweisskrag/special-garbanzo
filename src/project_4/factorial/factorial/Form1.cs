using System.Runtime.CompilerServices;

namespace factorial
{
    public partial class Form1 : Form
    {
        private Dictionary<int, long> _cache = new Dictionary<int, long>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Factorial App";
            this.loadExplanation();
        }

        private void loadExplanation()
        {
            string explanationText = "Please, provide the non-negative integer!\n\t An example is 5! = 5 * 4 * 3 * 2 * 1 = 120.\n\t So, your input should be like '7', and not '-1'";
            this.Explanation.Text = explanationText;
        }

        private bool isBasicCase(int value)
        {
            return value == 0 || value == 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long factorial(int value)
        {
            if (this.isBasicCase(value)) return 1;


            if (this._cache.ContainsKey(value)) return this._cache[value];

            long result = value * this.factorial(value - 1);
            this._cache[value] = result;
            return result;
        }

        public long iterativeFactorial(int value)
        {
            if (this.isBasicCase(value)) return 1;


            long factorial = 1;
            for (int i = 2; i <= value; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            // get the number
            try
            {

                int inputNumber = int.Parse(this.InputNumber.Text);

                // calculate the factorial
                long factorial = inputNumber > 20 ? this.iterativeFactorial(inputNumber)
                    : (inputNumber > 0 && inputNumber <= 20) ? this.factorial(inputNumber) : 0;

                if (factorial != 0)
                {
                    // display
                    this.ResultComputedLabel.Text = factorial.ToString();
                }
                else
                {
                    this.ResultComputedLabel.Text = "Invalid value!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wrong format! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
