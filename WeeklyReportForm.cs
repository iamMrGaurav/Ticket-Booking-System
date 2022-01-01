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

      
        //This is an event listener method of get report button
        private void getReport_Click(object sender, EventArgs e)
        {

            retrieveData();

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
            DateTime newDate = fromDateTimeValue.Value;
            toDateTimeValue.Value = newDate.AddDays(6);

        }


        private void toDateTimeValue_ValueChanged(object sender, EventArgs e)
        {

        }


        //This is a static method used shows data into the graph
        public static void weeklyReport(DateTime from)
        {

            GlobalVariable.reportList.Clear();

            Dictionary<string, List<double>> totalCounts = new Dictionary<string, List<double>>();


            totalCounts.Add("Sunday", new List<double>() { 0, 0 });
            totalCounts.Add("Monday", new List<double>() { 0, 0 });
            totalCounts.Add("Tuesday", new List<double>() { 0, 0 });
            totalCounts.Add("Wednesday", new List<double>() { 0, 0 });
            totalCounts.Add("Thursday", new List<double>() { 0, 0 });
            totalCounts.Add("Friday", new List<double>() { 0, 0 });
            totalCounts.Add("Saturday", new List<double>() { 0, 0 });

            DateTime to = from.AddDays(6);

            for (var date = from; date <= to; date = date.AddDays(1))
            {

                foreach (Record record in GlobalVariable.records)
                {

                    if (date.ToString("yyyy-MM-dd") == record.entryTimeRecord.ToString("yyyy-MM-dd"))
                    {
                        if (date.DayOfWeek.ToString() == "Sunday")
                        {

                            totalCounts["Sunday"][0]++;
                            totalCounts["Sunday"][1] += record.entryCostRecord;
                        }
                        else if (date.DayOfWeek.ToString() == "Monday")
                        {

                            totalCounts["Monday"][0]++;
                            totalCounts["Monday"][1] += record.entryCostRecord;
                        }
                        else if (date.DayOfWeek.ToString() == "Tuesday")
                        {

                            totalCounts["Tuesday"][0]++;
                            totalCounts["Tuesday"][1] += record.entryCostRecord;
                        }
                        else if (date.DayOfWeek.ToString() == "Wednesday")
                        {

                            totalCounts["Wednesday"][0]++;
                            totalCounts["Wednesday"][1] += record.entryCostRecord;
                        }
                        else if (date.DayOfWeek.ToString() == "Thursday")
                        {

                            totalCounts["Thursday"][0]++;
                            totalCounts["Thursday"][1] += record.entryCostRecord;
                        }
                        else if (date.DayOfWeek.ToString() == "Friday")
                        {

                            totalCounts["Friday"][0]++;
                            totalCounts["Friday"][1] += record.entryCostRecord;
                        }
                        else if (date.DayOfWeek.ToString() == "Saturday")
                        {

                            totalCounts["Saturday"][0]++;
                            totalCounts["Saturday"][1] += record.entryCostRecord;
                        }
                    }
                }
            }
            foreach (string key in totalCounts.Keys)
            {
                Report report = new Report
                {
                    days = key,
                    detailsOfCustomer = totalCounts[key],
                };
                GlobalVariable.reportList.Add(report);
            }
        }





        //This method retrieve data and add value to label
        public void retrieveData()
        {
            weeklyReportChart.Series["Count"].Points.Clear();
            weeklyReportChart.Series["Income"].Points.Clear();

            DateTime fromDate = fromDateTimeValue.Value;
            weeklyReport(fromDate);
            weeklyReportBubbleSort(GlobalVariable.reportList);

            foreach ( Report r in GlobalVariable.reportList)
            {
                weeklyReportChart.Series["Count"].Points.AddXY(r.days, r.detailsOfCustomer[0]);
                weeklyReportChart.Series["Income"].Points.AddXY(r.days, r.detailsOfCustomer[1]);
            }

            for (int i = 0; i < GlobalVariable.reportList.Count; i++)
            {
                if (GlobalVariable.reportList[i].days == "Sunday")
                {
                    sundayCountLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[0].ToString();
                    sundayTransactionLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[1].ToString();
                }
                else if (GlobalVariable.reportList[i].days == "Monday")
                {

                    mondayCountLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[0].ToString();
                    mondayTransactionLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[1].ToString();
                }
                else if (GlobalVariable.reportList[i].days == "Tuesday")
                {
                    tuesdayCountLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[0].ToString();
                    tuesdayTransactionLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[1].ToString();
                }
                else if (GlobalVariable.reportList[i].days == "Wednesday")
                {
                    wednesdayCountLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[0].ToString();
                   wednesdayTransactionLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[1].ToString();
                }
                else if (GlobalVariable.reportList[i].days == "Thursday")
                {
                    thursdayCountLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[0].ToString();
                    thursdayTransactionLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[1].ToString();
                }
                else if (GlobalVariable.reportList[i].days == "Friday")
                {
                    fridayCountLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[0].ToString();
                    fridayTransactionLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[1].ToString();
                }
                else
                {
                    saturdayCountLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[0].ToString();
                    saturdayTransactionLabel.Text = GlobalVariable.reportList[i].detailsOfCustomer[1].ToString();
                }
            }
        }


        //This method sort the data using Bubble Sort Algorithm

        static void weeklyReportBubbleSort(List<Report> list)
        {
            int listCount = list.Count;
            for (int i = 0; i < listCount - 1; i++)
            {
                for (int j = 0; j < listCount - i - 1; j++)
                {
                    if (list[j].detailsOfCustomer[0] > list[j + 1].detailsOfCustomer[0])
                    {
                        Report tempList = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tempList;
                    }
                }
            }

        }






        

        
    }
}

