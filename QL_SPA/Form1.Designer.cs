namespace QL_SPA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pB_Logo = new System.Windows.Forms.PictureBox();
            this.txt_TenSpa = new RJCodeAdvance.RJControls.RJTextBox();
            this.txt_Pass = new RJCodeAdvance.RJControls.RJTextBox();
            this.btn_DangNhap = new RJCodeAdvance.RJControls.RJButton();
            this.btn_DangKy = new RJCodeAdvance.RJControls.RJButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_Logo
            // 
            this.pB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pB_Logo.Image = global::QL_SPA.Properties.Resources.spathuylieu_goc;
            this.pB_Logo.Location = new System.Drawing.Point(532, 12);
            this.pB_Logo.Name = "pB_Logo";
            this.pB_Logo.Size = new System.Drawing.Size(117, 108);
            this.pB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Logo.TabIndex = 0;
            this.pB_Logo.TabStop = false;
            // 
            // txt_TenSpa
            // 
            this.txt_TenSpa.BackColor = System.Drawing.Color.LightGray;
            this.txt_TenSpa.BorderColor = System.Drawing.Color.LightGray;
            this.txt_TenSpa.BorderFocusColor = System.Drawing.Color.LightGray;
            this.txt_TenSpa.BorderRadius = 20;
            this.txt_TenSpa.BorderSize = 2;
            this.txt_TenSpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TenSpa.Location = new System.Drawing.Point(450, 172);
            this.txt_TenSpa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSpa.MaximumSize = new System.Drawing.Size(1999, 1999);
            this.txt_TenSpa.Multiline = false;
            this.txt_TenSpa.Name = "txt_TenSpa";
            this.txt_TenSpa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenSpa.PasswordChar = false;
            this.txt_TenSpa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenSpa.PlaceholderText = "";
            this.txt_TenSpa.Size = new System.Drawing.Size(279, 31);
            this.txt_TenSpa.TabIndex = 2;
            this.txt_TenSpa.Texts = "Tên Spa";
            this.txt_TenSpa.UnderlinedStyle = false;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.LightGray;
            this.txt_Pass.BorderColor = System.Drawing.Color.LightGray;
            this.txt_Pass.BorderFocusColor = System.Drawing.Color.LightGray;
            this.txt_Pass.BorderRadius = 20;
            this.txt_Pass.BorderSize = 2;
            this.txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Pass.Location = new System.Drawing.Point(450, 240);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Multiline = false;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Pass.PasswordChar = true;
            this.txt_Pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Pass.PlaceholderText = "";
            this.txt_Pass.Size = new System.Drawing.Size(279, 31);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.Texts = "";
            this.txt_Pass.UnderlinedStyle = false;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.LightCoral;
            this.btn_DangNhap.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DangNhap.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_DangNhap.BorderRadius = 20;
            this.btn_DangNhap.BorderSize = 0;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Location = new System.Drawing.Point(397, 303);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(152, 48);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Dang Nhap";
            this.btn_DangNhap.TextColor = System.Drawing.Color.Black;
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.LightCoral;
            this.btn_DangKy.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btn_DangKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DangKy.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_DangKy.BorderRadius = 20;
            this.btn_DangKy.BorderSize = 0;
            this.btn_DangKy.FlatAppearance.BorderSize = 0;
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.Black;
            this.btn_DangKy.Location = new System.Drawing.Point(577, 303);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(152, 48);
            this.btn_DangKy.TabIndex = 5;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.TextColor = System.Drawing.Color.Black;
            this.btn_DangKy.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(484, 379);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bạn là khách hàng ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(752, 497);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_TenSpa);
            this.Controls.Add(this.pB_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Logo;
        private RJCodeAdvance.RJControls.RJTextBox txt_TenSpa;
        private RJCodeAdvance.RJControls.RJTextBox txt_Pass;
        private RJCodeAdvance.RJControls.RJButton btn_DangNhap;
        private RJCodeAdvance.RJControls.RJButton btn_DangKy;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

