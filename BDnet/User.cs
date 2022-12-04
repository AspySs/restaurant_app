using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDnet
{
    internal class User
    {
        private int id;
        private String login;
        private String name;
        private String phone;
        private bool status;
        private String position;
        private bool auth = true;

        public User(String login, DbDataReader reader) {
            this.login = login;
            getData(reader);
        }

        private void getData(DbDataReader reader)
        {
            //conn.Open();
            /*            SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT * FROM personal WHERE login=\'" + login + "\'";
                        DbDataReader reader = cmd.ExecuteReader();
                        reader.Read();*/
            int index = reader.GetOrdinal("name");
            this.name = reader.GetString(index);
            index = reader.GetOrdinal("id_personal");
            this.id = reader.GetInt32(index);
            index = reader.GetOrdinal("phone");
            this.phone = reader.GetString(index);
            index = reader.GetOrdinal("status");
            this.status = reader.GetBoolean(index);
            index = reader.GetOrdinal("position");
            this.position = reader.GetString(index);
        }
        public int getId() { return id; }
        public String getLogin() { return login; }
        public String getName() { return name; }
        public String getPhone() { return phone; }
        public bool getStatus() { return status; }
        public String getPosition() { return position; }

        public bool isAuth() { return auth; }

        public void unauth(){
            this.auth = false;
            this.name = null;
            this.id = 0;
            this.phone = null;
            this.status = false;
            this.position = null;
        }
    }
}
