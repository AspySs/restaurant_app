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
    public partial class mainWindowOficiants : Form
    {
        public mainWindowOficiants()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.usr.unauth();
            Program.authForm.Visible = true;
        }


        private void mainWindowOficiants_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1._Tables". При необходимости она может быть перемещена или удалена.
            this.tablesTableAdapter.Fill(this.dataSet1._Tables);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.view_for_ofic". При необходимости она может быть перемещена или удалена.
            this.view_for_oficDataGridView.Columns[0].Visible = false;
            this.view_for_oficTableAdapter.Fill(this.dataSet1.view_for_ofic);
            this.view_for_oficDataGridView.Columns[0].Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.find_free_tables". При необходимости она может быть перемещена или удалена.
            this.find_free_tablesTableAdapter.Fill(this.dataSet1.find_free_tables);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.dataSet1.Menu);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRowView rowView = comboBox1.SelectedItem as DataRowView;
            if (rowView != null)
            {
                String id_pos = rowView["position_id"].ToString();
                try
                {
                    this.dish_receiptTableAdapter.Fill(this.dataSet1.dish_receipt, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_pos, typeof(int))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.menuStat.Visible = true;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            DataRowView row1 = comboBox2.SelectedItem as DataRowView;
            String id_ord = "";
            if (row1 != null) { id_ord = row1["order_num"].ToString(); }
            String status = comboBox3.SelectedItem.ToString();

            string sqlExpression = "update_order_status";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter order = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id_ord
                };
                command.Parameters.Add(order);

                SqlParameter stat = new SqlParameter
                {
                    ParameterName = "@status",
                    Value = status
                };
                command.Parameters.Add(stat);

                var result = command.ExecuteScalar();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            try
            {
                select_for_oficiantsTableAdapter.ClearBeforeFill = true;
                select_for_oficiantsTableAdapter.Fill(dataSet1.select_for_oficiants, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView row1 = comboBox2.SelectedItem as DataRowView;
            String id_ord = "";
            if (row1 != null) { id_ord = row1["order_num"].ToString(); }
            try
            {
                Program.ord_composit.find_orderComposition_by_idTableAdapter.Fill(Program.ord_composit.dataSet1.find_orderComposition_by_id, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_ord, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            Program.ord_composit.textBox1.Visible = false;
            Program.ord_composit.textBox1.Text = id_ord;
            Program.ord_composit.Visible = true;
            Program.ord_composit.comboBox2.Visible = false;
            Program.ord_composit.textBox2.Visible = false;
            Program.ord_composit.button3.Visible = false;
            Program.ord_composit.label1.Visible = false;
            Program.ord_composit.label2.Visible = false;
            Program.ord_composit.menuDataGridView.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            button8.Visible = true;
            find_free_tablesDataGridView.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            button8.Visible = false;
            find_free_tablesDataGridView.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            DataRowView row1 = comboBox4.SelectedItem as DataRowView;
            String id_table = "";
            if (row1 != null) { id_table = row1["table_id"].ToString(); }
            String status = comboBox5.SelectedItem.ToString();

            string sqlExpression = "add_new_Oder";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter tabl = new SqlParameter
                {
                    ParameterName = "@table",
                    Value = id_table
                };
                command.Parameters.Add(tabl);

                SqlParameter ofik = new SqlParameter
                {
                    ParameterName = "@officiant",
                    Value = Program.usr.getId()
                };
                command.Parameters.Add(ofik);

                SqlParameter stat = new SqlParameter
                {
                    ParameterName = "@status",
                    Value = status
                };
                command.Parameters.Add(stat);

                var result = command.ExecuteScalar();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            try
            {
                this.find_free_tablesTableAdapter.ClearBeforeFill = true;
                this.find_free_tablesTableAdapter.Fill(this.dataSet1.find_free_tables);
                select_for_oficiantsTableAdapter.ClearBeforeFill = true;
                select_for_oficiantsTableAdapter.Fill(dataSet1.select_for_oficiants, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRowView row1 = comboBox2.SelectedItem as DataRowView;
            String id_ord = "";
            if (row1 != null) { id_ord = row1["order_num"].ToString(); }
            try
            {
                decimal? total_sum = decimal.Parse(id_ord);
                Program.check.get_check_orderTableAdapter.Fill(Program.check.dataSet1.get_check_order, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_ord, typeof(int))))), ref total_sum);
                Program.check.label2.Text = total_sum.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            select_for_oficiantsTableAdapter.ClearBeforeFill = true;
            select_for_oficiantsTableAdapter.Fill(dataSet1.select_for_oficiants, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
            Program.check.Visible = true;
        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataRowView row1 = comboBox7.SelectedItem as DataRowView;
            String id_ord = "";
            if (row1 != null) { id_ord = row1["order_num"].ToString(); }
            try
            {
                Program.ord_composit.find_orderComposition_by_idTableAdapter.Fill(Program.ord_composit.dataSet1.find_orderComposition_by_id, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_ord, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            Program.ord_composit.textBox1.Visible = false;
            Program.ord_composit.textBox1.Text = id_ord;
            Program.ord_composit.Visible = true;
            Program.ord_composit.comboBox2.Visible = false;
            Program.ord_composit.textBox2.Visible = false;
            Program.ord_composit.button3.Visible = false;
            Program.ord_composit.label1.Visible = false;
            Program.ord_composit.label2.Visible = false;
            Program.ord_composit.menuDataGridView.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataRowView row1 = comboBox7.SelectedItem as DataRowView;
            String id_ord = "";
            if (row1 != null) { id_ord = row1["order_num"].ToString(); }
            String status = comboBox6.SelectedItem.ToString();

            string sqlExpression = "update_order_status";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter order = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id_ord
                };
                command.Parameters.Add(order);

                SqlParameter stat = new SqlParameter
                {
                    ParameterName = "@status",
                    Value = status
                };
                command.Parameters.Add(stat);

                var result = command.ExecuteScalar();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            try
            {
                view_for_oficTableAdapter.ClearBeforeFill = true;
                this.view_for_oficTableAdapter.Fill(this.dataSet1.view_for_ofic);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataRowView row1 = comboBox7.SelectedItem as DataRowView;
            String id_ord = "";
            if (row1 != null) { id_ord = row1["order_num"].ToString(); }
            try
            {
                decimal? total_sum = decimal.Parse(id_ord);
                Program.check.get_check_orderTableAdapter.Fill(Program.check.dataSet1.get_check_order, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_ord, typeof(int))))), ref total_sum);
                Program.check.label2.Text = total_sum.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            select_for_oficiantsTableAdapter.ClearBeforeFill = true;
            select_for_oficiantsTableAdapter.Fill(dataSet1.select_for_oficiants, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
            Program.check.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataRowView row1 = comboBox8.SelectedItem as DataRowView;
            String id_table = "";
            String status = comboBox9.SelectedItem.ToString();
            if (row1 != null) { id_table = row1["table_id"].ToString(); }
            string sqlExpression = "update_table_status";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter tbl = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id_table
                };
                command.Parameters.Add(tbl);

                SqlParameter stat = new SqlParameter
                {
                    ParameterName = "@status",
                    Value = status
                };
                command.Parameters.Add(stat);

                var result = command.ExecuteScalar();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            try
            {
                tablesTableAdapter.ClearBeforeFill = true;
                this.tablesTableAdapter.Fill(this.dataSet1._Tables);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
