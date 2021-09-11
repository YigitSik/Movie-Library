using MovieLibrary.Utils;
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
        
        private void userBtnOne_Click(object sender, EventArgs e)
        {
            UserSelector.SelectedUser = 1;
            this.Close();
        }

        private void userBtnTwo_Click(object sender, EventArgs e)
        {
            UserSelector.SelectedUser = 2;
            this.Close();
        }

        private void userBtnThree_Click(object sender, EventArgs e)
        {
            UserSelector.SelectedUser = 3;
            this.Close();
        }

        private void userBtnFour_Click(object sender, EventArgs e)
        {
            UserSelector.SelectedUser = 4;
            this.Close();
        }
    }
}
