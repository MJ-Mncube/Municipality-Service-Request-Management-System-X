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
    public partial class formChatBot : Form
    {
        public formChatBot()
        {
            InitializeComponent();

            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);
        }
    }
}
