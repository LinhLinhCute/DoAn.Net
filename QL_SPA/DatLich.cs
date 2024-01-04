using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SPA
{
    public partial class DatLich : Form
    {
        Connect cont = new Connect();
        SqlConnection consql;
        int IdSpa=1;
        
        public DatLich()
        {
            InitializeComponent();
            consql = cont.connect;
        }

        private void Load_CbB_NDV(  )
        {
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string query = "select  TenNDV from NhomDichVu where MaSpa ="+IdSpa+"";
                
                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    
                    string NDV = rdr["TenNDV"].ToString();
                    cbB_Nhomdv.Items.Add(NDV);

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
        }
        private void Load_Spa()
        {
            
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string query = "select TenSpa from Spa";

                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string Spa = rdr["TenSpa"].ToString();
                    cbB_Spa.Items.Add(Spa);
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
            
        }
        private void Load_CbB_DV(string ten)
        {
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string query = "select  TenDV from DichVu where MaSpa = "+IdSpa +" and MaNDV = (select MaNDV from NhomDichVu where TenNDV = N'"+ten+"' and MaSpa = "+IdSpa +")";

                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    string DV = rdr["TenDV"].ToString();
                    cbB_DichVu .Items.Add(DV);

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
        }

        private void Load_NV()
        {
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string query = "select  TenNV from NhanVien where MaSpa = "+IdSpa+"";

                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    string NV = rdr["TenNV"].ToString();
                    cbB_NhanVien .Items.Add(NV);

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
        }
        private void DatLich_Load(object sender, EventArgs e)
        {
            Load_Spa();
            Load_CbB_DV("Chăm sóc Da");
            Load_CbB_NDV();
            Load_NV();
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbB_Spa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            IdSpa = cbB_Spa.SelectedIndex +1;
            cbB_Nhomdv.Items.Clear();
            Load_CbB_NDV();
            cbB_NhanVien.Items.Clear();
            Load_NV();
            
            

        }
        private void Load_ThongTin(string ten)
        {
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string query = "select  MoTa, HinhAnh from DichVu where MaSpa = " + IdSpa + " and TenDV = N'" + ten + "'";

                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    string MoTa = rdr["MoTa"].ToString();
                    txt_MoTa.Text = MoTa;
                    string Hinh = rdr["HinhAnh"].ToString();
                    pB_HinhAnh_dv.Image = Image.FromFile(@"Image/" + Hinh);
                    pB_HinhAnh_dv.SizeMode = PictureBoxSizeMode.Zoom;

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
        }

        private void cbB_DichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ten = " ";
            Ten = cbB_DichVu.SelectedItem.ToString();
            txt_MoTa.Clear();
            Load_ThongTin(Ten);
        }

        private void cbB_Nhomdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ten = " ";
            Ten= cbB_Nhomdv.SelectedItem.ToString();
            cbB_DichVu.Items.Clear();
            Load_CbB_DV(Ten);
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
                string query = "select  MaDV from DichVu where MaSpa = " + IdSpa + " and TenDV = N'" +cbB_DichVu.SelectedItem + "'";
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
        private void btn_DatLich_Click(object sender, EventArgs e)
        {
            String tg = dateTimePicker1.Text;
           
            Form f_KH = new HS_KhachHang(IdSpa,MaDV(),tg);
            f_KH.Show();
            this.Hide();
        }
    

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
