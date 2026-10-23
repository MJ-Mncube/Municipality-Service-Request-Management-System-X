namespace Municipality_Service_Request_Management_System_X
{
    partial class formSettings
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
            lblSettingsTitle = new Label();
            lblAppearance = new Label();
            lblTheme = new Label();
            cmbTheme = new ComboBox();
            chkStatusUpdates = new CheckBox();
            chkAssignmentUpdates = new CheckBox();
            btnSaveSettings = new Button();
            btnCancel = new Button();
            lblSettingTitles = new Label();
            lblSettingsDescription = new Label();
            grpNotifications = new GroupBox();
            grpAppearance = new GroupBox();
            grpAccountSecurity = new GroupBox();
            label1 = new Label();
            btnChangePassword = new Button();
            grpNotifications.SuspendLayout();
            grpAppearance.SuspendLayout();
            grpAccountSecurity.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Location = new Point(40, 165);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(184, 25);
            lblSettingsTitle.TabIndex = 2;
            lblSettingsTitle.Text = "Application Settings";
            // 
            // lblAppearance
            // 
            lblAppearance.AutoSize = true;
            lblAppearance.Location = new Point(64, 208);
            lblAppearance.Name = "lblAppearance";
            lblAppearance.Size = new Size(114, 25);
            lblAppearance.TabIndex = 3;
            lblAppearance.Text = "Appearance";
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(9, 39);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(194, 28);
            lblTheme.TabIndex = 4;
            lblTheme.Text = "Appearance Theme";
            lblTheme.Click += lblTheme_Click;
            // 
            // cmbTheme
            // 
            cmbTheme.FormattingEnabled = true;
            cmbTheme.Items.AddRange(new object[] { "Light", "", "Dark" });
            cmbTheme.Location = new Point(255, 31);
            cmbTheme.Name = "cmbTheme";
            cmbTheme.Size = new Size(200, 36);
            cmbTheme.TabIndex = 5;
            // 
            // chkStatusUpdates
            // 
            chkStatusUpdates.AutoSize = true;
            chkStatusUpdates.Location = new Point(12, 33);
            chkStatusUpdates.Name = "chkStatusUpdates";
            chkStatusUpdates.Size = new Size(313, 32);
            chkStatusUpdates.TabIndex = 6;
            chkStatusUpdates.Text = "Enable request status update";
            chkStatusUpdates.UseVisualStyleBackColor = true;
            // 
            // chkAssignmentUpdates
            // 
            chkAssignmentUpdates.AutoSize = true;
            chkAssignmentUpdates.Location = new Point(12, 88);
            chkAssignmentUpdates.Name = "chkAssignmentUpdates";
            chkAssignmentUpdates.Size = new Size(364, 32);
            chkAssignmentUpdates.TabIndex = 7;
            chkAssignmentUpdates.Text = "Enable request assignment update";
            chkAssignmentUpdates.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = Color.DarkOrange;
            btnSaveSettings.Location = new Point(429, 564);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(212, 66);
            btnSaveSettings.TabIndex = 8;
            btnSaveSettings.Text = "Save changes";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkOrange;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(79, 564);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(218, 66);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblSettingTitles
            // 
            lblSettingTitles.AutoSize = true;
            lblSettingTitles.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingTitles.ForeColor = Color.DarkOrange;
            lblSettingTitles.Location = new Point(33, 5);
            lblSettingTitles.Name = "lblSettingTitles";
            lblSettingTitles.Size = new Size(177, 54);
            lblSettingTitles.TabIndex = 10;
            lblSettingTitles.Text = "Settings";
            // 
            // lblSettingsDescription
            // 
            lblSettingsDescription.AutoSize = true;
            lblSettingsDescription.ForeColor = Color.DimGray;
            lblSettingsDescription.Location = new Point(36, 60);
            lblSettingsDescription.Name = "lblSettingsDescription";
            lblSettingsDescription.Size = new Size(371, 25);
            lblSettingsDescription.TabIndex = 11;
            lblSettingsDescription.Text = "Manage your preference and notifications";
            // 
            // grpNotifications
            // 
            grpNotifications.Controls.Add(chkStatusUpdates);
            grpNotifications.Controls.Add(chkAssignmentUpdates);
            grpNotifications.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpNotifications.ForeColor = Color.DarkOrange;
            grpNotifications.Location = new Point(28, 105);
            grpNotifications.Name = "grpNotifications";
            grpNotifications.Size = new Size(704, 145);
            grpNotifications.TabIndex = 12;
            grpNotifications.TabStop = false;
            grpNotifications.Text = "Notifications";
            // 
            // grpAppearance
            // 
            grpAppearance.Controls.Add(lblTheme);
            grpAppearance.Controls.Add(cmbTheme);
            grpAppearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAppearance.ForeColor = Color.DarkOrange;
            grpAppearance.Location = new Point(28, 270);
            grpAppearance.Name = "grpAppearance";
            grpAppearance.Size = new Size(759, 106);
            grpAppearance.TabIndex = 13;
            grpAppearance.TabStop = false;
            grpAppearance.Text = "Appearence";
            // 
            // grpAccountSecurity
            // 
            grpAccountSecurity.Controls.Add(label1);
            grpAccountSecurity.Controls.Add(btnChangePassword);
            grpAccountSecurity.ForeColor = Color.DarkOrange;
            grpAccountSecurity.Location = new Point(28, 390);
            grpAccountSecurity.Name = "grpAccountSecurity";
            grpAccountSecurity.Size = new Size(759, 168);
            grpAccountSecurity.TabIndex = 14;
            grpAccountSecurity.TabStop = false;
            grpAccountSecurity.Text = "Account and Security";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 60);
            label1.Name = "label1";
            label1.Size = new Size(449, 25);
            label1.TabIndex = 1;
            label1.Text = "Update your password to keep your account secure";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(503, 55);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(184, 34);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(839, 699);
            Controls.Add(grpAccountSecurity);
            Controls.Add(grpAppearance);
            Controls.Add(grpNotifications);
            Controls.Add(lblSettingsDescription);
            Controls.Add(lblSettingTitles);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveSettings);
            Controls.Add(lblAppearance);
            Controls.Add(lblSettingsTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "formSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += formSettings_Load;
            grpNotifications.ResumeLayout(false);
            grpNotifications.PerformLayout();
            grpAppearance.ResumeLayout(false);
            grpAppearance.PerformLayout();
            grpAccountSecurity.ResumeLayout(false);
            grpAccountSecurity.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSettingsTitle;
        private Label lblAppearance;
        private Label lblTheme;
        private ComboBox cmbTheme;
        private CheckBox chkStatusUpdates;
        private CheckBox chkAssignmentUpdates;
        private Button btnSaveSettings;
        private Button btnCancel;
        private Label lblSettingTitles;
        private Label lblSettingsDescription;
        private GroupBox grpNotifications;
        private GroupBox grpAppearance;
        private GroupBox grpAccountSecurity;
        private Button btnChangePassword;
        private Label label1;
    }
}