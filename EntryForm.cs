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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            typeValue.SelectedIndex = 0;
        }

        public void checkSelectedIndex() { 
        

        
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            //This distinguis the real time date inthe  category section
            DateTime date = DateTime.Now;
            String day = date.DayOfWeek.ToString();
            

            if (day == "Saturday")
            {
                categoryLabel.Text = "Holiday";
            }
            else
            {
                categoryLabel.Text = "Weekday";
            }
            //This add column header in datagrid table
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

        //inserting data to record



        private void button1_Click(object sender, EventArgs e)
        {
            InsertDataIntoCsv();
            countNumericUpDownValue.Value = 1;

        }

        public void InsertDataIntoCsv() {

           
            string type = typeValue.Text;
            int count = Convert.ToInt32(countNumericUpDownValue.Value);
           
     

            if (type == "Group")
            {
                if (count < 5)
                {

                    MessageBox.Show("Value must be greater or equal to 5");
                }
                else {

                    addRecord();
                }

                
            }
            else
            {
                addRecord();
            }

        }

        public void addRecord() {

            string id = idValue.Text;
            string type = typeValue.Text;
            int count = Convert.ToInt32(countNumericUpDownValue.Value);
            string category = categoryLabel.Text;
            string EntryTime = DateTime.Now.ToString();
            string ExitTime = DateTime.Now.ToString();
            double cost = 0;
            bool hasLeft = false;

            string newRecord = id + "," + category + "," + type + "," + count + "," + EntryTime + "," + ExitTime + "," + cost + "," + hasLeft + "\n";
            File.AppendAllText("F:\\Cw_Ad\\DataRecord.csv", newRecord);
            Console.WriteLine(newRecord);
            MessageBox.Show("Data Inserted Successfully");

        }

        private void typeValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeValue.SelectedIndex == 2)
            {
                countNumericUpDownValue.Enabled = true;
                countNumericUpDownValue.Value = 5;

            }
            else {

                countNumericUpDownValue.Enabled = false;
                countNumericUpDownValue.Value = 1;
            }
        }
    }
}
