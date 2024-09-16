namespace Program_2
{
    partial class ConeCalculations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            inputRadius = new TextBox();
            label2 = new Label();
            inputHeight = new TextBox();
            area = new Button();
            volume = new Button();
            exit = new Button();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(74, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(37, 51);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 0;
            label3.Click += resultLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Radius";
            label1.Click += label1_Click;
            // 
            // inputRadius
            // 
            inputRadius.Location = new Point(20, 55);
            inputRadius.Name = "inputRadius";
            inputRadius.Size = new Size(125, 27);
            inputRadius.TabIndex = 1;
            inputRadius.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(20, 99);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Height";
            label2.Click += label2_Click;
            // 
            // inputHeight
            // 
            inputHeight.Location = new Point(20, 133);
            inputHeight.Name = "inputHeight";
            inputHeight.Size = new Size(125, 27);
            inputHeight.TabIndex = 3;
            inputHeight.TextChanged += textBox2_TextChanged;
            // 
            // area
            // 
            area.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            area.ForeColor = SystemColors.ControlText;
            area.ImageAlign = ContentAlignment.MiddleLeft;
            area.Location = new Point(260, 36);
            area.Name = "area";
            area.Size = new Size(108, 29);
            area.TabIndex = 4;
            area.Text = "Area";
            area.UseVisualStyleBackColor = true;
            area.Click += area_Click;
            // 
            // volume
            // 
            volume.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            volume.ForeColor = SystemColors.Desktop;
            volume.ImageAlign = ContentAlignment.MiddleLeft;
            volume.Location = new Point(260, 90);
            volume.Name = "volume";
            volume.Size = new Size(108, 29);
            volume.TabIndex = 5;
            volume.Text = "Voulme";
            volume.UseVisualStyleBackColor = true;
            volume.Click += volume_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            exit.ForeColor = SystemColors.Desktop;
            exit.ImageAlign = ContentAlignment.MiddleLeft;
            exit.Location = new Point(260, 142);
            exit.Name = "exit";
            exit.Size = new Size(108, 29);
            exit.TabIndex = 6;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(exit);
            groupBox1.Controls.Add(volume);
            groupBox1.Controls.Add(area);
            groupBox1.Controls.Add(inputHeight);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(inputRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(74, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // ConeCalculations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.Green;
            Name = "ConeCalculations";
            Text = "ConeCalculations";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label3;
        private Label label1;
        private TextBox inputRadius;
        private Label label2;
        private TextBox inputHeight;
        private Button area;
        private Button volume;
        private Button exit;
        private GroupBox groupBox1;
    }
}