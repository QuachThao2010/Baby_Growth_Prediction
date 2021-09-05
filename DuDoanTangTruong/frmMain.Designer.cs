
namespace DuDoanTangTruong
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTapLuat = new FontAwesome.Sharp.IconButton();
            this.btnDuDoan = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbView = new System.Windows.Forms.Label();
            this.iconView = new FontAwesome.Sharp.IconPictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.pnlMenu.Controls.Add(this.btnTapLuat);
            this.pnlMenu.Controls.Add(this.btnDuDoan);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(222, 785);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnTapLuat
            // 
            this.btnTapLuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTapLuat.FlatAppearance.BorderSize = 0;
            this.btnTapLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTapLuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTapLuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTapLuat.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnTapLuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTapLuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTapLuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTapLuat.Location = new System.Drawing.Point(0, 258);
            this.btnTapLuat.Name = "btnTapLuat";
            this.btnTapLuat.Size = new System.Drawing.Size(222, 60);
            this.btnTapLuat.TabIndex = 3;
            this.btnTapLuat.Text = "Tập luật";
            this.btnTapLuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTapLuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTapLuat.UseVisualStyleBackColor = true;
            this.btnTapLuat.Click += new System.EventHandler(this.btnTapLuat_Click);
            // 
            // btnDuDoan
            // 
            this.btnDuDoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuDoan.FlatAppearance.BorderSize = 0;
            this.btnDuDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuDoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDuDoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDuDoan.IconChar = FontAwesome.Sharp.IconChar.Baby;
            this.btnDuDoan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDuDoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDuDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuDoan.Location = new System.Drawing.Point(0, 198);
            this.btnDuDoan.Name = "btnDuDoan";
            this.btnDuDoan.Size = new System.Drawing.Size(222, 60);
            this.btnDuDoan.TabIndex = 2;
            this.btnDuDoan.Text = "Dự đoán";
            this.btnDuDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuDoan.UseVisualStyleBackColor = true;
            this.btnDuDoan.Click += new System.EventHandler(this.btnDuDoan_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 138);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(222, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 138);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DuDoanTangTruong.Properties.Resources.Capture3_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.lbView);
            this.panel1.Controls.Add(this.iconView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(222, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 66);
            this.panel1.TabIndex = 1;
            // 
            // lbView
            // 
            this.lbView.AutoSize = true;
            this.lbView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbView.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbView.Location = new System.Drawing.Point(112, 35);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(56, 23);
            this.lbView.TabIndex = 1;
            this.lbView.Text = "Home";
            // 
            // iconView
            // 
            this.iconView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.iconView.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconView.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconView.IconColor = System.Drawing.Color.Gainsboro;
            this.iconView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconView.IconSize = 47;
            this.iconView.Location = new System.Drawing.Point(49, 21);
            this.iconView.Name = "iconView";
            this.iconView.Size = new System.Drawing.Size(47, 48);
            this.iconView.TabIndex = 0;
            this.iconView.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(222, 66);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1268, 719);
            this.pnlContent.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 785);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnTapLuat;
        private FontAwesome.Sharp.IconButton btnDuDoan;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbView;
        private FontAwesome.Sharp.IconPictureBox iconView;
        private System.Windows.Forms.Panel pnlContent;
    }
}