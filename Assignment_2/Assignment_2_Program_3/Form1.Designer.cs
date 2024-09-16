namespace Assignment_2_Program_3
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            orangeButton = new RadioButton();
            redButton = new RadioButton();
            greenButton = new RadioButton();
            blueButton = new RadioButton();
            groupBox2 = new GroupBox();
            developer = new CheckBox();
            logo = new CheckBox();
            tagLine = new CheckBox();
            name = new CheckBox();
            button1 = new Button();
            developerName = new Label();
            tagline1 = new Label();
            tagline2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(orangeButton);
            groupBox1.Controls.Add(redButton);
            groupBox1.Controls.Add(greenButton);
            groupBox1.Controls.Add(blueButton);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(132, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pick Color :";
            // 
            // orangeButton
            // 
            orangeButton.AutoSize = true;
            orangeButton.Location = new Point(18, 156);
            orangeButton.Name = "orangeButton";
            orangeButton.Size = new Size(81, 24);
            orangeButton.TabIndex = 3;
            orangeButton.Text = "&Orange";
            orangeButton.UseVisualStyleBackColor = true;
            orangeButton.CheckedChanged += orangeButton_CheckedChanged;
            // 
            // redButton
            // 
            redButton.AutoSize = true;
            redButton.Location = new Point(18, 116);
            redButton.Name = "redButton";
            redButton.Size = new Size(57, 24);
            redButton.TabIndex = 2;
            redButton.Text = "&Red";
            redButton.UseVisualStyleBackColor = true;
            redButton.CheckedChanged += redButton_CheckedChanged;
            // 
            // greenButton
            // 
            greenButton.AutoSize = true;
            greenButton.Location = new Point(18, 75);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(72, 24);
            greenButton.TabIndex = 1;
            greenButton.Text = "&Green";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.CheckedChanged += greenButton_CheckedChanged;
            // 
            // blueButton
            // 
            blueButton.AutoSize = true;
            blueButton.Location = new Point(18, 35);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(61, 24);
            blueButton.TabIndex = 0;
            blueButton.Text = "&Blue";
            blueButton.UseVisualStyleBackColor = true;
            blueButton.CheckedChanged += blueButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(developer);
            groupBox2.Controls.Add(logo);
            groupBox2.Controls.Add(tagLine);
            groupBox2.Controls.Add(name);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(616, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Show/Hide :";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // developer
            // 
            developer.AutoSize = true;
            developer.Location = new Point(22, 153);
            developer.Name = "developer";
            developer.Size = new Size(102, 24);
            developer.TabIndex = 3;
            developer.Text = "&Developer";
            developer.UseVisualStyleBackColor = true;
            developer.CheckedChanged += devloperBox_CheckedChanged;
            // 
            // logo
            // 
            logo.AutoSize = true;
            logo.Location = new Point(22, 114);
            logo.Name = "logo";
            logo.Size = new Size(65, 24);
            logo.TabIndex = 2;
            logo.Text = "&Logo";
            logo.UseVisualStyleBackColor = true;
            logo.CheckedChanged += logoBox_CheckedChanged;
            // 
            // tagLine
            // 
            tagLine.AutoSize = true;
            tagLine.Location = new Point(22, 73);
            tagLine.Name = "tagLine";
            tagLine.Size = new Size(83, 24);
            tagLine.TabIndex = 1;
            tagLine.Text = "&TagLine";
            tagLine.UseVisualStyleBackColor = true;
            tagLine.CheckedChanged += tagLineBox_CheckedChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(22, 33);
            name.Name = "name";
            name.Size = new Size(72, 24);
            name.TabIndex = 0;
            name.Text = "&Name";
            name.UseVisualStyleBackColor = true;
            name.CheckedChanged += nameBox_CheckedChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(589, 387);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 2;
            button1.Text = "E&xit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // developerName
            // 
            developerName.AutoSize = true;
            developerName.Location = new Point(30, 391);
            developerName.Name = "developerName";
            developerName.Size = new Size(231, 20);
            developerName.TabIndex = 3;
            developerName.Text = "Developed by : Sai Kranth Koneru";
            developerName.Click += developerNameLabel_Click;
            // 
            // tagline1
            // 
            tagline1.AutoSize = true;
            tagline1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tagline1.Location = new Point(30, 21);
            tagline1.Name = "tagline1";
            tagline1.Size = new Size(167, 35);
            tagline1.TabIndex = 5;
            tagline1.Text = "Visual Studio";
            tagline1.Click += tagline1_Click;
            // 
            // tagline2
            // 
            tagline2.AutoSize = true;
            tagline2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tagline2.Location = new Point(511, 21);
            tagline2.Name = "tagline2";
            tagline2.Size = new Size(267, 35);
            tagline2.TabIndex = 6;
            tagline2.Text = "Unites the Developer ";
            tagline2.Click += tagline2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Visual_Studio_Logo_2019;
            pictureBox1.Location = new Point(249, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Unties the Developer");
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 169);
            label1.Name = "label1";
            label1.Size = new Size(93, 31);
            label1.TabIndex = 8;
            label1.Text = "VISUAL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(467, 166);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 9;
            label2.Text = "STUDIO";
            label2.Click += label2_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Visual Studio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImageLayout = ImageLayout.None;
            CancelButton = button1;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tagline2);
            Controls.Add(tagline1);
            Controls.Add(pictureBox1);
            Controls.Add(developerName);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Advertisment";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton blueButton;
        private RadioButton orangeButton;
        private RadioButton redButton;
        private RadioButton greenButton;
        private GroupBox groupBox2;
        private CheckBox developer;
        private CheckBox logo;
        private CheckBox tagLine;
        private CheckBox name;
        private Button button1;
        private Label developerName;
        private Label tagline1;
        private Label tagline2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
    }
}
