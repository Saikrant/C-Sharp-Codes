namespace Assignment_2_Program_5
{
    partial class Form1
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
            squareFootageLbl = new Label();
            costGallonLbl = new Label();
            costBtn = new Button();
            resetBtn = new Button();
            extBtn = new Button();
            groupBox1 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // squareFootageLbl
            // 
            squareFootageLbl.AutoSize = true;
            squareFootageLbl.Location = new Point(86, 109);
            squareFootageLbl.Name = "squareFootageLbl";
            squareFootageLbl.Size = new Size(114, 20);
            squareFootageLbl.TabIndex = 0;
            squareFootageLbl.Text = "Square Footage";
            squareFootageLbl.Click += label1_Click;
            // 
            // costGallonLbl
            // 
            costGallonLbl.AutoSize = true;
            costGallonLbl.Location = new Point(86, 162);
            costGallonLbl.Name = "costGallonLbl";
            costGallonLbl.Size = new Size(103, 20);
            costGallonLbl.TabIndex = 2;
            costGallonLbl.Text = "Cost of Gallon";
            costGallonLbl.Click += label2_Click;
            // 
            // costBtn
            // 
            costBtn.Location = new Point(438, 72);
            costBtn.Name = "costBtn";
            costBtn.Size = new Size(157, 29);
            costBtn.TabIndex = 4;
            costBtn.Text = "Estimated Cost";
            costBtn.UseVisualStyleBackColor = true;
            costBtn.Click += costBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(438, 125);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(157, 29);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // extBtn
            // 
            extBtn.Location = new Point(438, 179);
            extBtn.Name = "extBtn";
            extBtn.Size = new Size(157, 29);
            extBtn.TabIndex = 6;
            extBtn.Text = "Exit";
            extBtn.UseVisualStyleBackColor = true;
            extBtn.Click += extBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(extBtn);
            groupBox1.Controls.Add(resetBtn);
            groupBox1.Controls.Add(costBtn);
            groupBox1.Controls.Add(costGallonLbl);
            groupBox1.Controls.Add(squareFootageLbl);
            groupBox1.Location = new Point(25, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 285);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paint Job Calculations";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(206, 160);
            numericUpDown2.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 11;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(206, 107);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 252);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 7;
            label3.Text = "Developed by Sai Kranth Koneru";
            // 
            // Form1
            // 
            AcceptButton = costBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = extBtn;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Paint Job";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label squareFootageLbl;
        private Label costGallonLbl;
        private Button costBtn;
        private Button resetBtn;
        private Button extBtn;
        private GroupBox groupBox1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
    }
}
