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
    public partial class allView : Form
    {
        public allView()
        {
            InitializeComponent();
        }

        private void allView_Load(object sender, EventArgs e)
        {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.global_view". При необходимости она может быть перемещена или удалена.
                this.global_viewTableAdapter.Fill(this.dataSet1.global_view);
               // global_viewDataGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
