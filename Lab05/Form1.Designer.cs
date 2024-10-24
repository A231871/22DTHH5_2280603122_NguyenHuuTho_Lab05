namespace Lab05
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.txtDTBSV = new System.Windows.Forms.TextBox();
            this.cmbKhoaSV = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.clnMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHotenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnKhoaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDTBSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnChuyenNganhSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStudentInfoMenu = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblAnhDaiDien = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.chkKhongChuyenNganh = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpStudentInfoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMSSV
            // 
            this.txtMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMSSV.Location = new System.Drawing.Point(108, 57);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 22);
            this.txtMSSV.TabIndex = 19;
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHotenSV.Location = new System.Drawing.Point(108, 85);
            this.txtHotenSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(150, 22);
            this.txtHotenSV.TabIndex = 20;
            // 
            // txtDTBSV
            // 
            this.txtDTBSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDTBSV.Location = new System.Drawing.Point(108, 113);
            this.txtDTBSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDTBSV.Name = "txtDTBSV";
            this.txtDTBSV.Size = new System.Drawing.Size(150, 22);
            this.txtDTBSV.TabIndex = 21;
            // 
            // cmbKhoaSV
            // 
            this.cmbKhoaSV.AccessibleName = "";
            this.cmbKhoaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoaSV.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "KTXD",
            "KTMT",
            "KT",
            "QTKS",
            "TKTT",
            "TKNT",
            "NNA"});
            this.cmbKhoaSV.Location = new System.Drawing.Point(108, 142);
            this.cmbKhoaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhoaSV.Name = "cmbKhoaSV";
            this.cmbKhoaSV.Size = new System.Drawing.Size(151, 24);
            this.cmbKhoaSV.TabIndex = 22;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudents.ColumnHeadersHeight = 29;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMSSV,
            this.clnHotenSV,
            this.clnKhoaSV,
            this.clnDTBSV,
            this.clnChuyenNganhSV});
            this.dgvStudents.Location = new System.Drawing.Point(341, 89);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.Size = new System.Drawing.Size(1045, 306);
            this.dgvStudents.TabIndex = 24;
            this.dgvStudents.TabStop = false;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // clnMSSV
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clnMSSV.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnMSSV.HeaderText = "MSSV";
            this.clnMSSV.MinimumWidth = 6;
            this.clnMSSV.Name = "clnMSSV";
            this.clnMSSV.ReadOnly = true;
            // 
            // clnHotenSV
            // 
            this.clnHotenSV.HeaderText = "Họ Tên";
            this.clnHotenSV.MinimumWidth = 6;
            this.clnHotenSV.Name = "clnHotenSV";
            this.clnHotenSV.ReadOnly = true;
            // 
            // clnKhoaSV
            // 
            this.clnKhoaSV.HeaderText = "Khoa";
            this.clnKhoaSV.MinimumWidth = 6;
            this.clnKhoaSV.Name = "clnKhoaSV";
            this.clnKhoaSV.ReadOnly = true;
            // 
            // clnDTBSV
            // 
            this.clnDTBSV.HeaderText = "ĐTB";
            this.clnDTBSV.MinimumWidth = 6;
            this.clnDTBSV.Name = "clnDTBSV";
            this.clnDTBSV.ReadOnly = true;
            // 
            // clnChuyenNganhSV
            // 
            this.clnChuyenNganhSV.HeaderText = "ChuyenNganh";
            this.clnChuyenNganhSV.MinimumWidth = 6;
            this.clnChuyenNganhSV.Name = "clnChuyenNganhSV";
            this.clnChuyenNganhSV.ReadOnly = true;
            // 
            // grpStudentInfoMenu
            // 
            this.grpStudentInfoMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpStudentInfoMenu.Controls.Add(this.btnUpload);
            this.grpStudentInfoMenu.Controls.Add(this.txtMSSV);
            this.grpStudentInfoMenu.Controls.Add(this.picAnhDaiDien);
            this.grpStudentInfoMenu.Controls.Add(this.txtHotenSV);
            this.grpStudentInfoMenu.Controls.Add(this.lblMSSV);
            this.grpStudentInfoMenu.Controls.Add(this.cmbKhoaSV);
            this.grpStudentInfoMenu.Controls.Add(this.txtDTBSV);
            this.grpStudentInfoMenu.Controls.Add(this.lblHoTen);
            this.grpStudentInfoMenu.Controls.Add(this.lblDTB);
            this.grpStudentInfoMenu.Controls.Add(this.lblAnhDaiDien);
            this.grpStudentInfoMenu.Controls.Add(this.lblKhoa);
            this.grpStudentInfoMenu.Controls.Add(this.btnAddOrUpdate);
            this.grpStudentInfoMenu.Controls.Add(this.btnDelete);
            this.grpStudentInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentInfoMenu.Location = new System.Drawing.Point(11, 60);
            this.grpStudentInfoMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudentInfoMenu.Name = "grpStudentInfoMenu";
            this.grpStudentInfoMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudentInfoMenu.Size = new System.Drawing.Size(312, 428);
            this.grpStudentInfoMenu.TabIndex = 28;
            this.grpStudentInfoMenu.TabStop = false;
            this.grpStudentInfoMenu.Text = "Thông tin sinh viên";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(264, 292);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(43, 23);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "...";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.BackgroundImage = global::Lab05.Properties.Resources.profile_picture;
            this.picAnhDaiDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnhDaiDien.Location = new System.Drawing.Point(25, 199);
            this.picAnhDaiDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(232, 168);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhDaiDien.TabIndex = 18;
            this.picAnhDaiDien.TabStop = false;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(21, 59);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(53, 16);
            this.lblMSSV.TabIndex = 13;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(21, 87);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(56, 16);
            this.lblHoTen.TabIndex = 14;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTB.Location = new System.Drawing.Point(21, 114);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(70, 16);
            this.lblDTB.TabIndex = 16;
            this.lblDTB.Text = "Điểm TB:";
            // 
            // lblAnhDaiDien
            // 
            this.lblAnhDaiDien.AutoSize = true;
            this.lblAnhDaiDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnhDaiDien.Location = new System.Drawing.Point(21, 180);
            this.lblAnhDaiDien.Name = "lblAnhDaiDien";
            this.lblAnhDaiDien.Size = new System.Drawing.Size(97, 16);
            this.lblAnhDaiDien.TabIndex = 17;
            this.lblAnhDaiDien.Text = "Ảnh đại diện:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(21, 144);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(46, 16);
            this.lblKhoa.TabIndex = 17;
            this.lblKhoa.Text = "Khoa:";
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddOrUpdate.Location = new System.Drawing.Point(24, 374);
            this.btnAddOrUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(153, 30);
            this.btnAddOrUpdate.TabIndex = 7;
            this.btnAddOrUpdate.Text = "Thêm / Sửa";
            this.btnAddOrUpdate.UseVisualStyleBackColor = false;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.Location = new System.Drawing.Point(208, 373);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(328, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(668, 78);
            this.lblTieuDe.TabIndex = 29;
            this.lblTieuDe.Text = "Quản Lý Sinh Viên";
            // 
            // chkKhongChuyenNganh
            // 
            this.chkKhongChuyenNganh.AutoSize = true;
            this.chkKhongChuyenNganh.Location = new System.Drawing.Point(1197, 63);
            this.chkKhongChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkKhongChuyenNganh.Name = "chkKhongChuyenNganh";
            this.chkKhongChuyenNganh.Size = new System.Drawing.Size(166, 20);
            this.chkKhongChuyenNganh.TabIndex = 30;
            this.chkKhongChuyenNganh.Text = "Chưa ĐK chuyên ngành";
            this.chkKhongChuyenNganh.UseVisualStyleBackColor = true;
            this.chkKhongChuyenNganh.CheckedChanged += new System.EventHandler(this.chkKhongChuyenNganh_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(341, 434);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(84, 30);
            this.btnRegister.TabIndex = 31;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 500);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkKhongChuyenNganh);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.grpStudentInfoMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpStudentInfoMenu.ResumeLayout(false);
            this.grpStudentInfoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHotenSV;
        private System.Windows.Forms.TextBox txtDTBSV;
        private System.Windows.Forms.ComboBox cmbKhoaSV;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpStudentInfoMenu;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblAnhDaiDien;
        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.CheckBox chkKhongChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHotenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnKhoaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDTBSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnChuyenNganhSV;
        private System.Windows.Forms.Button btnRegister;
    }
}

