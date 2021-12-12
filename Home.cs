using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkAD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new TicketForm());
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
            private void Home_Load(object sender, EventArgs e)
        {
            if (GlobalVariable.isAdmin == true)
            {
                ticketMenu.Enabled = true;
            }
            else
            {
                ticketMenu.Visible = false;
             
            }


        }

        public void loadform(object Form)
        {
            if (this.homePanel.Controls.Count > 0)
                this.homePanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.homePanel.Controls.Add(f);
            this.homePanel.Tag = f;
            f.Show();



        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new EntryForm());
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loadform(new ExitForm());
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new TicketForm());
        }

        private void weeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new WeeklyReportForm());
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new DailyReportForm());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadform(new LoginScreen());
            
        }
    }
}
