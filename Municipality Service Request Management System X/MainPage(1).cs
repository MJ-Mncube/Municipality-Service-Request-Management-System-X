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

    public partial class MainPage_1_ : Form
    {
        formDashboard dashboard;
        formChatBot chatbot;
        formFeedback feedback;
        formRequest request;
        formStatusTracking statusTracking;
        //about form
        formSampleReport sampleReport;
        formSettings settings;

        public MainPage_1_()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLoginPage MainPage = new frmLoginPage();
            MainPage.Show();
            this.Hide();

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (request == null)
            {
                request = new formRequest();
                request.FormClosed += request_FormClosed;
                request.MdiParent = this;
                request.Dock = DockStyle.Fill;//
                request.Show();
            }
            else
            {
                request.Activate();
            }
            lblSouth.Text = "New Request";
            sidebar.Width = 41;
        }
        private void request_FormClosed(object? sender, FormClosedEventArgs e)
        {
            request = null;
        }
        //Animation for the menu panel
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainor.Height += 10;
                if (menuContainor.Height >= 181)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainor.Height -= 10;
                if (menuContainor.Height <= 44)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //starts animation
            menuTransition.Start();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPage_1__Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
            lblSouth.Text = "Dashboard";
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        //Animation for the sidebar flowchart Panel
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 41)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();


                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 196)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnlDashboard.Width = sidebar.Width;
                    pnlChatbot.Width = sidebar.Width;
                    pnlExit.Width = sidebar.Width;
                    pnlFeeback.Width = sidebar.Width;
                    pnlSettings.Width = sidebar.Width;
                    menuContainor.Width = sidebar.Width;
                    pnlmenu.Width = sidebar.Width;
                }
            }

        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSampleReport_Click(object sender, EventArgs e)
        {
            ///////////////////
            if (sampleReport == null)
            {
                sampleReport = new formSampleReport();
                sampleReport.FormClosed += SampleReport_FormClosed;
                sampleReport.MdiParent = this;
                sampleReport.Dock = DockStyle.Fill;
                sampleReport.Show();
            }
            else
            {
                sampleReport.Activate();
            }
            lblSouth.Text = "Request Report";
        }
        private void SampleReport_FormClosed(object? sender, FormClosedEventArgs e)
        {
            sampleReport = null;
        }

        private void btnRequestStatus_Click(object sender, EventArgs e)
        {
            if (statusTracking == null)
            {
                statusTracking = new formStatusTracking();
                statusTracking.FormClosed += StatusTracking_FormClosed;
                statusTracking.MdiParent = this;
                statusTracking.Dock = DockStyle.Fill;
                statusTracking.Show();
            }
            else
            {
                statusTracking.Activate();
            }
            lblSouth.Text = "Request Status Tracking";
        }
        private void StatusTracking_FormClosed(object? sender, FormClosedEventArgs e)
        {
            statusTracking = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chatbot == null)
            {
                chatbot = new formChatBot();
                chatbot.FormClosed += Chatbot_FormClosed;
                chatbot.MdiParent = this;
                chatbot.Dock = DockStyle.Fill;
                chatbot.Show();
            }
            else
            {
                chatbot.Activate();
            }
            lblSouth.Text = "Chatbot";

        }
        private void Chatbot_FormClosed(object? sender, FormClosedEventArgs e)
        {
            chatbot = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new formSettings();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
            lblSouth.Text = "Settings";
        }
        private void Settings_FormClosed(object? sender, FormClosedEventArgs e)
        {
            settings = null;
        }
        // button1_Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (feedback == null)
            {
                feedback = new formFeedback();
                feedback.FormClosed += Feedback_FormClosed;
                feedback.MdiParent = this;
                feedback.Dock = DockStyle.Fill;
                feedback.Show();
            }
            else
            {
                feedback.Activate();
            }
            lblSouth.Text = "Feedback";
        }
        private void Feedback_FormClosed(object? sender, FormClosedEventArgs e)
        {
            feedback = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}