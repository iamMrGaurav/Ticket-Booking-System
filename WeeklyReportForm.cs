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
    public partial class WeeklyReportForm : Form
    {
        public WeeklyReportForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        List<Record> recordData = new List<Record>();

        public void getData() {
            DateTime fromDateValue = fromDateTimeValue.Value;
            DateTime toDateValue = toDateTimeValue.Value;

            foreach (Record data in GlobalVariable.records)
            {
                if (data.entryTimeRecord.ToString("yyyy-MM-dd") == fromDateValue.ToString("yyyy-MM-dd"))
                {
                    recordData.Add(data);
                }

            }
           
        }
        private void getReport_Click(object sender, EventArgs e)
        {   
            
         





        }

        private void WeeklyReportForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fromDateTimeValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toDateTimeValue_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
