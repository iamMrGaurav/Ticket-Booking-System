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
        Home obj = new Home();
        public LoginScreen()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passTextBox.Text != "")
            {

                if (usernameTextBox.Text == "admin" && passTextBox.Text == "admin")
                {

                    GlobalVariable.isAdmin = true;
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Inavlid Fields");
                }
            }
            else {
                MessageBox.Show("Please Fill the empty fields");
            }
           
            
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            obj.Show();
            this.Hide();
        }
    }
}
