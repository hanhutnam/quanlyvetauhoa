using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace quanlyvetauhoa
{
    class ketnoi
    {
        SqlConnection con = new SqlConnection(@"Data Source=NHUTNAM-PC\NHUTNAM;Initial Catalog=Quanlyvetauhoa;Integrated Security=True");
        DataTable dt;
        public void LoadCSDL(DataGridView _dtV)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "loadvetauhoa";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                _dtV.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void ThemCSDL(string mave, string Ten, string ngay, string gio, string GioiTinh, string dantoc, string cmnd, string diemden, string gia)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "themdulieu";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mave", SqlDbType.NChar)).Value = mave;
                comd.Parameters.Add(new SqlParameter("ten", SqlDbType.NVarChar)).Value = Ten;
                comd.Parameters.Add(new SqlParameter("ngaydi", SqlDbType.Date)).Value = ngay;
                comd.Parameters.Add(new SqlParameter("giodi", SqlDbType.NChar)).Value = gio;
                comd.Parameters.Add(new SqlParameter("gioitinh", SqlDbType.NChar)).Value = GioiTinh;
                comd.Parameters.Add(new SqlParameter("dantoc", SqlDbType.NChar)).Value = dantoc;
                comd.Parameters.Add(new SqlParameter("cmnd", SqlDbType.NVarChar)).Value = cmnd;
                comd.Parameters.Add(new SqlParameter("diemden", SqlDbType.NVarChar)).Value = diemden;
                comd.Parameters.Add(new SqlParameter("gia", SqlDbType.NVarChar)).Value = gia;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void SuaCSDL(string mave, string Ten, String ngay, string gio, string GioiTinh, string dantoc, string cmnd, string diemden, string gia)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "suadulieu";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mave", SqlDbType.NChar)).Value = mave;
                comd.Parameters.Add(new SqlParameter("ten", SqlDbType.NVarChar)).Value = Ten;
                comd.Parameters.Add(new SqlParameter("ngaydi", SqlDbType.Date)).Value = ngay;
                comd.Parameters.Add(new SqlParameter("giodi", SqlDbType.NChar)).Value = gio;
                comd.Parameters.Add(new SqlParameter("gioitinh", SqlDbType.NChar)).Value = GioiTinh;
                comd.Parameters.Add(new SqlParameter("dantoc", SqlDbType.NChar)).Value = dantoc;
                comd.Parameters.Add(new SqlParameter("cmnd", SqlDbType.NVarChar)).Value = cmnd;
                comd.Parameters.Add(new SqlParameter("diemden", SqlDbType.NVarChar)).Value = diemden;
                comd.Parameters.Add(new SqlParameter("gia", SqlDbType.NVarChar)).Value = gia;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void XoaCSDL(string mave)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "xoadulieu";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("mave", SqlDbType.NChar)).Value = mave;
                comd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable Timkiem(string mave)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "timkiem";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("mave", SqlDbType.NChar)).Value = mave;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


    }
}
