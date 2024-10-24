namespace Lab05
{
    partial class frmRegister
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
            this.lblKhoaRegist = new System.Windows.Forms.Label();
            this.cmbKhoaRegist = new System.Windows.Forms.ComboBox();
            this.lblChuyenNganhRegist = new System.Windows.Forms.Label();
            this.cmbChuyenNganhRegist = new System.Windows.Forms.ComboBox();
            this.dgvSinhVienDangKY = new System.Windows.Forms.DataGridView();
            this.lblTieuDeRegist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienDangKY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKhoaRegist
            // 
            this.lblKhoaRegist.AutoSize = true;
            this.lblKhoaRegist.Location = new System.Drawing.Point(395, 114);
            this.lblKhoaRegist.Name = "lblKhoaRegist";
            this.lblKhoaRegist.Size = new System.Drawing.Size(41, 16);
            this.lblKhoaRegist.TabIndex = 0;
            this.lblKhoaRegist.Text = "Khoa:";
            // 
            // cmbKhoaRegist
            // 
            this.cmbKhoaRegist.FormattingEnabled = true;
            this.cmbKhoaRegist.Location = new System.Drawing.Point(439, 111);
            this.cmbKhoaRegist.Name = "cmbKhoaRegist";
            this.cmbKhoaRegist.Size = new System.Drawing.Size(523, 24);
            this.cmbKhoaRegist.TabIndex = 1;
            this.cmbKhoaRegist.SelectedIndexChanged += new System.EventHandler(this.cmbKhoaRegist_SelectedIndexChanged);
            // 
            // lblChuyenNganhRegist
            // 
            this.lblChuyenNganhRegist.AutoSize = true;
            this.lblChuyenNganhRegist.Location = new System.Drawing.Point(341, 161);
            this.lblChuyenNganhRegist.Name = "lblChuyenNganhRegist";
            this.lblChuyenNganhRegist.Size = new System.Drawing.Size(95, 16);
            this.lblChuyenNganhRegist.TabIndex = 0;
            this.lblChuyenNganhRegist.Text = "Chuyên ngành:";
            // 
            // cmbChuyenNganhRegist
            // 
            this.cmbChuyenNganhRegist.FormattingEnabled = true;
            this.cmbChuyenNganhRegist.Location = new System.Drawing.Point(439, 158);
            this.cmbChuyenNganhRegist.Name = "cmbChuyenNganhRegist";
            this.cmbChuyenNganhRegist.Size = new System.Drawing.Size(523, 24);
            this.cmbChuyenNganhRegist.TabIndex = 1;
            // 
            // dgvSinhVienDangKY
            // 
            this.dgvSinhVienDangKY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVienDangKY.Location = new System.Drawing.Point(12, 207);
            this.dgvSinhVienDangKY.Name = "dgvSinhVienDangKY";
            this.dgvSinhVienDangKY.RowHeadersWidth = 51;
            this.dgvSinhVienDangKY.RowTemplate.Height = 24;
            this.dgvSinhVienDangKY.Size = new System.Drawing.Size(1375, 276);
            this.dgvSinhVienDangKY.TabIndex = 2;
            this.dgvSinhVienDangKY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVienDangKY_CellContentClick);
            // 
            // lblTieuDeRegist
            // 
            this.lblTieuDeRegist.AutoSize = true;
            this.lblTieuDeRegist.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeRegist.Location = new System.Drawing.Point(263, 18);
            this.lblTieuDeRegist.Name = "lblTieuDeRegist";
            this.lblTieuDeRegist.Size = new System.Drawing.Size(833, 78);
            this.lblTieuDeRegist.TabIndex = 3;
            this.lblTieuDeRegist.Text = "Đăng ký chuyên ngành";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 500);
            this.Controls.Add(this.lblTieuDeRegist);
            this.Controls.Add(this.dgvSinhVienDangKY);
            this.Controls.Add(this.cmbChuyenNganhRegist);
            this.Controls.Add(this.lblChuyenNganhRegist);
            this.Controls.Add(this.cmbKhoaRegist);
            this.Controls.Add(this.lblKhoaRegist);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienDangKY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKhoaRegist;
        private System.Windows.Forms.ComboBox cmbKhoaRegist;
        private System.Windows.Forms.Label lblChuyenNganhRegist;
        private System.Windows.Forms.ComboBox cmbChuyenNganhRegist;
        private System.Windows.Forms.DataGridView dgvSinhVienDangKY;
        private System.Windows.Forms.Label lblTieuDeRegist;
    }
}