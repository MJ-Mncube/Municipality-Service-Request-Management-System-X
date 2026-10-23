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
    public partial class formStatusTracking : Form
    {
        public formStatusTracking()
        {
            InitializeComponent();

            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);
        }
    }
}
