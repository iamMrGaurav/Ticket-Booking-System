using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
            

            foreach (var ticket in GlobalClass.tickets) {

                ticketData.Rows.Add(ticket.id,
                                    ticket.category,
                                    ticket.type,
                                    ticket.rateOneHr,
                                    ticket.rateTwoHr,
                                    ticket.rateThreeHr,
                                    ticket.rateFourHr,
                                    ticket.rateWholeDay);
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
            string[] csvData = File.ReadAllLines("F:\\Cw_Ad\\TicketRate.csv");


            var record = csvData[rowIndex].Split(',');
            record[columnIndex] = value.ToString();
            var updatedRow = "";

            for (int j = 0; j < record.Length; j++)
            {
                if (j == record.Length - 1)
                {
                    updatedRow += record[j];
                }
                else
                {
                    updatedRow += record[j] + ",";
                }

            }

            csvData[rowIndex] = updatedRow;
            string updatedCsv = "";

            for (int i = 0; i < csvData.Length; i++)
            {
                if (i == csvData.Length - 1)
                {
                    updatedCsv += csvData[i];
                }
                else
                {
                    updatedCsv += csvData[i] + "\n";
                }
            }
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("F:\\Cw_Ad\\TicketRate.csv",FileMode.Create,FileAccess.Write);
            formatter.Serialize(stream,updatedCsv);
            stream.Close();

            File.WriteAllText("F:\\Cw_Ad\\TicketRate.csv", updatedCsv);
        }

        private void ticketData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

  

