/*
* Class name : Form1
* Class description : Class with form methods.
* Developer name : Sai Kranth Koneru
* Date created : 09 / 13 / 2024
* Date modified : 09 / 15 / 2024
*/
namespace Assignment_2_Program_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Button to calculate and display the estimated cost
        private void costBtn_Click(object sender, EventArgs e)
        {
            PaintJob paintJob = new PaintJob();
            double estimatedCost = paintJob.CalculateEstimatedCost(double.Parse(numericUpDown1.Text), double.Parse(numericUpDown2.Text));
            MessageBox.Show("Estimated cost for paint job is : " + estimatedCost.ToString("F2"), "Estimated Cost");
        }

        //Button to clear all the input fields
        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Text = string.Empty;
            this.numericUpDown2.Text = string.Empty;

        }
        
        //Button to close the form 
        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
