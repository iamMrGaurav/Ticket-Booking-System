using System;
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
            else
            {
                MessageBox.Show("Please Fill the empty fields");
            }


        }

        //This skip button method shows home page 
        private void skipButton_Click(object sender, EventArgs e)
        {
            obj.Show();
            this.Hide();
        }


        //This method closes the application on click
        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //This method minimizes the application on click
        private void minimizeApplication_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
