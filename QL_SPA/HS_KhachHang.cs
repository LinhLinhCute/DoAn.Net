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
    public partial class HS_KhachHang : Form
    {

        Connect cont = new Connect();
        SqlConnection consql;
        int id_Spa;
        string Id_DV;
        String TG;
        public HS_KhachHang(int id, string madv, String tg)
        {
            InitializeComponent();
            consql = cont.connect;
            id_Spa = id;
            Id_DV = madv;
            TG = tg;
        }
        private string MaLichLam()
        {
            string MaLich = "";
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                SqlCommand cmd = new SqlCommand("select  COUNT(*) from LichLam where MaSpa = " + id_Spa + "", consql);
                int soLichHienTai = (int)cmd.ExecuteScalar();

                // Tạo mã lịch tiếp theo
                MaLich = $"Lich{soLichHienTai + 1:D6}"; // Định dạng số thành chuỗi "Lich" + số với độ dài 6 chữ số

                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return MaLich;
        }
        private string MaKHTiep()
        {
            string MaKHachHangTiep ="";
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                SqlCommand cmd = new SqlCommand("select  COUNT(*) from KhachHang where MaSpa = " + id_Spa + "", consql);
                int soKHHienTai = (int)cmd.ExecuteScalar();

                
                MaKHachHangTiep = $"KH{soKHHienTai + 1:D3}"; 

                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return MaKHachHangTiep;
        }
        

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {

               string MaKH = MaKHTiep();
                consql.Open();
                
                string Insert;
                Insert = "insert into KhachHang values ('"+MaKH+"',N'"+txt_Ten.Text+"',N'"+txt_GioiTinh.Text +"','"+txt_SDT.Text+"',N'"+txt_DiaChi.Text+"',N'"+txt_Email.Text +"',"+id_Spa+")";
                SqlCommand cmd = new SqlCommand(Insert, consql);
                cmd.ExecuteNonQuery();
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
                string MaLL = MaLichLam();
                consql.Open();
                string Insert1;
                Insert1 = "insert into LichLam values ('"+ MaLL+ "', '" + MaKH + "', '"+Id_DV+"', '"+TG+"', N'Chờ xét duyệt', "+id_Spa+")";
                SqlCommand cmd1 = new SqlCommand(Insert1, consql);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                consql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form f_datLich = new DatLich();
            f_datLich.Show();
            this.Hide();
        }
    }
}
