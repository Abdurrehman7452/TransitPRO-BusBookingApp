namespace TransitPRO
{
    partial class FLights
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.contactUS;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(41, 66, 153);
            button3.Location = new Point(419, 101);
            button3.Name = "button3";
            button3.Size = new Size(151, 42);
            button3.TabIndex = 72;
            button3.Text = "CONTACT US";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.contactUS;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(41, 66, 153);
            button2.Location = new Point(644, 101);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 71;
            button2.Text = "FAQ's";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.contactUS;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(41, 66, 153);
            button1.Location = new Point(251, 101);
            button1.Name = "button1";
            button1.Size = new Size(89, 42);
            button1.TabIndex = 70;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-8, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(996, 64);
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(-8, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 88);
            panel2.TabIndex = 68;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buss;
            pictureBox1.Location = new Point(840, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-217, 232);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 74;
            label1.Text = "----";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FLights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(982, 673);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            ForeColor = Color.White;
            Name = "FLights";
            Text = "FLights";
            Load += FLights_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}