using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quanlyvetauhoa
{
    public partial class frmdatve : Form
    {
        public frmdatve()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            txbMave.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbMave.DataBindings.Add("Text", dataGridView1.DataSource, "mave");
            txbhovaten.DataBindings.Clear();
            txbhovaten.DataBindings.Add("Text", dataGridView1.DataSource, "hoten");
            txbNgaydi.DataBindings.Clear();
            txbNgaydi.DataBindings.Add("Text", dataGridView1.DataSource, "ngaydi");
            cbgiokhoihanh.DataBindings.Clear();
            cbgiokhoihanh.DataBindings.Add("Text", dataGridView1.DataSource, "giodi");
            cbGioitinh.DataBindings.Clear();
            cbGioitinh.DataBindings.Add("Text", dataGridView1.DataSource, "gioitinh");
            cbdantoc.DataBindings.Clear();
            cbdantoc.DataBindings.Add("Text", dataGridView1.DataSource, "dantoc");
            txbCmnd.DataBindings.Clear();
            txbCmnd.DataBindings.Add("Text", dataGridView1.DataSource, "cmnd");
            txbDiemden.DataBindings.Clear();
            txbDiemden.DataBindings.Add("Text", dataGridView1.DataSource, "diemden");
            txbGiave.DataBindings.Clear();
            txbGiave.DataBindings.Add("Text", dataGridView1.DataSource, "gia");

        }

        ketnoi k = new ketnoi();

        private void btnchinhsua_Click(object sender, EventArgs e)
        {
            
            k.SuaCSDL(txbMave.Text, txbhovaten.Text, txbNgaydi.Text, cbgiokhoihanh.Text, cbGioitinh.Text, cbdantoc.Text, txbCmnd.Text, txbDiemden.Text, txbGiave.Text);
            k.LoadCSDL(this.dataGridView1);
            MessageBox.Show("Sửa thành công");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void frmdatve_Load(object sender, EventArgs e)
        {
            k.LoadCSDL(this.dataGridView1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMave.Text == mave.ToString())
            {
                MessageBox.Show("Mã bị trùng vui lòng nhập lại");
                txbMave.ResetText();
                txbhovaten.ResetText();

                txbNgaydi.ResetText();
                cbgiokhoihanh.ResetText();

                cbGioitinh.ResetText();
                cbdantoc.ResetText();


                txbCmnd.ResetText();
                txbDiemden.ResetText();
                txbGiave.ResetText();
            }
            else
            {
               
                k.ThemCSDL(txbMave.Text, txbhovaten.Text, txbNgaydi.Text, cbgiokhoihanh.Text, cbGioitinh.Text, cbdantoc.Text, txbCmnd.Text, txbDiemden.Text, txbGiave.Text);
                k.LoadCSDL(this.dataGridView1);
                MessageBox.Show("Thêm thành công");

                txbMave.ResetText();
                txbhovaten.ResetText();

                txbNgaydi.ResetText();
                cbgiokhoihanh.ResetText();

                cbGioitinh.ResetText();
                cbdantoc.ResetText();


                txbCmnd.ResetText();
                txbDiemden.ResetText();
                txbGiave.ResetText();

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart;
            txbNgaydi.Text = date.ToString("dd/MM/yyyy");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            LoadData();
            txbMave.Enabled = false;
        }

        private void frmdatve_Click(object sender, EventArgs e)
        {
            txbMave.ResetText();
            txbhovaten.ResetText();
            txbNgaydi.ResetText();
            cbgiokhoihanh.ResetText();
            cbGioitinh.ResetText();
            cbdantoc.ResetText();
            txbCmnd.ResetText();
            txbDiemden.ResetText();
            txbGiave.ResetText();
            txbMave.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
