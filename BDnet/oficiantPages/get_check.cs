using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDnet
{
    public partial class get_check : Form
    {
        public get_check()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal? total_sum = decimal.Parse(total_sumToolStripTextBox.Text);
                this.get_check_orderTableAdapter.Fill(this.dataSet1.get_check_order, new System.Nullable<int>(((int)(System.Convert.ChangeType(order_idToolStripTextBox.Text, typeof(int))))), ref total_sum);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
