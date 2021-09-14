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
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        public UserForm()
        {
            InitializeComponent();
        }

        RegisterForm registerForm;

        public string username { get; set; }

        public string password { get; set; }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            
            IDictionary<string,object> response = Crud.Authenticate(username, password);

            if (Convert.ToBoolean(response["Result"])==true)
            {
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (registerForm==null||registerForm.IsDisposed)
            {
                registerForm = new RegisterForm();
                registerForm.Show();
                Hide();
            }
            else
            {
                registerForm.Show();
            }
           
        }

        private void passwordText_EditValueChanged(object sender, EventArgs e)
        {
            password = passwordText.Text;
        }

        private void usernameText_EditValueChanged(object sender, EventArgs e)
        {
            username = usernameText.Text;
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
