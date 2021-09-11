using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Utils
{
    public class UserSelector
    {

        private static int selectedUser=1;

        public static int SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; }
        }

    }
}
