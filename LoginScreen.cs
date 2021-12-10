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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        Home obj;
        private void loginButton_Click(object sender, EventArgs e)
        {
            obj = new Home();
            obj.Show();
            this.Hide();
        }
    }
}
