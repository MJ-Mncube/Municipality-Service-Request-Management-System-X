//LOGIN PAGE
using static System.Windows.Forms.LinkLabel;
using Microsoft.VisualBasic;

namespace Municipality_Service_Request_Management_System_X
{
    public partial class frmLoginPage : Form
    {
        //Global Declaration of Class
        private clsVerify objVerify = new clsVerify();
        //Path to textfile
        string filepath = @"C:\Users\User\Documents\Lagash ltd\Residents.txt";
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLoginBackGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {//"UserID|Name|Surname|Age|Gender|Race|Email|ID|Phone|Password"

            Highlight();//Highlights empty or invalid fiels

            //Reading textfile to check if they match login details
            if (!File.Exists(filepath))
            {
                MessageBox.Show("File not found");
                return;
            }
            string line = "";
            string[] lineArray = new string[10];
            string email = "";
            string Password = "";

            string inputEmail = tbxEmail.Text;
            string inputPassword = tbxPassword.Text;

            bool emailFound = false;
            bool loginCorrect = false;

            if (string.IsNullOrEmpty(inputPassword))
            {
                lblWpassword.Text = "Please enter a password";
                return;
            }
            if (string.IsNullOrEmpty(inputEmail))
            {
                lblEmailVerify.Text = "Please enter an email";
                return;
            }

            StreamReader reader = new StreamReader(filepath);
            using (reader)
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    lineArray = line.Split('|');
                    if (lineArray.Length < 10)
                    {
                        line = reader.ReadLine();
                        continue;
                    }
                    email = lineArray[6];
                    Password = lineArray[9];

                    if (email.Equals(inputEmail))
                    {
                        emailFound = true;
                        // pnlSignalEmail.BackColor = Color.Red;

                        if (Password.Equals(inputPassword))
                        {
                            loginCorrect = true;
                            //  pnlPass.BackColor = Color.Green;
                        }
                        else
                        {


                            // pnlPass.BackColor = Color.Red;
                            lblWpassword.Text = "Incorrect Password and/or Email";

                        }

                        break;
                    }

                    line = reader.ReadLine();
                }
            }
            if (!emailFound)
            {
                lblWpassword.Text = "Incorrect Password and/or Email";
                // pnlSignalEmail.BackColor = Color.Red;
            }
            // Login successful
            if (loginCorrect)
            {
                // SAVE THE EMAIL HERE!
                UserSession.LoggedInEmail = inputEmail;

                MainPage_1_ MainPage = new MainPage_1_();
                MainPage.Show();
                this.Hide();
            }
           
        }

        private void pbxLockPassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
            {
                tbxPassword.PasswordChar = '●';
            }
            else if (tbxPassword.PasswordChar == '●')
            {
                tbxPassword.PasswordChar = '\0';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Navigate from login to sign up
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Navigate from login to sign up
            MainPage_1_ MainPage = new MainPage_1_();
            MainPage.Show();
            this.Hide();
        }
        private void Highlight()
        {
            //////Using clsVerify class to verify email
            string sEmail;
            sEmail = tbxEmail.Text;
            string sResult = objVerify.VerifyEmail(sEmail);
            lblEmailVerify.Text = sResult;

            //////Color indicator for email verification
            if (sResult.Contains("Email") || (objVerify.emptyCheck(tbxPassword.Text) != ""))
            {
                pnlSignalEmail.BackColor = Color.Red;
                pnlPass.BackColor = Color.Red;
            }
            else if ((objVerify.emptyCheck(tbxEmail.Text) == "") || sResult == "")
            {
                pnlSignalEmail.BackColor = Color.Green;
                pnlPass.BackColor = Color.Green;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Updating the textfile for the forgotten password
            /*Show new button
             * Search for account through email
             * send an email for OTP
             * if found user must enter a new password
             * ask user to confirm if they want to change password 
             * after confirmation it must go back to regular login procedure
             */


            //SM0708|Simamkele|Mncube|19|Male|Black|simamkelemncube@gmail.com|0708296350083|0760458770|Mzilankatha (sample textfile)

            string email = tbxEmail.Text;
            string Password = tbxPassword.Text;

            string confirmEmail = Interaction.InputBox("Enter your email ", "Email address");

            //Verify email and Check if email exists
            if ((objVerify.VerifyEmail(confirmEmail) != ""))
            {
                MessageBox.Show("Invalid email address");
                return;
            }


            bool bfound = false;
            string[] line = File.ReadAllLines(filepath);

            string searchEmail = "";

            for (int i = 0; i < line.Length; i++)
            {
                string[] lineArray = line[i].Split('|');
                if (lineArray.Length < 10)
                {
                    continue;
                }
                searchEmail = lineArray[6];
                if (searchEmail.Equals(confirmEmail, StringComparison.OrdinalIgnoreCase))
                {
                    bfound = true;

                    // Prompt for new password
                    string newPassword = Interaction.InputBox("Enter your new password", "Change Password");

                    // Confirmation dialog
                    DialogResult dialogue = MessageBox.Show(
                        "Are you sure you want to change your password?",
                        "Confirm change",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    switch (dialogue)
                    {
                        case DialogResult.Yes:
                            lineArray[9] = newPassword;

                            // Rebuild the line string
                            line[i] = string.Join("|", lineArray);

                            // CRITICAL: Save the updated lines back to the text file!
                            File.WriteAllLines(filepath, line);

                            MessageBox.Show("Password updated successfully!");
                            break;

                        case DialogResult.No:
                            MessageBox.Show("Password change cancelled.");
                            break;
                    }

                    break; // Stop searching once we found and processed the user
                }
            }

            // If the loop finishes and bfound is still false, the email wasn't in the file
            if (!bfound)
            {
                MessageBox.Show("Email not found");
            }


        }





        private void button2_Click(object sender, EventArgs e)
        {
            formUsers users = new formUsers();
            users.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
