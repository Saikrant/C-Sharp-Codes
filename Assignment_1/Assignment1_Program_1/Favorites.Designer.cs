namespace Assignment_1
{
    partial class Favorites
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button6 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 5;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(431, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 166);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(45, 140);
            button4.Name = "button4";
            button4.Size = new Size(210, 47);
            button4.TabIndex = 6;
            button4.Text = "  Favourite Song";
            button4.UseVisualStyleBackColor = false;
            button4.Click += favSong_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(45, 41);
            button3.Name = "button3";
            button3.Size = new Size(210, 45);
            button3.TabIndex = 4;
            button3.Text = "Favourite Quote";
            button3.UseVisualStyleBackColor = false;
            button3.Click += favQuote_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(45, 193);
            button5.Name = "button5";
            button5.Size = new Size(210, 45);
            button5.TabIndex = 7;
            button5.Text = " Favourite Food";
            button5.UseVisualStyleBackColor = false;
            button5.Click += favFood_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(45, 296);
            button1.Name = "button1";
            button1.Size = new Size(210, 43);
            button1.TabIndex = 2;
            button1.Text = "Favourite Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += exit_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.WhiteSmoke;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(45, 244);
            button6.Name = "button6";
            button6.Size = new Size(210, 46);
            button6.TabIndex = 8;
            button6.Text = "Favourite Movie";
            button6.UseVisualStyleBackColor = false;
            button6.Click += favMovie_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(45, 91);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(210, 43);
            button2.TabIndex = 3;
            button2.Text = " Favourite Place";
            button2.UseVisualStyleBackColor = false;
            button2.Click += favPlace_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Menu;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(55, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 358);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Green;
            label1.Location = new Point(615, 421);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Developed by Sai Kranth";
            label1.Click += label1_Click;
            // 
            // Favorites
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            ForeColor = SystemColors.ControlText;
            Name = "Favorites";
            Text = "`";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button6;
        private Button button2;
        private GroupBox groupBox2;
        private Label label1;
    }
}
