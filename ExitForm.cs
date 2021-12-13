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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("F:\\Cw_Ad\\DataRecord.csv");
            Console.WriteLine(data);
            Console.WriteLine(data[1]);
        }
    }
}
