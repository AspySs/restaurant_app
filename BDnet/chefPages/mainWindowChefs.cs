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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDnet
{
    public partial class mainWindowChefs : Form
    {
        public mainWindowChefs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.usr.unauth();
            this.Visible = false;
            Program.authForm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string sqlExpression = "update_status_orderComposition";
                DataRowView row = comboBox1.SelectedItem as DataRowView;
                String id_order = "0";
                String id_pos = "0";
                String status = "0";
            if (row != null) { id_order = row["order_num"].ToString(); id_pos=row["position_id"].ToString(); status = row["status"].ToString(); }
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    // указываем, что команда представляет хранимую процедуру
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    // параметр для ввода имени
                    SqlParameter ord = new SqlParameter
                    {
                        ParameterName = "@order_id",
                        Value = id_order
                    };
                    // добавляем параметр
                    command.Parameters.Add(ord);
                    // параметр для ввода возраста
                    SqlParameter pos = new SqlParameter
                    {
                        ParameterName = "@position_id",
                        Value = id_pos
                    };
                    command.Parameters.Add(pos);
                    
                if(status == "False") { status = "True"; } else { status = "False"; }

                    SqlParameter stat = new SqlParameter
                    {
                        ParameterName = "@status",
                        Value = status
                    };
                    command.Parameters.Add(stat);

                    var result = command.ExecuteScalar();
                        // если нам не надо возвращать id
                        //var result = command.ExecuteNonQuery();

                        Console.WriteLine("Id добавленного объекта: {0}", result);
                }
            this.dish_queue1TableAdapter.ClearBeforeFill = true;
            this.dish_queue1TableAdapter.Fill(this.dataSet1.dish_queue1, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dish_queue1TableAdapter.Fill(this.dataSet1.dish_queue1, new System.Nullable<int>(((int)(System.Convert.ChangeType(chef_idToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mainWindowChefs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.all_chefs". При необходимости она может быть перемещена или удалена.
            this.all_chefsDataGridView.Columns[0].Visible = false;
            this.all_chefsTableAdapter.Fill(this.dataSet1.all_chefs);
            this.all_chefsDataGridView.Columns[0].Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.view_for_su". При необходимости она может быть перемещена или удалена.
            this.view_for_suDataGridView.Columns[0].Visible = false;
            this.view_for_suDataGridView.Columns[1].Visible = false;
            this.view_for_suDataGridView.Columns[4].Visible = false;
            this.view_for_suTableAdapter.Fill(this.dataSet1.view_for_su);
            this.view_for_suDataGridView.Columns[0].Visible = false;
            this.view_for_suDataGridView.Columns[1].Visible = false;
            this.view_for_suDataGridView.Columns[4].Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.dataSet1.Menu);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView row = comboBox1.SelectedItem as DataRowView;
            String id_pos = "0";
            if (row != null) {id_pos = row["position_id"].ToString();}
            try
            {
                Program.receipt.receipt_for_dishTableAdapter.Fill(Program.receipt.dataSet1.receipt_for_dish, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_pos, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            Program.receipt.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRowView row = comboBox2.SelectedItem as DataRowView;
            String id_pos = "0";
            String ingr = "0";
            if (row != null) { id_pos = row["position_id"].ToString(); ingr = row["ingredients"].ToString(); }
            this.textBox2.Text = id_pos;
            this.textBox1.Text = ingr;
            this.textBox1.Visible = true;
            this.button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String id_pos = this.textBox2.Text;
            String ingr = this.textBox1.Text;
            this.textBox1.Visible = false;
            this.button5.Visible = false;
            string sqlExpression = "update_ingredients";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter pos = new SqlParameter
                {
                    ParameterName = "@pos",
                    Value = id_pos
                };
                // добавляем параметр
                command.Parameters.Add(pos);
                // параметр для ввода возраста
                SqlParameter ingre = new SqlParameter
                {
                    ParameterName = "@ingr",
                    Value = ingr
                };
                command.Parameters.Add(ingre);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                //var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            this.menuTableAdapter.ClearBeforeFill = true;
            this.menuTableAdapter.Fill(this.dataSet1.Menu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //connect_chef_to_order
            DataRowView row1 = comboBox3.SelectedItem as DataRowView;  //pos
            DataRowView row2 = comboBox4.SelectedItem as DataRowView; //chef
            String id_pos = "0";
            String ordid = "0";
            String id_chef = "0";
            if (row1 != null) { id_pos = row1["position_id"].ToString(); ordid = row1["order_num"].ToString(); }
            if (row2 != null) { id_chef = row2["id_personal"].ToString();}
            string sqlExpression = "connect_chef_to_order";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter ord = new SqlParameter
                {
                    ParameterName = "@order_id",
                    Value = ordid
                };
                // добавляем параметр
                command.Parameters.Add(ord);
                // параметр для ввода возраста
                SqlParameter pos = new SqlParameter
                {
                    ParameterName = "@position_id",
                    Value = id_pos
                };
                command.Parameters.Add(pos);

                SqlParameter chf = new SqlParameter
                {
                    ParameterName = "@chef_id",
                    Value = id_chef
                };
                command.Parameters.Add(chf);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                //var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            this.view_for_suTableAdapter.ClearBeforeFill = true;
            this.view_for_suTableAdapter.Fill(this.dataSet1.view_for_su);
            this.dish_queue1TableAdapter.ClearBeforeFill = true;
            this.dish_queue1TableAdapter.Fill(this.dataSet1.dish_queue1, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
        }
    }
}
