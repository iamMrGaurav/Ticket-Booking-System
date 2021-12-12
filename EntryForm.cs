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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            String day = date.DayOfWeek.ToString();
            Console.WriteLine(day);
            if (day == "Saturday")
            {
                categoryLabel.Text = "Holiday";
            }
            else
            {
                categoryLabel.Text = "Weekday";
            }

            ticketData.ColumnCount = 8;
            ticketData.Columns[0].Name = "ID";
            ticketData.Columns[1].Name = "Category";
            ticketData.Columns[2].Name = "Type";
            ticketData.Columns[3].Name = "Rate/1hr";
            ticketData.Columns[4].Name = "Rate/2hr";
            ticketData.Columns[5].Name = "Rate/3hr";
            ticketData.Columns[6].Name = "Rate/4hr";
            ticketData.Columns[7].Name = "Rate/day";

            foreach (var ticket in GlobalClass.tickets)
            {

                ticketData.Rows.Add(ticket.id, ticket.category, ticket.type, ticket.rateOneHr, ticket.rateTwoHr, ticket.rateThreeHr, ticket.rateFourHr, ticket.rateWholeDay);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
