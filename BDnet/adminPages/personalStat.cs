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
    public partial class personalStat : Form
    {
        public personalStat()
        {
            InitializeComponent();
        }

        private void personalStat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.statistic_personal". При необходимости она может быть перемещена или удалена.
            this.statistic_personalTableAdapter.Fill(this.dataSet1.statistic_personal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
