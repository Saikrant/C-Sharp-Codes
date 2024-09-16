


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class ConeCalculations : Form
    {
        public ConeCalculations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Action Button to generate Area of Cone
        private void area_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputRadius.Text, out int radius) && int.TryParse(inputHeight.Text, out int height))
            {
                double area = Cone.CalculateArea(radius, height);
                label3.Text = $"Surface Area of Cone: {area:F2}";
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for radius and height.");
            }
        }
        //Action Button to generate Volume of Cone

        private void volume_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputRadius.Text, out int radius) && int.TryParse(inputHeight.Text, out int height))
            {
                double area = Cone.CalculateVolume(radius, height);
                label3.Text = $"Volume of Cone: {area:F2}";
            }

        }
        //Action Button to Close form

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
