namespace QLTV
{
    partial class frmSach
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
            this.dgvQLS = new System.Windows.Forms.DataGridView();
            this.dgvMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTriGia = new System.Windows.Forms.CheckBox();
            this.chkNamXB = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.chkThang = new System.Windows.Forms.CheckBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkNgayNhap = new System.Windows.Forms.CheckBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSLS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQLS
            // 
            this.dgvQLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSach,
            this.dgvTenSach,
            this.dgvTacGia,
            this.dgvNamXB,
            this.dgvNhaXB,
            this.dgvTriGia,
            this.dgvNgayNhap});
            this.dgvQLS.Location = new System.Drawing.Point(12, 600);
            this.dgvQLS.Name = "dgvQLS";
            this.dgvQLS.ReadOnly = true;
            this.dgvQLS.RowHeadersWidth = 82;
            this.dgvQLS.RowTemplate.Height = 33;
            this.dgvQLS.Size = new System.Drawing.Size(1945, 501);
            this.dgvQLS.TabIndex = 0;
            this.dgvQLS.DoubleClick += new System.EventHandler(this.dgvQLS_DoubleClick);
            // 
            // dgvMaSach
            // 
            this.dgvMaSach.HeaderText = "Mã Sách";
            this.dgvMaSach.MinimumWidth = 10;
            this.dgvMaSach.Name = "dgvMaSach";
            this.dgvMaSach.ReadOnly = true;
            // 
            // dgvTenSach
            // 
            this.dgvTenSach.HeaderText = "Tên Sách";
            this.dgvTenSach.MinimumWidth = 10;
            this.dgvTenSach.Name = "dgvTenSach";
            this.dgvTenSach.ReadOnly = true;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.HeaderText = "Tác Giả";
            this.dgvTacGia.MinimumWidth = 10;
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            // 
            // dgvNamXB
            // 
            this.dgvNamXB.HeaderText = "Năm XB";
            this.dgvNamXB.MinimumWidth = 10;
            this.dgvNamXB.Name = "dgvNamXB";
            this.dgvNamXB.ReadOnly = true;
            // 
            // dgvNhaXB
            // 
            this.dgvNhaXB.HeaderText = "Nhà XB";
            this.dgvNhaXB.MinimumWidth = 10;
            this.dgvNhaXB.Name = "dgvNhaXB";
            this.dgvNhaXB.ReadOnly = true;
            // 
            // dgvTriGia
            // 
            this.dgvTriGia.HeaderText = "Trị Giá";
            this.dgvTriGia.MinimumWidth = 10;
            this.dgvTriGia.Name = "dgvTriGia";
            this.dgvTriGia.ReadOnly = true;
            // 
            // dgvNgayNhap
            // 
            this.dgvNgayNhap.HeaderText = "Ngày Nhập";
            this.dgvNgayNhap.MinimumWidth = 10;
            this.dgvNgayNhap.Name = "dgvNgayNhap";
            this.dgvNgayNhap.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(644, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thông Tin Sách";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác Giả";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 55);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm XB";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(558, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 55);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Nhập";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(558, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 55);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhà XB";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(558, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 55);
            this.label7.TabIndex = 2;
            this.label7.Text = "Trị Giá";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(241, 150);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(297, 50);
            this.txtTenSach.TabIndex = 3;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(241, 257);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(297, 50);
            this.txtTacGia.TabIndex = 3;
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(841, 262);
            this.txtTriGia.Multiline = true;
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(293, 50);
            this.txtTriGia.TabIndex = 3;
            this.txtTriGia.TextChanged += new System.EventHandler(this.txtTriGia_TextChanged);
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(841, 154);
            this.txtNhaXB.Multiline = true;
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(293, 50);
            this.txtNhaXB.TabIndex = 3;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(241, 376);
            this.txtNamXB.Multiline = true;
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(297, 50);
            this.txtNamXB.TabIndex = 3;
            this.txtNamXB.TextChanged += new System.EventHandler(this.txtNamXB_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtNamXB);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNhaXB);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtTriGia);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(10, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 445);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkTriGia);
            this.groupBox2.Controls.Add(this.chkNamXB);
            this.groupBox2.Controls.Add(this.chkNam);
            this.groupBox2.Controls.Add(this.chkNgay);
            this.groupBox2.Controls.Add(this.chkThang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(1169, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 431);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc Thông Tin";
            // 
            // chkTriGia
            // 
            this.chkTriGia.AutoSize = true;
            this.chkTriGia.Location = new System.Drawing.Point(17, 319);
            this.chkTriGia.Name = "chkTriGia";
            this.chkTriGia.Size = new System.Drawing.Size(239, 46);
            this.chkTriGia.TabIndex = 0;
            this.chkTriGia.Text = "Trị Giá (>=)";
            this.chkTriGia.UseVisualStyleBackColor = true;
            // 
            // chkNamXB
            // 
            this.chkNamXB.AutoSize = true;
            this.chkNamXB.Location = new System.Drawing.Point(17, 249);
            this.chkNamXB.Name = "chkNamXB";
            this.chkNamXB.Size = new System.Drawing.Size(360, 46);
            this.chkNamXB.TabIndex = 0;
            this.chkNamXB.Text = "Năm Xuất Bản(>=)";
            this.chkNamXB.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(17, 184);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(324, 46);
            this.chkNam.TabIndex = 0;
            this.chkNam.Text = "Theo Năm Nhập";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // chkNgay
            // 
            this.chkNgay.AutoSize = true;
            this.chkNgay.Location = new System.Drawing.Point(17, 48);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Size = new System.Drawing.Size(334, 46);
            this.chkNgay.TabIndex = 0;
            this.chkNgay.Text = "Theo Ngày Nhập";
            this.chkNgay.UseVisualStyleBackColor = true;
            // 
            // chkThang
            // 
            this.chkThang.AutoSize = true;
            this.chkThang.Location = new System.Drawing.Point(17, 118);
            this.chkThang.Name = "chkThang";
            this.chkThang.Size = new System.Drawing.Size(353, 46);
            this.chkThang.TabIndex = 0;
            this.chkThang.Text = "Theo Tháng Nhập";
            this.chkThang.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(841, 371);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(293, 56);
            this.dtpNgayNhap.TabIndex = 6;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSach.Location = new System.Drawing.Point(435, 48);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(69, 55);
            this.txtMaSach.TabIndex = 3;
            this.txtMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtNamXB_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(12, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(417, 55);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã sách đang chọn";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(1543, 240);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(201, 78);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(1756, 240);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(201, 78);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbnSua
            // 
            this.tbnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbnSua.Location = new System.Drawing.Point(1543, 343);
            this.tbnSua.Name = "tbnSua";
            this.tbnSua.Size = new System.Drawing.Size(201, 78);
            this.tbnSua.TabIndex = 5;
            this.tbnSua.Text = "Sửa";
            this.tbnSua.UseVisualStyleBackColor = true;
            this.tbnSua.Click += new System.EventHandler(this.tbnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1756, 343);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(201, 78);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(1751, 441);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(201, 78);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.Text = "Tìm Kiếm";
            this.txtTimKiem.UseVisualStyleBackColor = true;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Location = new System.Drawing.Point(1543, 441);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(201, 78);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkNgayNhap
            // 
            this.chkNgayNhap.AutoSize = true;
            this.chkNgayNhap.BackColor = System.Drawing.Color.Transparent;
            this.chkNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkNgayNhap.Location = new System.Drawing.Point(12, 539);
            this.chkNgayNhap.Name = "chkNgayNhap";
            this.chkNgayNhap.Size = new System.Drawing.Size(536, 55);
            this.chkNgayNhap.TabIndex = 6;
            this.chkNgayNhap.Text = "Tìm kiếm theo ngày nhập";
            this.chkNgayNhap.UseVisualStyleBackColor = false;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Location = new System.Drawing.Point(1543, 152);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(409, 78);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc Thông Tin";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1429, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 55);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số lượng sách";
            // 
            // txtSLS
            // 
            this.txtSLS.Enabled = false;
            this.txtSLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSLS.Location = new System.Drawing.Point(1768, 539);
            this.txtSLS.Multiline = true;
            this.txtSLS.Name = "txtSLS";
            this.txtSLS.Size = new System.Drawing.Size(184, 55);
            this.txtSLS.TabIndex = 3;
            this.txtSLS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1964, 1113);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkNgayNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.txtSLS);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLS);
            this.Name = "frmSach";
            this.Text = "Thông Tin Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button tbnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkNgayNhap;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.CheckBox chkThang;
        private System.Windows.Forms.CheckBox chkTriGia;
        private System.Windows.Forms.CheckBox chkNamXB;
        private System.Windows.Forms.CheckBox chkNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSLS;
    }
}