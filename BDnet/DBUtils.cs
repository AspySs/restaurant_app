using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BDnet
{
    internal class DBUtils
    {

        public static SqlConnection GetDBConnection()
        {
            string connString = @"Data Source=ASPYS;Initial Catalog=restaurant;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

    }
}
