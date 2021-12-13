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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(idTextBox.Text);
            Record record = null;
            foreach (Record data in GlobalVariable.records)
            {
                if (data.idRecord == ID)
                {
                    record = data;
                }
            }
            if (record != null)
            {
                record.exitTimeRecord = DateTime.Now;
                idTextBox.Text = record.idRecord.ToString();
                categoryLabel.Text= record.categoryRecord;
                typeLabel.Text = record.typeRecord;
                countLabel.Text = record.countRecord.ToString();
                entryTimeLabel.Text = record.entryTimeRecord.ToString();
                exitTimeLabel.Text = record.exitTimeRecord.ToString();
                var duration = (record.exitTimeRecord - record.entryTimeRecord);
                durationLabel.Text = Convert.ToInt32(duration.TotalMinutes).ToString() + " " + "min";
                costLabel.Text = GetDurationCost(Convert.ToInt32(duration.TotalMinutes), record.typeRecord, record.categoryRecord).ToString();

            }
        }
        public int GetDurationCost(int duration, string type, string category)
        {
            TicketModel ticket = null;
            double rate = 0;
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
                    rate = ticket.rateOneHr;
                }
                else if (duration < 120)
                {
                    rate = ticket.rateTwoHr;
                }
                else if (duration < 180)
                {
                    rate = ticket.rateThreeHr;
                }
                else if (duration < 240)
                {
                    rate = ticket.rateFourHr;
                }
                else
                {
                    rate = ticket.rateWholeDay;
                }

            }
            return Convert.ToInt32(rate);
        }


    }
}
