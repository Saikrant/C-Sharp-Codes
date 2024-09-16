/*
* Class name : Form1
* Class description : Class having the form methods.
* Developer name : Sai Kranth Koneru
* Date created : 09 / 13 / 2024
* Date modified : 09 / 15 / 2024
*/
using System.Windows.Forms.VisualStyles;

namespace Assignment_2_Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //All the Checkboxes should be checkedin by default 
            name.Checked = true;
            tagLine.Checked = true;
            logo.Checked = true;
            developer.Checked = true;
            blueButton.Checked = true;

            ////Tool Tip for the logo as mentioned in the requriment
            //ToolTip toolTip = new ToolTip();
            //toolTip.SetToolTip(pictureBox1, "Visual Studio");

            

        }
        //To change color to blue
        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueButton.Checked)
            {
                tagline1.ForeColor = Color.Blue;
                tagline2.ForeColor = Color.Blue;
            }


        }

        //To change color to green
        private void greenButton_CheckedChanged(object sender, EventArgs e)
        {
            if (greenButton.Checked)
            {
                tagline1.ForeColor = Color.Green;
                tagline2.ForeColor = Color.Green;
            }
        }

        //To change color to red
        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redButton.Checked)
            {
                tagline1.ForeColor = Color.Red;
                tagline2.ForeColor = Color.Red;
            }
        }

        //To change color to orange
        private void orangeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeButton.Checked)
            {
                tagline1.ForeColor = Color.Orange;
                tagline2.ForeColor = Color.Orange;
            }
        }

        private void developerNameLabel_Click(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tagline1_Click(object sender, EventArgs e)
        {

        }

        private void tagline2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Button to close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Mehtod to hide/show the tagline1
        private void nameBox_CheckedChanged_1(object sender, EventArgs e)
        {
            tagline1.Visible = name.Checked;
        }

        //Mehtod to hide/show the tagline2
        private void tagLineBox_CheckedChanged(object sender, EventArgs e)
        {
            tagline2.Visible = tagLine.Checked;
        }

        //Mehtod to hide/show the Logo
        private void logoBox_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = logo.Checked;
            label1.Visible = logo.Checked;
            label2.Visible = logo.Checked;

        }

        //Mehtod to hide/show the DeveloperName
        private void devloperBox_CheckedChanged(object sender, EventArgs e)
        {
            developerName.Visible = developer.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
