using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class DatabaseConnectionOld
    {

        // Burada daha önceden kullandığım lokal veri tabanı bağlantısı bulunmakta
        public static SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-3TO3LJ9\SQLEXPRESS;Initial Catalog=MovieLibrary;Integrated Security=True");
            connect.Open();
            return connect;

        }

    }
}
