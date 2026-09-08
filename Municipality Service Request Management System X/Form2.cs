using System;
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
    public partial class frmSignUp : Form
    {   //Global decleration of class
        private clsVerify objVerify = new clsVerify();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            //////Using clsVerify class to verify email
            string sEmail;
            sEmail = tbxEmail.Text;
            string sResult = objVerify.VerifyEmail(sEmail);
            lblWarning.Text = sResult;

            //////Color indicator for email verification
            if (sResult.Contains("Email"))
            {
                pnlSignalEmail.BackColor = Color.Red;
                 sEmail = "";
            }
            else
            {
                pnlSignalEmail.BackColor = Color.Green;
            }
            //Using clsVerify to veriFy ID
            string ID;
            ID = (tbxID.Text);
            string sresultID = objVerify.VerifyID(ID);
            lblWarningID.Text = sresultID;
            if (sresultID.Contains("ID"))
            {
                pnlIDsignal.BackColor = Color.Red;
                ID = "";
            }
            else
            {
               pnlIDsignal.BackColor = Color.Green;
            }//extracting information from ID number
           
            string IDDigits = tbxID.Text;
            
            //Age
            int age = objVerify.AgeID((IDDigits));
            //gender
            string gender = objVerify.GenderID((IDDigits));
            //Race
            string race = objVerify.raceID((IDDigits));
            MessageBox.Show("Age:" + age + "\nGender:" + gender + "\nRace:" + race);


            //Changed entry of ID into string because the ID number is too long to be stored as an integer
        }
    }
}
