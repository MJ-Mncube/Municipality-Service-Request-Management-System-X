namespace Municipality_Service_Request_Management_System_X
{
    partial class FrmHomePage
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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            lblSouth = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Sep_29__2026__01_18_21_PM;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1359, 737);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1359, 100);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(lblSouth);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1353, 94);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.info;
            pictureBox2.Location = new Point(1216, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 34);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LightGray;
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(1249, 32);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 23);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "About";
            // 
            // lblSouth
            // 
            lblSouth.AutoSize = true;
            lblSouth.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSouth.ForeColor = Color.White;
            lblSouth.Location = new Point(111, 6);
            lblSouth.Name = "lblSouth";
            lblSouth.Size = new Size(316, 28);
            lblSouth.TabIndex = 19;
            lblSouth.Text = "South African Government";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(190, 62);
            label5.Name = "label5";
            label5.Size = new Size(261, 20);
            label5.TabIndex = 18;
            label5.Text = "| Official Information and Services";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(111, 59);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 17;
            label4.Text = "gov.za";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.images1;
            pictureBox7.Location = new Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(102, 88);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(429, 472);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.right_arrow__1_;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(539, 543);
            button1.Name = "button1";
            button1.Size = new Size(286, 79);
            button1.TabIndex = 18;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 737);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FrmHomePage";
            Text = "FrmHomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label lblSouth;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
    }
}