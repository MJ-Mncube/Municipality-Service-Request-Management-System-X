namespace Municipality_Service_Request_Management_System_X
{
    partial class frmChangePassword
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
            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSavePassword = new Button();
            btnCancelPassword = new Button();
            SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPassword.Location = new Point(12, 32);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(161, 25);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(12, 150);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(150, 28);
            lblNewPassword.TabIndex = 1;
            lblNewPassword.Text = "New password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(12, 261);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(228, 28);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm new password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(12, 75);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(150, 31);
            txtCurrentPassword.TabIndex = 3;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(12, 181);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(150, 31);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(12, 303);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(150, 31);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseWaitCursor = true;
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = Color.DarkOrange;
            btnSavePassword.Location = new Point(1, 433);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(180, 46);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Save Password";
            btnSavePassword.UseVisualStyleBackColor = false;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // btnCancelPassword
            // 
            btnCancelPassword.BackColor = Color.DarkOrange;
            btnCancelPassword.Location = new Point(196, 433);
            btnCancelPassword.Name = "btnCancelPassword";
            btnCancelPassword.Size = new Size(180, 46);
            btnCancelPassword.TabIndex = 7;
            btnCancelPassword.Text = "Cancel";
            btnCancelPassword.UseVisualStyleBackColor = false;
            btnCancelPassword.Click += btnCancelPassword_Click;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1091, 529);
            Controls.Add(btnCancelPassword);
            Controls.Add(btnSavePassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnSavePassword;
        private Button btnCancelPassword;
    }
}