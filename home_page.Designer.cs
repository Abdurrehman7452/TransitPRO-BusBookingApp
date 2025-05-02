namespace TransitPRO
{
    partial class home_page
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bus_pic;
            pictureBox1.Location = new Point(514, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(-19, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 88);
            panel2.TabIndex = 62;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.traspitPRO;
            pictureBox3.Location = new Point(400, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(198, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 66, 153);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(-19, 584);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 74);
            panel1.TabIndex = 63;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-19, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(996, 64);
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.contactUS;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(41, 66, 153);
            button1.Location = new Point(292, 103);
            button1.Name = "button1";
            button1.Size = new Size(89, 42);
            button1.TabIndex = 65;
            button1.Text = "TRIPS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.contactUS;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(41, 66, 153);
            button2.Location = new Point(631, 103);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 66;
            button2.Text = "FAQ's";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.contactUS;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(41, 66, 153);
            button3.Location = new Point(430, 103);
            button3.Name = "button3";
            button3.Size = new Size(151, 42);
            button3.TabIndex = 67;
            button3.Text = "CONTACT US";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(75, 327);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 68;
            label1.Text = "--Departure--";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 349);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 28);
            comboBox1.TabIndex = 69;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(73, 416);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(203, 28);
            comboBox2.TabIndex = 70;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.purchace;
            pictureBox4.Location = new Point(56, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(244, 284);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 71;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 394);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 72;
            label2.Text = "--Arrival--";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 66, 153);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(73, 477);
            button4.Name = "button4";
            button4.Size = new Size(205, 46);
            button4.TabIndex = 73;
            button4.Text = "GET SCHEDULE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(963, 658);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Name = "home_page";
            Text = "home_page";
            Load += home_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox4;
        private Label label2;
        private Button button4;
    }
}