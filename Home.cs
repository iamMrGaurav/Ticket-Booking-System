using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            ReadEntryRecord();

            if (GlobalVariable.isAdmin == true)
            {
                ticketMenu.Enabled = true;
            }
            else
            {
                ticketMenu.Visible = false;
             
            }


            
            string[] ticketRates = File.ReadAllLines("F:\\Cw_Ad\\TicketRate.csv");
            GlobalClass.tickets.Clear();

            for (int i = 0; i < ticketRates.Length; i++) {

               
                var row = ticketRates[i].Split(',');
                TicketModel ticketModel = new TicketModel
                {
                    id = Convert.ToInt32(row[0]),
                    category = (row[1]),
                    type = (row[2]),
                    rateOneHr = Convert.ToInt32(row[3]),
                    rateTwoHr = Convert.ToInt32(row[4]),
                    rateThreeHr = Convert.ToInt32(row[5]),
                    rateFourHr = Convert.ToInt32(row[6]),
                    rateWholeDay = Convert.ToInt32(row[7])
                };
                GlobalClass.tickets.Add(ticketModel);
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

        public void ReadEntryRecord()
        {
            string[] record = File.ReadAllLines("F:\\Cw_Ad\\DataRecord.csv");
            GlobalVariable.records.Clear();

            for (int initial = 0; initial < record.Length; initial++)
            {
                var row = record[initial].Split(',');
                Record entryRecord = new Record
                {
                    idRecord = Convert.ToInt32(row[0]),
                    categoryRecord = (row[1]),
                    typeRecord = (row[2]),
                    countRecord = Convert.ToInt32(row[3]),
                    entryTimeRecord = DateTime.Parse(row[4]),
                    exitTimeRecord = DateTime.Parse(row[5]),
                    entryCostRecord = Convert.ToInt32(row[6]),
                    isLeftRecord = bool.Parse(row[7]),
                };
                GlobalVariable.records.Add(entryRecord);

            }
        }


    }
}
