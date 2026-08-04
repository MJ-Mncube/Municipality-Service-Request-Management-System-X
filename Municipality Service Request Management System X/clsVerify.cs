using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Municipality_Service_Request_Management_System_X
{
    public class clsVerify///Class we will use to verify details
    {
        ///////Simamukele Mncube

        public string VerifyEmail(string Email)
        {
            if (Email == "" || Email == null)
            {
                return "Enter Email";
                
            }
            else if (!Email.Contains("@") || !Email.Contains("."))
            {
                return "Invalid Email";
                
            }
            return "";
        }
        
    }
}
