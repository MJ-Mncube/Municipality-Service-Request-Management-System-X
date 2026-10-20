namespace Municipality_Service_Request_Management_System_X
{
    partial class MainPage_1_
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage_1_));
            sidebar = new FlowLayoutPanel();
            pnlmenu = new Panel();
            btnHam = new Button();
            pnlDashboard = new Panel();
            btndashboard = new Button();
            menuContainor = new FlowLayoutPanel();
            pnlRequest = new Panel();
            pictureBox2 = new PictureBox();
            btnRequest = new Button();
            panel11 = new Panel();
            btnNewRequest = new Button();
            panel12 = new Panel();
            btnSampleReport = new Button();
            panel9 = new Panel();
            btnRequestStatus = new Button();
            pnlChatbot = new Panel();
            button4 = new Button();
            pnlFeeback = new Panel();
            button1 = new Button();
            pnlSettings = new Panel();
            button2 = new Button();
            pnlExit = new Panel();
            button3 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSouth = new Label();
            pictureBox3 = new PictureBox();
            sidebar.SuspendLayout();
            pnlmenu.SuspendLayout();
            pnlDashboard.SuspendLayout();
            menuContainor.SuspendLayout();
            pnlRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            pnlChatbot.SuspendLayout();
            pnlFeeback.SuspendLayout();
            pnlSettings.SuspendLayout();
            pnlExit.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Chocolate;
            sidebar.Controls.Add(pnlmenu);
            sidebar.Controls.Add(pnlDashboard);
            sidebar.Controls.Add(menuContainor);
            sidebar.Controls.Add(pnlChatbot);
            sidebar.Controls.Add(pnlFeeback);
            sidebar.Controls.Add(pnlSettings);
            sidebar.Controls.Add(pnlExit);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ControlText;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(41, 450);
            sidebar.TabIndex = 0;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // pnlmenu
            // 
            pnlmenu.BackColor = SystemColors.ActiveBorder;
            pnlmenu.Controls.Add(btnHam);
            pnlmenu.Location = new Point(3, 3);
            pnlmenu.Name = "pnlmenu";
            pnlmenu.Size = new Size(193, 44);
            pnlmenu.TabIndex = 7;
            // 
            // btnHam
            // 
            btnHam.BackColor = Color.Chocolate;
            btnHam.FlatStyle = FlatStyle.Flat;
            btnHam.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHam.ForeColor = Color.White;
            btnHam.Image = Properties.Resources.menu__2_;
            btnHam.ImageAlign = ContentAlignment.MiddleLeft;
            btnHam.Location = new Point(-3, -3);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(201, 57);
            btnHam.TabIndex = 3;
            btnHam.UseVisualStyleBackColor = false;
            btnHam.Click += btnHam_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = SystemColors.ActiveBorder;
            pnlDashboard.Controls.Add(btndashboard);
            pnlDashboard.Location = new Point(3, 53);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(193, 44);
            pnlDashboard.TabIndex = 1;
            // 
            // btndashboard
            // 
            btndashboard.BackColor = Color.Chocolate;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndashboard.ForeColor = Color.White;
            btndashboard.Image = Properties.Resources.dashboards;
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(-3, -7);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(214, 57);
            btndashboard.TabIndex = 0;
            btndashboard.Text = "Dashboard";
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btn1_Click;
            // 
            // menuContainor
            // 
            menuContainor.BackColor = Color.Chocolate;
            menuContainor.Controls.Add(pnlRequest);
            menuContainor.Controls.Add(panel11);
            menuContainor.Controls.Add(panel12);
            menuContainor.Controls.Add(panel9);
            menuContainor.Location = new Point(0, 100);
            menuContainor.Margin = new Padding(0);
            menuContainor.Name = "menuContainor";
            menuContainor.Size = new Size(201, 44);
            menuContainor.TabIndex = 6;
            menuContainor.Paint += flowLayoutPanel2_Paint;
            // 
            // pnlRequest
            // 
            pnlRequest.BackColor = Color.Chocolate;
            pnlRequest.Controls.Add(pictureBox2);
            pnlRequest.Controls.Add(btnRequest);
            pnlRequest.Location = new Point(0, 0);
            pnlRequest.Margin = new Padding(0);
            pnlRequest.Name = "pnlRequest";
            pnlRequest.Size = new Size(196, 44);
            pnlRequest.TabIndex = 8;
            pnlRequest.Paint += panel8_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_point_to_down;
            pictureBox2.Location = new Point(175, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 11);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.Chocolate;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Image = Properties.Resources.add;
            btnRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequest.Location = new Point(0, -9);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(201, 64);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "Request";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Chocolate;
            panel11.Controls.Add(btnNewRequest);
            panel11.Location = new Point(0, 44);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(214, 44);
            panel11.TabIndex = 9;
            // 
            // btnNewRequest
            // 
            btnNewRequest.BackColor = SystemColors.ControlLightLight;
            btnNewRequest.FlatStyle = FlatStyle.Flat;
            btnNewRequest.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewRequest.ForeColor = Color.Chocolate;
            btnNewRequest.Image = Properties.Resources.rec;
            btnNewRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewRequest.Location = new Point(0, -10);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Size = new Size(228, 69);
            btnNewRequest.TabIndex = 4;
            btnNewRequest.Text = "       Create new request";
            btnNewRequest.UseVisualStyleBackColor = false;
            btnNewRequest.Click += button7_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Chocolate;
            panel12.Controls.Add(btnSampleReport);
            panel12.Location = new Point(0, 88);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(214, 44);
            panel12.TabIndex = 10;
            // 
            // btnSampleReport
            // 
            btnSampleReport.BackColor = Color.White;
            btnSampleReport.FlatStyle = FlatStyle.Flat;
            btnSampleReport.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSampleReport.ForeColor = Color.Chocolate;
            btnSampleReport.Image = (Image)resources.GetObject("btnSampleReport.Image");
            btnSampleReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSampleReport.Location = new Point(0, -13);
            btnSampleReport.Name = "btnSampleReport";
            btnSampleReport.Size = new Size(228, 69);
            btnSampleReport.TabIndex = 4;
            btnSampleReport.Text = "Sample Report";
            btnSampleReport.UseVisualStyleBackColor = false;
            btnSampleReport.Click += btnSampleReport_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Chocolate;
            panel9.Controls.Add(btnRequestStatus);
            panel9.Location = new Point(0, 132);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(216, 49);
            panel9.TabIndex = 11;
            // 
            // btnRequestStatus
            // 
            btnRequestStatus.BackColor = Color.White;
            btnRequestStatus.FlatStyle = FlatStyle.Flat;
            btnRequestStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRequestStatus.ForeColor = Color.Chocolate;
            btnRequestStatus.Image = Properties.Resources.rec1;
            btnRequestStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequestStatus.Location = new Point(0, -14);
            btnRequestStatus.Name = "btnRequestStatus";
            btnRequestStatus.Size = new Size(216, 63);
            btnRequestStatus.TabIndex = 4;
            btnRequestStatus.Text = "    Request Status";
            btnRequestStatus.UseVisualStyleBackColor = false;
            btnRequestStatus.Click += btnRequestStatus_Click;
            // 
            // pnlChatbot
            // 
            pnlChatbot.BackColor = SystemColors.ActiveBorder;
            pnlChatbot.Controls.Add(button4);
            pnlChatbot.Location = new Point(3, 147);
            pnlChatbot.Name = "pnlChatbot";
            pnlChatbot.Size = new Size(193, 44);
            pnlChatbot.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Chocolate;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.chat_gpt__2_;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-3, -8);
            button4.Name = "button4";
            button4.Size = new Size(201, 57);
            button4.TabIndex = 4;
            button4.Text = "Chatbot";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pnlFeeback
            // 
            pnlFeeback.BackColor = SystemColors.ActiveBorder;
            pnlFeeback.Controls.Add(button1);
            pnlFeeback.Location = new Point(3, 197);
            pnlFeeback.Name = "pnlFeeback";
            pnlFeeback.Size = new Size(193, 44);
            pnlFeeback.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, -9);
            button1.Name = "button1";
            button1.Size = new Size(201, 57);
            button1.TabIndex = 1;
            button1.Text = "Feedback";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlSettings
            // 
            pnlSettings.BackColor = SystemColors.ActiveBorder;
            pnlSettings.Controls.Add(button2);
            pnlSettings.Location = new Point(3, 247);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new Size(193, 44);
            pnlSettings.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.setting;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, -12);
            button2.Name = "button2";
            button2.Size = new Size(201, 57);
            button2.TabIndex = 2;
            button2.Text = "Settings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnlExit
            // 
            pnlExit.BackColor = SystemColors.ActiveBorder;
            pnlExit.Controls.Add(button3);
            pnlExit.Location = new Point(3, 297);
            pnlExit.Name = "pnlExit";
            pnlExit.Size = new Size(193, 44);
            pnlExit.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.Chocolate;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.exit1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-3, -9);
            button3.Name = "button3";
            button3.Size = new Size(201, 57);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSouth);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(41, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 57);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images1;
            pictureBox1.Location = new Point(905, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblSouth
            // 
            lblSouth.AutoSize = true;
            lblSouth.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSouth.ForeColor = Color.White;
            lblSouth.Location = new Point(75, 18);
            lblSouth.Name = "lblSouth";
            lblSouth.Size = new Size(137, 28);
            lblSouth.TabIndex = 12;
            lblSouth.Text = "Main Page";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user__2_1;
            pictureBox3.Location = new Point(24, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 36);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // MainPage_1_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 450);
            Controls.Add(panel1);
            Controls.Add(sidebar);
            IsMdiContainer = true;
            Name = "MainPage_1_";
            Text = "Municipality Service Request Management System";
            Load += MainPage_1__Load;
            sidebar.ResumeLayout(false);
            pnlmenu.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            menuContainor.ResumeLayout(false);
            pnlRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel9.ResumeLayout(false);
            pnlChatbot.ResumeLayout(false);
            pnlFeeback.ResumeLayout(false);
            pnlSettings.ResumeLayout(false);
            pnlExit.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Button btndashboard;
        private Panel pnlDashboard;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel pnlFeeback;
        private Panel pnlSettings;
        private Panel pnlChatbot;
        private Button button4;
        private Panel pnlExit;
        private Button btnRequest;
        private Panel pnlRequest;
        private Button btnNewRequest;
        private Button btnSampleReport;
        private Button btnRequestStatus;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer menuTransition;
        private Panel panel11;
        private Panel panel9;
        private Panel panel12;
        private FlowLayoutPanel menuContainor;
        private Panel pnlmenu;
        private Button btnHam;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label lblSouth;
        private PictureBox pictureBox1;
    }
}