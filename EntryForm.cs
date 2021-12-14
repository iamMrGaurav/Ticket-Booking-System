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

      
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //This method autoIncrement the Id
        public void updateId() {

            string[] data = File.ReadAllLines("F:\\Cw_Ad\\DataRecord.csv");
            int value = Convert.ToInt32(data.Length) + 1;
            idValue.Text = value++.ToString();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

            updateId();
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

        //this function get group
        public string searchGroup(int count) {

            if (count == 5) {

                return "Group5";

            } else if (count <= 10) {

                return "Group10";
            }
            else if (count <= 15)
            {

                return "Group15";
            }
            else 
            {

                return "Group15+";
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            insertRecordIntoCsv();
            countNumericUpDownValue.Value = 1;
            updateId();

            
            


        }

        public void insertRecordIntoCsv() {

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
            if (type == "Group") {

                type = searchGroup(count);
            
            }
            Record record = new Record
            {
                idRecord = Convert.ToInt32(id),
                typeRecord = type,
                countRecord = count,
                categoryRecord = category,
                entryTimeRecord = DateTime.Parse(EntryTime),
                exitTimeRecord = DateTime.Parse(ExitTime),
                entryCostRecord = cost,
                isLeftRecord = hasLeft

            };

            GlobalVariable.records.Add(record);
            
            
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

        private void idValue_Click(object sender, EventArgs e)
        {

        }
    }
}
