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
    public partial class receipt_for : Form
    {
        public receipt_for()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.receipt_for_dishTableAdapter.Fill(this.dataSet1.receipt_for_dish, new System.Nullable<int>(((int)(System.Convert.ChangeType(pos_idToolStripTextBox.Text, typeof(int))))));
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
