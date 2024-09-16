namespace Assignment_2_Program_4
{
    partial class intrestLbl
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
            loanAmtLbl = new Label();
            durationLbl = new Label();
            label3 = new Label();
            monthPaymetnBtn = new Button();
            resetBtn = new Button();
            exitBtn = new Button();
            label4 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // loanAmtLbl
            // 
            loanAmtLbl.AutoSize = true;
            loanAmtLbl.Location = new Point(94, 123);
            loanAmtLbl.Name = "loanAmtLbl";
            loanAmtLbl.Size = new Size(98, 20);
            loanAmtLbl.TabIndex = 0;
            loanAmtLbl.Text = "Loan Amount";
            loanAmtLbl.Click += loanAmtLbl_Click;
            // 
            // durationLbl
            // 
            durationLbl.AutoSize = true;
            durationLbl.Location = new Point(94, 192);
            durationLbl.Name = "durationLbl";
            durationLbl.Size = new Size(184, 20);
            durationLbl.TabIndex = 2;
            durationLbl.Text = "Duration of Loan (months)";
            durationLbl.Click += durationLbl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 257);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 4;
            label3.Text = "Annual interest rate";
            label3.Click += label3_Click;
            // 
            // monthPaymetnBtn
            // 
            monthPaymetnBtn.Location = new Point(533, 117);
            monthPaymetnBtn.Name = "monthPaymetnBtn";
            monthPaymetnBtn.Size = new Size(189, 29);
            monthPaymetnBtn.TabIndex = 6;
            monthPaymetnBtn.Text = "Monthly Payment";
            monthPaymetnBtn.UseVisualStyleBackColor = true;
            monthPaymetnBtn.Click += monthPaymentBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(533, 183);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(189, 29);
            resetBtn.TabIndex = 7;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(532, 248);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(190, 29);
            exitBtn.TabIndex = 8;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 421);
            label4.Name = "label4";
            label4.Size = new Size(231, 20);
            label4.TabIndex = 9;
            label4.Text = "Developed by : Sai Kranth Koneru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 327);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown1.Location = new Point(298, 116);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(296, 192);
            numericUpDown2.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 13;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown3.Location = new Point(296, 253);
            numericUpDown3.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 14;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 41);
            label1.Name = "label1";
            label1.Size = new Size(396, 31);
            label1.TabIndex = 15;
            label1.Text = "MONTHLY PAYMENT CALCULATOR";
            // 
            // intrestLbl
            // 
            AcceptButton = monthPaymetnBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(exitBtn);
            Controls.Add(resetBtn);
            Controls.Add(monthPaymetnBtn);
            Controls.Add(label3);
            Controls.Add(durationLbl);
            Controls.Add(loanAmtLbl);
            Name = "intrestLbl";
            Text = "Loan";
            Load += intrestLbl_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loanAmtLbl;
        private Label durationLbl;
        private Label label3;
        private Button monthPaymetnBtn;
        private Button resetBtn;
        private Button exitBtn;
        private Label label4;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
    }
}
