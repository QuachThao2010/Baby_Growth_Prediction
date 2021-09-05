
namespace DuDoanTangTruong
{
    partial class frmTapLuat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.cbotangtruong = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.cboluongsua = new System.Windows.Forms.ComboBox();
            this.cbocannang = new System.Windows.Forms.ComboBox();
            this.cbodotuoi = new System.Windows.Forms.ComboBox();
            this.txtmaluat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtapluat = new System.Windows.Forms.DataGridView();
            this.MaLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TangTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtapluat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.cbotangtruong);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.cboluongsua);
            this.groupBox1.Controls.Add(this.cbocannang);
            this.groupBox1.Controls.Add(this.cbodotuoi);
            this.groupBox1.Controls.Add(this.txtmaluat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(40, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(199, 342);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(116, 43);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Location = new System.Drawing.Point(131, 414);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(116, 43);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // cbotangtruong
            // 
            this.cbotangtruong.FormattingEnabled = true;
            this.cbotangtruong.Items.AddRange(new object[] {
            "Thấp",
            "Vừa",
            "Cao"});
            this.cbotangtruong.Location = new System.Drawing.Point(151, 283);
            this.cbotangtruong.Name = "cbotangtruong";
            this.cbotangtruong.Size = new System.Drawing.Size(197, 36);
            this.cbotangtruong.TabIndex = 9;
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(65, 342);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(116, 43);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cboluongsua
            // 
            this.cboluongsua.FormattingEnabled = true;
            this.cboluongsua.Items.AddRange(new object[] {
            "LS loại A",
            "LS loại B",
            "LS loại C",
            "LS loại D"});
            this.cboluongsua.Location = new System.Drawing.Point(151, 228);
            this.cboluongsua.Name = "cboluongsua";
            this.cboluongsua.Size = new System.Drawing.Size(197, 36);
            this.cboluongsua.TabIndex = 8;
            // 
            // cbocannang
            // 
            this.cbocannang.FormattingEnabled = true;
            this.cbocannang.Items.AddRange(new object[] {
            "Nhẹ",
            "Bình thường",
            "Nặng"});
            this.cbocannang.Location = new System.Drawing.Point(151, 173);
            this.cbocannang.Name = "cbocannang";
            this.cbocannang.Size = new System.Drawing.Size(197, 36);
            this.cbocannang.TabIndex = 7;
            // 
            // cbodotuoi
            // 
            this.cbodotuoi.FormattingEnabled = true;
            this.cbodotuoi.Items.AddRange(new object[] {
            "0-3",
            "4-6",
            "7-12"});
            this.cbodotuoi.Location = new System.Drawing.Point(151, 118);
            this.cbodotuoi.Name = "cbodotuoi";
            this.cbodotuoi.Size = new System.Drawing.Size(197, 36);
            this.cbodotuoi.TabIndex = 6;
            // 
            // txtmaluat
            // 
            this.txtmaluat.Location = new System.Drawing.Point(151, 64);
            this.txtmaluat.Name = "txtmaluat";
            this.txtmaluat.Size = new System.Drawing.Size(197, 34);
            this.txtmaluat.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tăng trưởng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lượng sữa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cân nặng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Độ tuổi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã luật";
            // 
            // dgvtapluat
            // 
            this.dgvtapluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtapluat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuat,
            this.DoTuoi,
            this.CanNang,
            this.LuongSua,
            this.TangTruong});
            this.dgvtapluat.Location = new System.Drawing.Point(459, 48);
            this.dgvtapluat.Name = "dgvtapluat";
            this.dgvtapluat.RowHeadersWidth = 51;
            this.dgvtapluat.RowTemplate.Height = 34;
            this.dgvtapluat.Size = new System.Drawing.Size(704, 525);
            this.dgvtapluat.TabIndex = 10;
            this.dgvtapluat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtapluat_CellClick);
            // 
            // MaLuat
            // 
            this.MaLuat.DataPropertyName = "MaLuat";
            this.MaLuat.HeaderText = "Mã luật";
            this.MaLuat.MinimumWidth = 6;
            this.MaLuat.Name = "MaLuat";
            this.MaLuat.Width = 110;
            // 
            // DoTuoi
            // 
            this.DoTuoi.DataPropertyName = "DoTuoi";
            this.DoTuoi.HeaderText = "Độ tuổi";
            this.DoTuoi.MinimumWidth = 6;
            this.DoTuoi.Name = "DoTuoi";
            this.DoTuoi.Width = 110;
            // 
            // CanNang
            // 
            this.CanNang.DataPropertyName = "CanNang";
            this.CanNang.HeaderText = "Cân nặng";
            this.CanNang.MinimumWidth = 6;
            this.CanNang.Name = "CanNang";
            this.CanNang.Width = 135;
            // 
            // LuongSua
            // 
            this.LuongSua.DataPropertyName = "LuongSua";
            this.LuongSua.HeaderText = "Lượng sữa";
            this.LuongSua.MinimumWidth = 6;
            this.LuongSua.Name = "LuongSua";
            this.LuongSua.Width = 135;
            // 
            // TangTruong
            // 
            this.TangTruong.DataPropertyName = "TangTruong";
            this.TangTruong.HeaderText = "Tăng trưởng";
            this.TangTruong.MinimumWidth = 6;
            this.TangTruong.Name = "TangTruong";
            this.TangTruong.Width = 145;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(916, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đồ thị hàm phụ thuộc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTapLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(132)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1227, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtapluat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTapLuat";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtapluat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ComboBox cbotangtruong;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cboluongsua;
        private System.Windows.Forms.ComboBox cbocannang;
        private System.Windows.Forms.ComboBox cbodotuoi;
        private System.Windows.Forms.TextBox txtmaluat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtapluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TangTruong;
        private System.Windows.Forms.Button button1;
    }
}

