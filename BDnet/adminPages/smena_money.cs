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
    public partial class smena_money : Form
    {
        public smena_money()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal? total_sum = decimal.Parse("10");
                this.get_total_summ_smenaTableAdapter.Fill(this.dataSet1.get_total_summ_smena, ref total_sum);
                label2.Text = total_sum.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
