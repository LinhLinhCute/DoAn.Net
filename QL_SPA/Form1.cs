using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography.X509Certificates;

namespace QL_SPA
{
    public partial class Form1 : Form
    {
        Connect cont = new Connect();
        SqlConnection consql;
        DataSet ds_QL;
        DataColumn[] key = new DataColumn[1];
        public static int id = -1;
        public Form1()
        {
            InitializeComponent();
            consql = cont.connect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f_KH = new DatLich();
            f_KH.Show();
            this.Hide();
        }
        
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string query = "select * from Spa where TenSpa = N'" + txt_TenSpa.Texts + "' and Pass = N'"+txt_Pass.Texts+"'";
                SqlCommand cmd = new SqlCommand(query , consql);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string ma = rdr["MaSpa"].ToString();
                    id = int.Parse(ma.ToString());
                }

                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            if(id != -1)
            {
                Form f_AD = new Admin(id);
                f_AD.Show();
                this.Hide();

            }
        }
    }
}
