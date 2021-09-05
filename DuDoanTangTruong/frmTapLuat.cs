using DuDoanTangTruong.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuDoanTangTruong
{
    public partial class frmTapLuat : Form
    {
        Nhom18Context db = new Nhom18Context();
        public frmTapLuat()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            var query = from luat in db.TapLuats
                        select new
                        {
                            luat.MaLuat,
                            luat.DoTuoi,
                            luat.CanNang,
                            luat.LuongSua,
                            TangTruong=luat.KetQua
                        };
            dgvtapluat.DataSource = query.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        private bool check()
        {
            if (txtmaluat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã luật!");
                txtmaluat.Focus();
                return false;
            }
            else
            {
                try
                {
                    if (int.Parse(txtmaluat.Text) < 0)
                    {
                        MessageBox.Show("Bạn phải nhập mã luật là số dương!");
                        txtmaluat.Focus();
                        txtmaluat.SelectAll();
                        return false;
                    }
                    else
                    {
                        if (cbodotuoi.Text == "")
                        {
                            MessageBox.Show("Bạn phải chọn độ tuổi!");
                            return false;
                        }
                        else
                        {
                            if (cbocannang.Text == "")
                            {
                                MessageBox.Show("Bạn phải chọn cân nặng!");
                                return false;
                            }
                            else
                            {
                                if (cboluongsua.Text == "")
                                {
                                    MessageBox.Show("Bạn phải chọn lượng sữa!");
                                    return false;
                                }
                                else
                                {
                                    if (cbotangtruong.Text == "")
                                    {
                                        MessageBox.Show("Bạn phải chọn độ tăng trưởng!");
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtmaluat.Focus();
                    txtmaluat.SelectAll();
                }

            }
            return true;
        }
        private void ClearTextBox()
        {
            txtmaluat.Text = "";
            cbodotuoi.Text = "";
            cbocannang.Text = "";
            cboluongsua.Text = "";
            cbotangtruong.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                try
                {
                    TapLuat luat = db.TapLuats.SingleOrDefault(luat => luat.MaLuat == int.Parse(txtmaluat.Text));
                    if (luat != null)
                    {
                        MessageBox.Show("Mã luật " + txtmaluat.Text + " đã có trong danh sách");
                        return;
                    }
                    else
                    {
                        TapLuat luatmoi = new TapLuat();
                        luatmoi.MaLuat = int.Parse(txtmaluat.Text);
                        luatmoi.DoTuoi = cbodotuoi.Text;
                        luatmoi.CanNang = cbocannang.Text;
                        luatmoi.LuongSua = cboluongsua.Text;
                        luatmoi.KetQua = cbotangtruong.Text;
                        db.TapLuats.Add(luatmoi);
                        db.SaveChanges();
                        HienThiDuLieu();
                        ClearTextBox();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã luật phải là số");
                    return;
                }

            }


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            TapLuat luat = db.TapLuats.SingleOrDefault(luat => luat.MaLuat == int.Parse(txtmaluat.Text));
            if (luat != null)
            {
                luat.DoTuoi = cbodotuoi.Text;
                luat.CanNang = cbocannang.Text;
                luat.LuongSua = cboluongsua.Text;
                luat.KetQua = cbotangtruong.Text;
                db.SaveChanges();
                HienThiDuLieu();
                MessageBox.Show("Sửa thành công");
            }

            else
            {
                MessageBox.Show("Mã luật " + txtmaluat.Text + " không có trong danh sách, không thể sửa!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            TapLuat luatXoa = (from s in db.TapLuats
                               where s.MaLuat == int.Parse(txtmaluat.Text)
                               select s).FirstOrDefault();
            if (luatXoa != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa luật này ?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    db.TapLuats.Remove(luatXoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                    MessageBox.Show("Xóa thành công!");
                    ClearTextBox();
                }

            }
            else
            {
                MessageBox.Show("Mã luật " + txtmaluat.Text + " không có trong danh sách, Không thể xóa!");
            }
        }

        private void dgvtapluat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtmaluat.Text = dgvtapluat.Rows[index].Cells[0].Value.ToString();
            cbodotuoi.Text = dgvtapluat.Rows[index].Cells[1].Value.ToString();
            cbocannang.Text = dgvtapluat.Rows[index].Cells[2].Value.ToString();
            cboluongsua.Text = dgvtapluat.Rows[index].Cells[3].Value.ToString();
            cbotangtruong.Text = dgvtapluat.Rows[index].Cells[4].Value.ToString();
        }
        private void addForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmDoThi f = new frmDoThi();
            addForm(f);
        }
    }
}
