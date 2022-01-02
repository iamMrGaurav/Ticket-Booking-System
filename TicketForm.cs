using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CourseworkAD
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        //This method load ticket form data when this application start
        private void TicketForm_Load(object sender, EventArgs e)
        {
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
                ticketData.Rows.Add(ticket.id,
                                    ticket.category,
                                    ticket.type,
                                    ticket.rateOneHr,
                                    ticket.rateTwoHr,
                                    ticket.rateThreeHr,
                                    ticket.rateFourHr,
                                    ticket.rateWholeDay
                                    );
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }


        //This method update the edited data in cell to the csv file
        private void ticketData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var updatedData = Convert.ToInt32(ticketData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            UpdateCSVFile(e.RowIndex, e.ColumnIndex, updatedData);
        }


        //This method update csv file edited in table
        public void UpdateCSVFile(int rowIndex, int columnIndex, int value)
        {

            for (int i = 0; i < GlobalClass.tickets.Count; i++)
            {

                if (i == rowIndex)
                {
                    TicketModel ticket = GlobalClass.tickets[i];
                    if (columnIndex == 3)
                    {
                        ticket.rateOneHr = value;

                    }
                    else if (columnIndex == 4)
                    {

                        ticket.rateTwoHr = value;

                    }
                    else if (columnIndex == 5)
                    {

                        ticket.rateThreeHr = value;

                    }
                    else if (columnIndex == 6)
                    {

                        ticket.rateFourHr = value;

                    }

                }


            }

            serializeData();

        }

        //This function Serialize the data
        public void serializeData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("F:\\Cw_Ad\\serializeData.csv", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, GlobalClass.tickets);
            stream.Close();

        }

    }
}



