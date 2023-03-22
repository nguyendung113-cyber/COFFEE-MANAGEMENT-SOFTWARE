namespace QuanLyCoffee
{
    partial class frmTrangChu
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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.btnNguyenLieu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Bisque;
            this.panel_Left.Controls.Add(this.btnNguyenLieu);
            this.panel_Left.Controls.Add(this.panel1);
            this.panel_Left.Controls.Add(this.btnDangXuat);
            this.panel_Left.Controls.Add(this.btnTaiKhoan);
            this.panel_Left.Controls.Add(this.btnSanPham);
            this.panel_Left.Controls.Add(this.btnThongKe);
            this.panel_Left.Controls.Add(this.panel_Body);
            this.panel_Left.Controls.Add(this.btnHoaDon);
            this.panel_Left.Controls.Add(this.btnBanHang);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(1484, 771);
            this.panel_Left.TabIndex = 0;
            this.panel_Left.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Left_Paint);
            // 
            // btnNguyenLieu
            // 
            this.btnNguyenLieu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNguyenLieu.Location = new System.Drawing.Point(-1, 434);
            this.btnNguyenLieu.Name = "btnNguyenLieu";
            this.btnNguyenLieu.Size = new System.Drawing.Size(254, 79);
            this.btnNguyenLieu.TabIndex = 9;
            this.btnNguyenLieu.Text = "Nguyên Liệu";
            this.btnNguyenLieu.UseVisualStyleBackColor = false;
            this.btnNguyenLieu.Click += new System.EventHandler(this.btnNguyenLieu_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyCoffee.Properties.Resources.pngwing_com;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 133);
            this.panel1.TabIndex = 8;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.Location = new System.Drawing.Point(-2, 688);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(255, 80);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Bisque;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Location = new System.Drawing.Point(-2, 602);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(255, 81);
            this.btnTaiKhoan.TabIndex = 0;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSanPham.BackColor = System.Drawing.Color.Bisque;
            this.btnSanPham.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnSanPham.Location = new System.Drawing.Point(-2, 518);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(255, 81);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThongKe.BackColor = System.Drawing.Color.Bisque;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(-1, 348);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(255, 81);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.BackColor = System.Drawing.Color.Salmon;
            this.panel_Body.BackgroundImage = global::QuanLyCoffee.Properties.Resources.coffee_background;
            this.panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Body.Location = new System.Drawing.Point(259, 2);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1223, 767);
            this.panel_Body.TabIndex = 2;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHoaDon.BackColor = System.Drawing.Color.Bisque;
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Location = new System.Drawing.Point(-1, 263);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(255, 81);
            this.btnHoaDon.TabIndex = 7;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBanHang.BackColor = System.Drawing.Color.Bisque;
            this.btnBanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanHang.CausesValidation = false;
            this.btnBanHang.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.Black;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBanHang.Location = new System.Drawing.Point(-1, 179);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(255, 81);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "Đặt món";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 771);
            this.Controls.Add(this.panel_Left);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán Cafe";
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNguyenLieu;
    }
}

