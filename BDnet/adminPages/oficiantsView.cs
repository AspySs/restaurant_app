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
    public partial class oficiantsView : Form
    {
        public oficiantsView()
        {
            InitializeComponent();
        }

        private void oficiants_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.all_oficiants". При необходимости она может быть перемещена или удалена.
            this.all_oficiantsTableAdapter.Fill(this.dataSet1.all_oficiants);
            all_oficiantsDataGridView.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
