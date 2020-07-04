using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlyvetauhoa
{
    public partial class frmthongke : Form
    {
        ketnoi k = new ketnoi();
        public frmthongke()
        {
            InitializeComponent();
        }
        public void tinhtongsp()
        {
            int tien = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
            }
            txbdoanhthu.Text = thanhtien.ToString();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            k.LoadCSDL(this.dataGridView1);
            tinhtongsp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
