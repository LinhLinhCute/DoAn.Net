using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SPA
{
    public partial class NhanVien : Form
    {
        Connect cont = new Connect();
        SqlConnection consql;
        DataSet ds_NV;
        DataColumn[] key = new DataColumn[1];
        int Id_Spa;
        public NhanVien(int id)
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
                read = "select  MaNV ,TenNV ,SoDT, DiaChi ,Email, NgaySinh ";
                read += "from NhanVien";
                read += " where MaSpa = " + Id_Spa + "";
                DataSet ds = new DataSet();
                // tạo dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(read, consql);
                // đổ dữ liệu vào dataset
                da.Fill(ds, "KhachHang");
                //Gán dữ liệu vào datagridview
                dgv_NhanVien.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            Load_dgv();
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_Ten.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
            txt_SDT.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            txt_DiaChi.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txt_Email.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            txt_NgaySinh.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
