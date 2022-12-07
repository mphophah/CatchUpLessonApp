using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchUpLessonApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logninButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if(username == "mpho" && password == "2022")
            {
                // MessageBox.Show("Successfully login in");
                WelcomeForm wl = new WelcomeForm(username, password);
                wl.Show();
            }
            else
            {
                MessageBox.Show("Login details are not correct");
            }
        }
    }
}
