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
    public partial class dish_statistic : Form
    {
        public dish_statistic()
        {
            InitializeComponent();
        }

        private void dish_statistic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.statistic_coctails". При необходимости она может быть перемещена или удалена.
            this.statistic_coctailsTableAdapter.Fill(this.dataSet1.statistic_coctails);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.statistic_dish". При необходимости она может быть перемещена или удалена.
            this.statistic_dishTableAdapter.Fill(this.dataSet1.statistic_dish);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
