using System;
using System.Windows.Forms;

namespace CourseworkAD
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void skipButton_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {



        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int value = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (value < 100)
            {
                value++;
                progressBar1.Value = value;
            }
            else
            {
                timer1.Stop();
                new LoginScreen().Show();
                this.Hide();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
