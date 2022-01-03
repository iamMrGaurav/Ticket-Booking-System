using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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


        //This function ovveride the existing function close the application
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




            //Clear the previous ticket data
            GlobalClass.tickets.Clear();


            Deserialize();
            loadform(new HomePage());

        }

        //This function deserialize the data
        public void Deserialize()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("F:\\Cw_Ad\\CSV files\\serializeData.csv", FileMode.Open, FileAccess.Read);
            stream.Position = 0;
            GlobalClass.tickets = (List<TicketModel>)formatter.Deserialize(stream);
            stream.Close();

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
            string[] record = File.ReadAllLines("F:\\Cw_Ad\\CSV files\\DataRecord.csv");
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



        //This method load login screen page
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            new LoginScreen().Show();

        }



        private void homeMenusStripButton_Click(object sender, EventArgs e)
        {
            loadform(new HomePage());
        }
    }
}
