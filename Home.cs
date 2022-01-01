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
            timer1.Start();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        //This method runs when home page load at first
        private void Home_Load(object sender, EventArgs e)
        {

            ReadEntryRecord();



            // This if condition check if user is admin or not
            if (GlobalVariable.isAdmin == true)
            {
                ticketMenu.Enabled = true;
            }
            else
            {
                ticketMenu.Visible = false;
            }


            //Store TicketRate.csv data into the ticketRates list
            string[] ticketRates = File.ReadAllLines("F:\\Cw_Ad\\TicketRate.csv");

            //Clear the previous ticket data
            GlobalClass.tickets.Clear();


            for (int i = 0; i < ticketRates.Length; i++)
            {

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
            loadform(new HomePage());
    
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



        //This method load entry form page
        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new EntryForm());
        }

        //This method load exit form page
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loadform(new ExitForm());
        }

        //This method load Ticket form page
        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new TicketForm());
        }

        //This method load Weekly Report  page
        private void weeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new WeeklyReportForm());
        }

        //This method load daily Report  page
        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new DailyReportForm());
        }


        //This method read dataRecord csv data and add to the class
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


        //This method labeled the real time date and time 
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void ticketData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //This method add ticket data to the ticket data table


        //This method add record data to the ticket Data table

        private void ticketRateButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewRecordButton_CheckedChanged(object sender, EventArgs e)
        {

        }






        //This method load login screen page
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            new LoginScreen().Show();
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeMenusStripButton_Click(object sender, EventArgs e)
        {
            loadform(new HomePage());
        }
    }
}
