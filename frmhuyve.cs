using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlyvetauhoa
{
    public partial class frmhuyve : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmhuyve()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txbtim.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbtim.DataBindings.Add("Text", dataGridView1.DataSource, "mave");

        }

        private void frmhuyve_Load(object sender, EventArgs e)
        {
            k.LoadCSDL(this.dataGridView1);
            LoadData();
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin  có mã số: " + txbtim.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                k.XoaCSDL(txbtim.Text);

                k.LoadCSDL(this.dataGridView1);
                MessageBox.Show("Xóa thành công");
                txbtim.ResetText();
                LoadData();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
