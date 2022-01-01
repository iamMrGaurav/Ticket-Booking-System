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
        
        //This method is for login button 
        private void loginButton_Click(object sender, EventArgs e)
        {
            //Check if field is empty or not
            if (usernameTextBox.Text != "" && passTextBox.Text != "")
            {
                //Check username and password
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

        //This skip button method shows home page 
        private void skipButton_Click(object sender, EventArgs e)
        {
            obj.Show();
            this.Hide();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
