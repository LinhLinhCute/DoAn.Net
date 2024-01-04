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
    public partial class Admin : Form
    {
        Connect cont = new Connect();
        SqlConnection consql;
        DataSet ds_QL;
        DataColumn[] key = new DataColumn[1];
        private int MaSpa;
        public Admin(int id)
        {
            InitializeComponent();
            consql = cont.connect;
            MaSpa= id;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Load_Spa()
        {
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string query = "select TenSpa from Spa where MaSpa = " + MaSpa + "";
                SqlCommand cmd = new SqlCommand(query, consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string ten = rdr["TenSpa"].ToString();
                    label1.Text = ten;
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
        private void Admin_Load(object sender, EventArgs e)
        {
            Load_Spa();
        }

        private void btn_DatLich_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f_DatLich = new DatLich_Admin_(MaSpa);
            f_DatLich.TopLevel = false;
            panel2.Controls.Add(f_DatLich);
            f_DatLich.Dock = DockStyle.Fill;
            f_DatLich.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f_DatLich.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f_KH = new KhachHang_Admin_(MaSpa);
            f_KH.TopLevel = false;
            panel2.Controls.Add(f_KH);
            f_KH.Dock = DockStyle.Fill;
            f_KH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f_KH.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f_NV = new NhanVien(MaSpa);
            f_NV.TopLevel = false;
            panel2.Controls.Add(f_NV);
            f_NV.Dock = DockStyle.Fill;
            f_NV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f_NV.Show();
        }
    }
}
