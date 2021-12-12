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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
