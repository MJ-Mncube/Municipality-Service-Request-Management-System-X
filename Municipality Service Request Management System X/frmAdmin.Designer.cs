namespace Municipality_Service_Request_Management_System_X
{
    partial class frmAdmin
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
            tbcAdmin = new TabControl();
            tpUsers = new TabPage();
            panel4 = new Panel();
            rbtDetails = new RichTextBox();
            panel3 = new Panel();
            btnSORT = new Button();
            label14 = new Label();
            rbtRace = new RadioButton();
            rbtGender = new RadioButton();
            label13 = new Label();
            rbtAge = new RadioButton();
            button1 = new Button();
            label12 = new Label();
            txtPassword = new TextBox();
            label11 = new Label();
            txtPhone = new TextBox();
            label10 = new Label();
            txtID = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtRace = new TextBox();
            label7 = new Label();
            txtGender = new TextBox();
            label6 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            txtSurname = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtUserID = new TextBox();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            tpRequest = new TabPage();
            tbcAdmin.SuspendLayout();
            tpUsers.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbcAdmin
            // 
            tbcAdmin.Controls.Add(tpUsers);
            tbcAdmin.Controls.Add(tpRequest);
            tbcAdmin.Dock = DockStyle.Fill;
            tbcAdmin.Location = new Point(0, 0);
            tbcAdmin.Name = "tbcAdmin";
            tbcAdmin.SelectedIndex = 0;
            tbcAdmin.Size = new Size(1370, 678);
            tbcAdmin.TabIndex = 0;
            tbcAdmin.SelectedIndexChanged += tbcAdmin_SelectedIndexChanged;
            // 
            // tpUsers
            // 
            tpUsers.Controls.Add(panel4);
            tpUsers.Controls.Add(panel3);
            tpUsers.Controls.Add(button1);
            tpUsers.Controls.Add(label12);
            tpUsers.Controls.Add(txtPassword);
            tpUsers.Controls.Add(label11);
            tpUsers.Controls.Add(txtPhone);
            tpUsers.Controls.Add(label10);
            tpUsers.Controls.Add(txtID);
            tpUsers.Controls.Add(label9);
            tpUsers.Controls.Add(txtEmail);
            tpUsers.Controls.Add(label8);
            tpUsers.Controls.Add(txtRace);
            tpUsers.Controls.Add(label7);
            tpUsers.Controls.Add(txtGender);
            tpUsers.Controls.Add(label6);
            tpUsers.Controls.Add(txtAge);
            tpUsers.Controls.Add(label5);
            tpUsers.Controls.Add(txtSurname);
            tpUsers.Controls.Add(label4);
            tpUsers.Controls.Add(txtName);
            tpUsers.Controls.Add(label3);
            tpUsers.Controls.Add(txtUserID);
            tpUsers.Controls.Add(btnLoad);
            tpUsers.Controls.Add(dataGridView1);
            tpUsers.Controls.Add(panel2);
            tpUsers.Controls.Add(panel1);
            tpUsers.Location = new Point(4, 24);
            tpUsers.Name = "tpUsers";
            tpUsers.Padding = new Padding(3);
            tpUsers.Size = new Size(1362, 650);
            tpUsers.TabIndex = 0;
            tpUsers.Text = "USER";
            tpUsers.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(rbtDetails);
            panel4.Dock = DockStyle.Bottom;
            panel4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(165, 547);
            panel4.Name = "panel4";
            panel4.Size = new Size(1053, 100);
            panel4.TabIndex = 26;
            // 
            // rbtDetails
            // 
            rbtDetails.BackColor = Color.FromArgb(64, 64, 64);
            rbtDetails.Dock = DockStyle.Fill;
            rbtDetails.ForeColor = Color.White;
            rbtDetails.Location = new Point(0, 0);
            rbtDetails.Name = "rbtDetails";
            rbtDetails.Size = new Size(1053, 100);
            rbtDetails.TabIndex = 0;
            rbtDetails.Text = "";
            rbtDetails.TextChanged += rbtdetails_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(btnSORT);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(rbtRace);
            panel3.Controls.Add(rbtGender);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(rbtAge);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1218, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 580);
            panel3.TabIndex = 25;
            // 
            // btnSORT
            // 
            btnSORT.FlatStyle = FlatStyle.Flat;
            btnSORT.ForeColor = Color.White;
            btnSORT.Location = new Point(3, 149);
            btnSORT.Name = "btnSORT";
            btnSORT.Size = new Size(135, 23);
            btnSORT.TabIndex = 11;
            btnSORT.Text = "SORT";
            btnSORT.UseVisualStyleBackColor = true;
            btnSORT.Click += btnSORT_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(9, 39);
            label14.Name = "label14";
            label14.Size = new Size(61, 18);
            label14.TabIndex = 10;
            label14.Text = "Sort By:";
            // 
            // rbtRace
            // 
            rbtRace.AutoSize = true;
            rbtRace.ForeColor = Color.White;
            rbtRace.Location = new Point(14, 124);
            rbtRace.Name = "rbtRace";
            rbtRace.Size = new Size(50, 19);
            rbtRace.TabIndex = 9;
            rbtRace.TabStop = true;
            rbtRace.Text = "Race";
            rbtRace.UseVisualStyleBackColor = true;
            // 
            // rbtGender
            // 
            rbtGender.AutoSize = true;
            rbtGender.ForeColor = Color.White;
            rbtGender.Location = new Point(14, 99);
            rbtGender.Name = "rbtGender";
            rbtGender.Size = new Size(63, 19);
            rbtGender.TabIndex = 8;
            rbtGender.TabStop = true;
            rbtGender.Text = "Gender";
            rbtGender.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(29, 0);
            label13.Name = "label13";
            label13.Size = new Size(85, 23);
            label13.TabIndex = 7;
            label13.Text = "Controls";
            // 
            // rbtAge
            // 
            rbtAge.AutoSize = true;
            rbtAge.ForeColor = Color.White;
            rbtAge.Location = new Point(14, 68);
            rbtAge.Name = "rbtAge";
            rbtAge.Size = new Size(46, 19);
            rbtAge.TabIndex = 6;
            rbtAge.TabStop = true;
            rbtAge.Text = "Age";
            rbtAge.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(194, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "READ LINE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label12.Location = new Point(809, 332);
            label12.Name = "label12";
            label12.Size = new Size(75, 18);
            label12.TabIndex = 23;
            label12.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(809, 353);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(170, 23);
            txtPassword.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label11.Location = new Point(613, 454);
            label11.Name = "label11";
            label11.Size = new Size(117, 18);
            label11.TabIndex = 21;
            label11.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(613, 475);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(170, 23);
            txtPhone.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label10.Location = new Point(613, 393);
            label10.Name = "label10";
            label10.Size = new Size(27, 18);
            label10.TabIndex = 19;
            label10.Text = " ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(613, 418);
            txtID.Name = "txtID";
            txtID.Size = new Size(170, 23);
            txtID.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label9.Location = new Point(613, 332);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 17;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(613, 353);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 23);
            txtEmail.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label8.Location = new Point(412, 454);
            label8.Name = "label8";
            label8.Size = new Size(47, 18);
            label8.TabIndex = 15;
            label8.Text = "Race";
            // 
            // txtRace
            // 
            txtRace.Location = new Point(412, 475);
            txtRace.Name = "txtRace";
            txtRace.Size = new Size(170, 23);
            txtRace.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label7.Location = new Point(412, 393);
            label7.Name = "label7";
            label7.Size = new Size(65, 18);
            label7.TabIndex = 13;
            label7.Text = "Gender";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(412, 418);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(170, 23);
            txtGender.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label6.Location = new Point(412, 332);
            label6.Name = "label6";
            label6.Size = new Size(39, 18);
            label6.TabIndex = 11;
            label6.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(412, 353);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(170, 23);
            txtAge.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label5.Location = new Point(194, 454);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 9;
            label5.Text = "Surname";
            // 
            // txtSurname
            // 
            txtSurname.Cursor = Cursors.IBeam;
            txtSurname.Location = new Point(194, 475);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(170, 23);
            txtSurname.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label4.Location = new Point(194, 393);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 418);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 23);
            txtName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label3.Location = new Point(194, 332);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 5;
            label3.Text = "User ID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(194, 353);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(170, 23);
            txtUserID.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(194, 73);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(194, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 175);
            dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 580);
            panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(5, 97);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(154, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE DETAILS";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(5, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE RESIDENT";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(5, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD RESIDENT";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 1;
            label2.Text = "Controls";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1356, 64);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(589, 18);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 0;
            label1.Text = "User Managment";
            // 
            // tpRequest
            // 
            tpRequest.Location = new Point(4, 24);
            tpRequest.Name = "tpRequest";
            tpRequest.Padding = new Padding(3);
            tpRequest.Size = new Size(1362, 650);
            tpRequest.TabIndex = 1;
            tpRequest.Text = "REQUEST";
            tpRequest.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 678);
            Controls.Add(tbcAdmin);
            Name = "frmAdmin";
            Text = "frmAdmin";
            WindowState = FormWindowState.Maximized;
            tbcAdmin.ResumeLayout(false);
            tpUsers.ResumeLayout(false);
            tpUsers.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcAdmin;
        private TabPage tpUsers;
        private Panel panel2;
        private Panel panel1;
        private TabPage tpRequest;
        private Label label1;
        private Button btnAdd;
        private Label label2;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Button btnLoad;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtUserID;
        private Label label11;
        private TextBox txtPhone;
        private Label label10;
        private TextBox txtID;
        private Label label9;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtRace;
        private Label label7;
        private TextBox txtGender;
        private Label label6;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtSurname;
        private Label label12;
        private TextBox txtPassword;
        private Button button1;
        private Panel panel3;
        private RadioButton rbtAge;
        private Label label13;
        private RadioButton rbtGender;
        private Label label14;
        private RadioButton rbtRace;
        private Button btnSORT;
        private Panel panel4;
        private RichTextBox rbtDetails;
    }
}