using BDnet.DataSet1TableAdapters;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDnet
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.usr.unauth();
            this.Visible = false;
            Program.authForm.Visible = true;
        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(dataSet1);

        }
        
        private void mainWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1._Tables". При необходимости она может быть перемещена или удалена.
            this.tablesTableAdapter.Fill(this.dataSet1._Tables);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.personal". При необходимости она может быть перемещена или удалена.
            personalTableAdapter.Fill(dataSet1.personal);
            personalDataGridView.Columns[0].Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.order_table_normal_select". При необходимости она может быть перемещена или удалена.
            order_table_normal_selectTableAdapter.Fill(dataSet1.order_table_normal_select);
            order_table_normal_selectDataGridView.Columns[0].Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Menu". При необходимости она может быть перемещена или удалена.
            menuTableAdapter.Fill(dataSet1.Menu);
            

        }

        private void button2_Click(object sender, EventArgs e) //получение статистики
        {
            Program.dish_Statistic.Visible = true;
        }

        private void order_table_normal_selectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView rowView = comboBox1.SelectedItem as DataRowView;
            if (rowView != null) {
                String id_order = rowView["order_num"].ToString();
                try
                {
                    Program.order_Compos.order_compos_by_idTableAdapter.Fill(Program.order_Compos.dataSet1.order_compos_by_id, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_order, typeof(int))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            Program.order_Compos.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // название процедуры
            string sqlExpression = "deactivate_personal";
            bool status = false;
            DataRowView row = comboBox2.SelectedItem as DataRowView;
            String id_pers = "0";
            if (row != null) { id_pers = row["id_personal"].ToString(); }
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@status",
                    Value = status
                };
                // добавляем параметр
                command.Parameters.Add(nameParam);
                // параметр для ввода возраста
                SqlParameter ageParam = new SqlParameter
                {
                    ParameterName = "@id_personal",
                    Value = id_pers
                };
                command.Parameters.Add(ageParam);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                //var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            personalTableAdapter.ClearBeforeFill=true;
            personalTableAdapter.Fill(dataSet1.personal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.addNewPerson.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.personalStatistic.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRowView row = comboBox3.SelectedItem as DataRowView;
            String name = "0";
            String phone = "0";
            String password = "Введите новый пароль, данный более недоступен!";
            String login = "0";
            String position = "oficiant";
            String id = "0";
            if (row != null) {
                id = row["id_personal"].ToString();
                name = row["name"].ToString();
                phone = row["phone"].ToString();
                login = row["login"].ToString();
                position = row["position"].ToString();
            }
            Program.personalUpdate.textBox1.Text = name;
            Program.personalUpdate.textBox2.Text = password;
            Program.personalUpdate.textBox3.Text = login;
            Program.personalUpdate.textBox4.Text = phone;
            Program.personalUpdate.textBox5.Text = id;
            Program.personalUpdate.comboBox1.SelectedItem = position;
            Program.personalUpdate.Visible=true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataRowView row = comboBox4.SelectedItem as DataRowView;
            String id = "0";
            if (row != null)
            {
                id = row["table_id"].ToString();
            }
            int id_table = int.Parse(id);
            string sqlExpression = "delete_table";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@table_id",
                    Value = id_table
                };
                command.Parameters.Add(idParam);
                //var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                var result = command.ExecuteNonQuery();

                //Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            tablesTableAdapter.ClearBeforeFill = true;
            tablesTableAdapter.Fill(dataSet1._Tables);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT Tables DEFAULT VALUES";
            var result = cmd.ExecuteNonQuery();
            tablesTableAdapter.ClearBeforeFill = true;
            tablesTableAdapter.Fill(dataSet1._Tables);
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.allview.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Program.oficiants.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.chefs.Visible= true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program.smallview.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                decimal? total_sum = decimal.Parse("10");
                Program.smena.get_total_summ_smenaTableAdapter.Fill(Program.smena.dataSet1.get_total_summ_smena, ref total_sum);
                Program.smena.label2.Text = total_sum.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            Program.smena.Visible = true;
        }
    }
}
