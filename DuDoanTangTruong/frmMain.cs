using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;

namespace DuDoanTangTruong
{
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBtn;
        public frmMain()
        {
            InitializeComponent();
            leftBtn = new Panel();
            leftBtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(leftBtn);
        }
        private struct RGBcolor
        {
            public static Color cl1 = Color.FromArgb(255, 231, 186);
        }
        private void ActivateBtn(object senderBtn, Color cl)
        {

            if (senderBtn != null)
            {
                disableBtn();
                //nut
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(238, 169, 184);
                currentBtn.ForeColor = cl;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = cl;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //vien
                leftBtn.BackColor = cl;
                leftBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBtn.Visible = true;
                leftBtn.BringToFront();
                //view
                iconView.IconChar = currentBtn.IconChar;
                iconView.IconColor = cl;
                lbView.Text = currentBtn.Text;
                lbView.ForeColor = cl;
            }
        }
        private void disableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(139, 71, 93);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void addForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            frmHome f = new frmHome();
            addForm(f);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            this.pnlContent.Controls.Clear();
            frmHome f = new frmHome();
            addForm(f);
        }

        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            this.pnlContent.Controls.Clear();
            frmDuDoan f = new frmDuDoan();
            addForm(f);

        }

        private void btnTapLuat_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.cl1);
            this.pnlContent.Controls.Clear();
            frmTapLuat f = new frmTapLuat();
            addForm(f);
        }

    }
}
