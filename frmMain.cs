using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlyvetauhoa
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmdangnhap s = new frmdangnhap(this);
            s.MdiParent = this;
            s.Show();
        }

        public void clock()
        {
            Datve.Enabled = false;
            Huyve.Enabled = false;
            Thongke.Enabled = false;
        }
        public void open()
        {
            Datve.Enabled = true;
            Huyve.Enabled = true;
            Thongke.Enabled = true;
        }

        private void frmMain1_Load(object sender, EventArgs e)
        {
            clock();
        }

        private void Datve_Click(object sender, EventArgs e)
        {
            frmdatve s = new frmdatve();
            s.MdiParent = this;
            s.Show();
        }

        private void Huyve_Click(object sender, EventArgs e)
        {
            frmhuyve s = new frmhuyve();
            s.MdiParent = this;
            s.Show();
        }

        private void Thongke_Click(object sender, EventArgs e)
        {
            frmthongke s = new frmthongke();
            s.MdiParent = this;
            s.Show();
        }

        private void Thongtinve_Click(object sender, EventArgs e)
        {
            frmthongtinve s = new frmthongtinve();
            s.MdiParent = this;
            s.Show();
        }

        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            clock();
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông Báo!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Close();
        }
    }

        
}
