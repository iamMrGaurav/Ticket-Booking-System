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
    public partial class DailyReportForm : Form
    {
        public DailyReportForm()
        {
            InitializeComponent();
        }

        List<Record> recordData = new List<Record>();

        //This function get the matching date
        public void getDate() {

            DateTime date = (dailyDate.Value);
            foreach (Record data in GlobalVariable.records) {
                if (data.entryTimeRecord.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd")) {
                    recordData.Add(data);
                }

            }
        }

        //This get Report button method shows daily report 
        private void getDailyReport_Click(object sender, EventArgs e)
        {
            dailyReportChart.Series["Count"].Points.Clear();
            dailyReportChart.Series["Income"].Points.Clear();
            recordData.Clear();
            getDate();
            List<String> typeList = new List<string>() { 
            
                "Adult",
                "Group",
                "Child"
            
            };

            List<double> incomeType = new List<double> { 
            
                0,0,0
            
            };

            List<int> countType = new List<int> {

                0,0,0

            };

            foreach (Record data in recordData) {

                if (data.typeRecord == "Adult")
                {

                    incomeType[0] += data.entryCostRecord;
                    countType[0]++;

                }
                else if (data.typeRecord == "Child")
                {

                    incomeType[2] += data.entryCostRecord;
                    countType[2]++;

                }
                else {

                    incomeType[1] += data.entryCostRecord;
                    countType[1]++;
                
                }
            
            }


            for (int i = 0; i< typeList.Count; i++) {

                dailyReportChart.Series["Count"].Points.AddXY(typeList[i], countType[i]);
                dailyReportChart.Series["Income"].Points.AddXY(typeList[i], incomeType[i]);

            }


            adultCountLabel.Text = Convert.ToInt32(countType[0]).ToString();
            groupCountLabel.Text = Convert.ToInt32(countType[1]).ToString();
            childrenCountLabel.Text = Convert.ToInt32(countType[2]).ToString();
            totalCountLabel.Text = Convert.ToInt32(countType[0] + countType[1] + countType[2]).ToString();

            adultTransactionLabel.Text = Convert.ToInt32(incomeType[0]).ToString();
            groupTransactionLabel.Text = Convert.ToInt32(incomeType[1]).ToString();
            childrenTransactionLabel.Text = Convert.ToInt32(incomeType[2]).ToString();
            totalTransactionLabel.Text = Convert.ToInt32(incomeType[0] + incomeType[1] + incomeType[2]).ToString();


        }

        private void DailyReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
