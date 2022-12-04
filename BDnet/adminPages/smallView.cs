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
    public partial class smallView : Form
    {
        public smallView()
        {
            InitializeComponent();
        }

        private void smallView_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.orders_with_tables". При необходимости она может быть перемещена или удалена.
            this.orders_with_tablesTableAdapter.Fill(this.dataSet1.orders_with_tables);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
