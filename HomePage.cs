using System;
using System.Windows.Forms;

namespace CourseworkAD
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            ticketTable();
        }

        //This function add data to the datagrid column table
        public void ticketTable()
        {

            dataGridView.ColumnCount = 8;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Category";
            dataGridView.Columns[2].Name = "Type";
            dataGridView.Columns[3].Name = "Rate/1hr";
            dataGridView.Columns[4].Name = "Rate/2hr";
            dataGridView.Columns[5].Name = "Rate/3hr";
            dataGridView.Columns[6].Name = "Rate/4hr";
            dataGridView.Columns[7].Name = "Rate/day";


            foreach (var ticket in GlobalClass.tickets)
            {

                dataGridView.Rows.Add(ticket.id, ticket.category, ticket.type, ticket.rateOneHr, ticket.rateTwoHr, ticket.rateThreeHr, ticket.rateFourHr, ticket.rateWholeDay);
            }
        }

        //This method add record data to the ticket Data table
        public void recordTable()
        {

            dataGridView.ColumnCount = 8;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Category";
            dataGridView.Columns[2].Name = "Type";
            dataGridView.Columns[3].Name = "Entry";
            dataGridView.Columns[4].Name = "Exit";
            dataGridView.Columns[5].Name = "Exited";
            dataGridView.Columns[6].Name = "Count";
            dataGridView.Columns[7].Name = "Cost";


            foreach (var record in GlobalVariable.records)
            {
                dataGridView.Rows.Add(record.idRecord, record.categoryRecord, record.typeRecord, record.entryTimeRecord, record.exitTimeRecord, record.isLeftRecord, record.countRecord, record.entryCostRecord);
            }
        }

        private void ticketRateButton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            ticketTable();
        }

        private void viewRecordButton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            recordTable();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
