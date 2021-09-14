using MovieLibrary.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        UserForm userForm;

        public string username { get; set; }

        public string password { get; set; }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool condition1 = false;
            bool condition2=false;

            // Form kontrolü
            condition1 = passwordRepeatText.Text == passwordText.Text ? true : false;
            condition2 = username != null && password != null ? true : false;
            
            if (condition1&&condition2)
            {
                Crud.Register(username, password);
                this.Close();
                UserForm userForm = new UserForm();
                userForm.Show();
            }
            
        }


        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            Hide();
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void usernameText_EditValueChanged(object sender, EventArgs e)
        {
            username = usernameText.Text;
            
        }

        private void passwordText_EditValueChanged(object sender, EventArgs e)
        {
            password = passwordText.Text;
        }
    }
}
