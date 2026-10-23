using System;
using System.IO; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipality_Service_Request_Management_System_X
{
    public partial class formSettings : Form
    {
        private string residentEmail;

        public formSettings(string email)

        {
            InitializeComponent();
            residentEmail = email;
            this.BackColor = Color.FromArgb(247, 243, 240);
            lblSettingsTitle.ForeColor = Color.FromArgb(199, 71, 36);

            btnCancel.Click += btnCancel_Click;

            LoadSettings();
            ApplyCurrentTheme();


        }

        private void ApplyCurrentTheme()
        {
            string selectedTheme = cmbTheme.Text.Trim();

            ThemeManager.IsDark =
                selectedTheme.Equals(
                    "Dark",
                    StringComparison.OrdinalIgnoreCase);

            ThemeManager.ApplyTheme(this);
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                // Apply the selected theme.
                ApplyCurrentTheme();



                MessageBox.Show(
    "Selected theme: " + cmbTheme.Text +
    "\nDark mode enabled: " + ThemeManager.IsDark);




                // Save the settings to the file.
                string filePath = Path.Combine(
                    Application.StartupPath, "settings.txt");

                string[] settings =
                {
            "Theme=" + cmbTheme.Text,
            "StatusUpdates=" + chkStatusUpdates.Checked,
            "AssignmentUpdates=" + chkAssignmentUpdates.Checked
        };

                File.WriteAllLines(filePath, settings);

                MessageBox.Show("Settings saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save settings: " + ex.Message);
            }
        }


        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadSettings()
        {
            string filePath = Path.Combine(
        Application.StartupPath, "settings.txt");

            // Use default settings if the file does not exist.
            if (!File.Exists(filePath))
            {
                cmbTheme.Text = "Light";
                chkStatusUpdates.Checked = true;
                chkAssignmentUpdates.Checked = true;
                return;
            }

            try
            {
                string[] settings = File.ReadAllLines(filePath);

                foreach (string setting in settings)
                {
                    string[] parts = setting.Split('=');

                    if (parts.Length != 2)
                    {
                        continue;
                    }

                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    if (key == "Theme")
                    {
                        cmbTheme.Text = value;
                    }
                    else if (key == "StatusUpdates")
                    {
                        chkStatusUpdates.Checked =
                            bool.Parse(value);
                    }
                    else if (key == "AssignmentUpdates")
                    {
                        chkAssignmentUpdates.Checked =
                            bool.Parse(value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load settings: " + ex.Message);
            }
        }


        private void formSettings_Load(object sender, EventArgs e)
        {

        }

        private void lblTheme_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword =
    new frmChangePassword(residentEmail);
            {
                changePassword.ShowDialog(this);
            }
        }
    }
}
