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
    public partial class chefsView : Form
    {
        public chefsView()
        {
            InitializeComponent();
        }

        private void chefsView_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.all_chefs". При необходимости она может быть перемещена или удалена.
            this.all_chefsTableAdapter.Fill(this.dataSet1.all_chefs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
