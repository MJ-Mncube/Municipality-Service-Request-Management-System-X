using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipality_Service_Request_Management_System_X
{
    public partial class frmChangePassword : Form
    {
        private string residentEmail;

        public frmChangePassword(string email)
        {
            InitializeComponent();
            residentEmail = email;
        }

        private void btnCancelPassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check that no fields are empty.
            if (string.IsNullOrWhiteSpace(currentPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all password fields.");
                return;
            }

            // Check the minimum password length.
            if (newPassword.Length < 8)
            {
                MessageBox.Show("Your new password must be at least 8 characters long.");
                return;
            }

            // Check that the new password differs from the current one.
            if (newPassword == currentPassword)
            {
                MessageBox.Show("Your new password must be different from your current password.");
                return;
            }

            // Check that both new-password entries match.
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new passwords do not match.");
                return;
            }

            string filepath = Path.Combine(
    Application.StartupPath, "Residents.txt");

            try
            {
                if (!File.Exists(filepath))
                {
                    MessageBox.Show("Resident records file was not found.");
                    return;
                }

                string[] lines = File.ReadAllLines(filepath);
                bool residentFound = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] lineArray = lines[i].Split('|');

                    // Each resident record has 10 fields.
                    if (lineArray.Length < 10)
                    {
                        continue;
                    }

                    // Email is field 7 (index 6); password is field 10 (index 9).
                    if (lineArray[6].Equals(
                        residentEmail,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        residentFound = true;

                        // Confirm the current password is correct.
                        if (lineArray[9] != currentPassword)
                        {
                            MessageBox.Show("Your current password is incorrect.");
                            return;
                        }

                        // Update only the password field.
                        lineArray[9] = newPassword;
                        lines[i] = string.Join("|", lineArray);
                        break;
                    }
                }

                if (!residentFound)
                {
                    MessageBox.Show("Resident account was not found.");
                    return;
                }

                File.WriteAllLines(filepath, lines);

                MessageBox.Show("Your password has been changed successfully!");

                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update the password: " + ex.Message);
            }
        }
    }
}
