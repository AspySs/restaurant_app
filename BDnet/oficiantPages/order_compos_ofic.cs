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
    public partial class order_compos_ofic : Form
    {
        public order_compos_ofic()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
        }

        private void order_compos_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.dataSet1.Menu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView row = comboBox1.SelectedItem as DataRowView;
            String id_pos = "0";
            if (row != null) { id_pos = row["position_id"].ToString(); }
            string sqlExpression = "delete_order_comp";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter order = new SqlParameter
                {
                    ParameterName = "@order_id",
                    Value = textBox1.Text
                };
                command.Parameters.Add(order);

                SqlParameter pos = new SqlParameter
                {
                    ParameterName = "@position_id",
                    Value = id_pos
                };
                command.Parameters.Add(pos);

                var result = command.ExecuteScalar();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            try
            {
                find_orderComposition_by_idTableAdapter.ClearBeforeFill = true;
                find_orderComposition_by_idTableAdapter.Fill(dataSet1.find_orderComposition_by_id, new System.Nullable<int>(((int)(System.Convert.ChangeType(textBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void fillToolStripButton_Click_7(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            menuDataGridView.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String count = textBox2.Text;
            DataRowView row = comboBox2.SelectedItem as DataRowView;
            String id_pos = "0";
            if (row != null) { id_pos = row["position_id"].ToString(); }
            string sqlExpression = "add_row_in_orderComposition";
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter order = new SqlParameter
                {
                    ParameterName = "@order_id",
                    Value = textBox1.Text
                };
                command.Parameters.Add(order);

                SqlParameter pos = new SqlParameter
                {
                    ParameterName = "@position_id",
                    Value = id_pos
                };
                command.Parameters.Add(pos);

                SqlParameter cnt = new SqlParameter
                {
                    ParameterName = "@count",
                    Value = count
                };
                command.Parameters.Add(cnt);

                var result = command.ExecuteScalar();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
            try
            {
                find_orderComposition_by_idTableAdapter.ClearBeforeFill = true;
                find_orderComposition_by_idTableAdapter.Fill(dataSet1.find_orderComposition_by_id, new System.Nullable<int>(((int)(System.Convert.ChangeType(textBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            comboBox2.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            menuDataGridView.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
