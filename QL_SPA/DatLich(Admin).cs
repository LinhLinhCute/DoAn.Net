using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SPA
{
    public partial class DatLich_Admin_ : Form
    {
        Connect cont = new Connect();
        SqlConnection consql;
        DataSet ds_DL;
        DataColumn[] key = new DataColumn[1];
        int Id_Spa;
        public DatLich_Admin_(int id)
        {
            InitializeComponent();
            consql = cont.connect;
            Id_Spa = id;
        }
        private void Load_dgv()
        {
            try
            {
                string read;
                read = "select  MaLich ,TenKH ,TenDV ,NgayGio, ThoiGian ,TrangThai ";
                read += "from LichLam , DichVu, KhachHang";
                read += " where  LichLam.MaSpa="+Id_Spa+ " and LichLam.MaDV = DichVu.MaDV and LichLam.MaKH= KhachHang.MaKH and DichVu.MaSpa = "+Id_Spa+ " and KhachHang.MaSpa ="+Id_Spa+"";
                DataSet ds = new DataSet();
                // tạo dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(read, consql);
                // đổ dữ liệu vào dataset
                da.Fill(ds, "DatLich");
                //Gán dữ liệu vào datagridview
                dgv_DatLich.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DatLich_Admin__Load(object sender, EventArgs e)
        {
            Load_dgv();
        }

        private void dgv_DatLich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLich.Text= dgv_DatLich.CurrentRow.Cells[0].Value.ToString();
            txt_DV.Text= dgv_DatLich.CurrentRow.Cells[1].Value.ToString();
            txt_KH.Text = dgv_DatLich.CurrentRow.Cells[2].Value.ToString();
            txt_Ngay.Text= dgv_DatLich.CurrentRow.Cells[3].Value.ToString();
            txt_ThoiGian.Text= dgv_DatLich.CurrentRow.Cells[4].Value.ToString();
            txt_TrangThai.Text = dgv_DatLich.CurrentRow.Cells[5].Value.ToString();
        }
        private string MaDV()
        {
            string Ma = "";
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string query = "select  MaDV from DichVu where MaSpa = " + Id_Spa + " and TenDV = N'" + txt_DV.Text + "'";
                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    Ma = rdr["MaDV"].ToString();


                }

                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Ma;
        }
        private string MaKH()
        {
            string Ma = "";
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string query = "select  MaKH from KhachHang where MaSpa = " + Id_Spa + " and TenKH = N'" + txt_KH.Text + "'";
                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    Ma = rdr["MaKH"].ToString();


                }

                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Ma;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string Ma_DV = MaDV();
                string Ma_KH = MaKH();
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Insert;
                Insert = "insert into LichLam values ('"+txt_MaLich.Text+"','"+Ma_KH+"','"+ Ma_DV + "',N'"+txt_Ngay.Text+"',N'"+txt_TrangThai+"',"+Id_Spa+")";
                SqlCommand cmd = new SqlCommand(Insert, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
