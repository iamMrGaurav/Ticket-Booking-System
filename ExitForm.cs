using System;
using System.IO;
using System.Windows.Forms;

namespace CourseworkAD
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        //Object of record 
        Record record = null;

        /*
         
         This method search detaile according to id enter by user.

         */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(idTextBox.Text);

                foreach (Record data in GlobalVariable.records)
                {
                    if (data.idRecord == ID)
                    {
                        record = data;

                    }

                }

                if (record != null)
                {
                    if (!record.isLeftRecord)
                    {
                        record.exitTimeRecord = DateTime.Now;
                        confirmButton.Visible = true;


                    }
                    else
                    {

                        confirmButton.Visible = false;
                    }

                    //Data initialize from record class to label texts
                    idTextBox.Text = record.idRecord.ToString();
                    categoryLabel.Text = record.categoryRecord;
                    typeLabel.Text = record.typeRecord;
                    countLabel.Text = record.countRecord.ToString();
                    entryTimeLabel.Text = record.entryTimeRecord.ToString();
                    exitTimeLabel.Text = record.exitTimeRecord.ToString();
                    var duration = (record.exitTimeRecord - record.entryTimeRecord);
                    durationLabel.Text = Convert.ToInt32(duration.TotalMinutes).ToString() + " " + "min";
                    costLabel.Text = getCostAccordingToDuration(Convert.ToInt32(duration.TotalMinutes), record.typeRecord, record.categoryRecord).ToString();
                    record.entryCostRecord = Convert.ToDouble(getCostAccordingToDuration(Convert.ToInt32(duration.TotalMinutes), record.typeRecord, record.categoryRecord).ToString());


                }
                else
                {
                    MessageBox.Show("Record is Null");

                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Empty Fields Found");

            }
        }



        //This method return Cost According To Duration
        public int getCostAccordingToDuration(int duration, string type, string category)
        {
            TicketModel ticket = null;
            double ticketRate = 20;

            foreach (TicketModel value in GlobalClass.tickets)
            {
                if (value.type == type && value.category == category)
                {
                    ticket = value;
                }
            }
            if (ticket != null)
            {
                if (duration < 60)
                {
                    ticketRate = ticket.rateOneHr;
                }
                else if (duration < 120)
                {
                    ticketRate = ticket.rateTwoHr;
                }
                else if (duration < 180)
                {
                    ticketRate = ticket.rateThreeHr;
                }
                else if (duration < 240)
                {
                    ticketRate = ticket.rateFourHr;
                }
                else
                {
                    ticketRate = ticket.rateWholeDay;
                }

            }

            return Convert.ToInt32(ticketRate);
        }



        /* This method is for confirm button
           Data is updated to CSV file if user click on confirm button. 
       */
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (record != null)
            {
                foreach (Record data in GlobalVariable.records)
                {
                    if (data.idRecord == record.idRecord)
                    {
                        record.isLeftRecord = true;
                    }
                }
                string updatedCsv = "";
                for (int i = 0; i < GlobalVariable.records.Count; i++)
                {
                    Record r = GlobalVariable.records[i];
                    if (i == GlobalVariable.records.Count - 1)
                    {

                        updatedCsv += r.idRecord + ","
                                    + r.categoryRecord + ","
                                    + r.typeRecord + ","
                                    + r.countRecord + ","
                                    + r.entryTimeRecord + ","
                                    + r.exitTimeRecord + ","
                                    + r.entryCostRecord + ","
                                    + r.isLeftRecord;
                    }
                    else
                    {
                        updatedCsv += r.idRecord + ","
                            + r.categoryRecord + ","
                            + r.typeRecord + ","
                            + r.countRecord + ","
                            + r.entryTimeRecord + ","
                            + r.exitTimeRecord + ","
                            + r.entryCostRecord + ","
                            + r.isLeftRecord + "\n";
                    }

                }
                if (updatedCsv != "")
                {
                    File.WriteAllText("F:\\Cw_Ad\\CSV files\\DataRecord.csv", updatedCsv);
                    MessageBox.Show("Exit Confirmed");
                    confirmButton.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Enter existed Id to confirm");
            }
        }
    }
}
