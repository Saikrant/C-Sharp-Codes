namespace Assignment_2_Program_4
{
    public partial class intrestLbl : Form
    {
        public intrestLbl()
        {
            InitializeComponent();
        }

        private void loanAmtLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Button to return the monthly payment
        private void monthPaymentBtn_Click(object sender, EventArgs e)
        {

            //call the fucnction calculateMonthlyPayment and send parameters
            double monthlyPayment = Loan.CalculateMonthlyPayment(double.Parse(numericUpDown1.Text), int.Parse(numericUpDown2.Text), double.Parse(numericUpDown3.Text));
            label2.Text = "Monthly Payment : " + monthlyPayment.ToString("F2");
          
        }

        //method to clear inputs
        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Text = string.Empty;
            this.numericUpDown2.Text = string.Empty;
            this.numericUpDown3.Text = string.Empty;
        }
        

        //Exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void durationLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void intrestLbl_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
