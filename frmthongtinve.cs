using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlyvetauhoa
{
    public partial class frmthongtinve : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmthongtinve()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            txbtim.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbtim.DataBindings.Add("Text", dataGridView1.DataSource, "mave");

        }
        private void frmthongtinve_Load(object sender, EventArgs e)
        {
            k.LoadCSDL(this.dataGridView1);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txbtim.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã vé tàu cần tìm");
            }
            else
            {
                dt = new DataTable();
                dt = k.Timkiem(txbtim.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mã vé tàu " + txbtim.Text + " Không tồn tại. Vui lòng kiểm tra lại");
                }
                txbtim.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
