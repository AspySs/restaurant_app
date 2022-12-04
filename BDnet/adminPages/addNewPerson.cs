using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDnet
{
    public partial class addNewPerson : Form
    {
        public addNewPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name=textBox1.Text.ToString();
            String phone = textBox4.Text.ToString();
            String login = textBox3.Text.ToString();
            String password = DBUtils.GetHash(textBox2.Text.ToString());
            String role = comboBox1.SelectedItem.ToString();
            try
            {
                // название процедуры
                string sqlExpression = "register_personal";
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    // указываем, что команда представляет хранимую процедуру
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    // параметр для ввода имени
                    SqlParameter nameParam = new SqlParameter
                    {
                        ParameterName = "@name",
                        Value = name
                    };
                    // добавляем параметр
                    command.Parameters.Add(nameParam);
                    // параметр для ввода возраста
                    SqlParameter phoneParam = new SqlParameter
                    {
                        ParameterName = "@phone",
                        Value = phone
                    };
                    command.Parameters.Add(phoneParam);

                    SqlParameter positionParam = new SqlParameter
                    {
                        ParameterName = "@position",
                        Value = role
                    };
                    command.Parameters.Add(positionParam);
                    SqlParameter logParam = new SqlParameter
                    {
                        ParameterName = "@log",
                        Value = login
                    };
                    command.Parameters.Add(logParam);
                    SqlParameter passParam = new SqlParameter
                    {
                        ParameterName = "@pass",
                        Value = password
                    };
                    command.Parameters.Add(passParam);

                    var result = command.ExecuteScalar();
                    // если нам не надо возвращать id
                    //var result = command.ExecuteNonQuery();

                    Console.WriteLine("Id добавленного объекта: {0}", result);
                }
                Program.mainWin.personalTableAdapter.ClearBeforeFill = true;
                Program.mainWin.personalTableAdapter.Fill(Program.mainWin.dataSet1.personal);
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR");
            }
        }
    }
}
