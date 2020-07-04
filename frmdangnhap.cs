using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyvetauhoa
{
    public partial class frmdangnhap : Form
    {
        frmMain frm;
        public frmdangnhap(frmMain f)
        {
            InitializeComponent();
            frm = f;
        }

        SqlConnection con = new SqlConnection(@"Data Source=NHUTNAM-PC\NHUTNAM;Initial Catalog=Quanlyvetauhoa;Integrated Security=True");
        DataTable dt;
        private DataTable ktdangnhap(string taikhoan, string matkhau)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "dangnhap";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("user", SqlDbType.NVarChar)).Value = taikhoan;
            comd.Parameters.Add(new SqlParameter("pass", SqlDbType.NVarChar)).Value = matkhau;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            con.Open();
            dt = new DataTable();
            dt = ktdangnhap(txbU.Text, txbP.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm.open();
                Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại");
            }
        }
    }
}
