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
using System.Runtime.InteropServices;




namespace DuDoanTangTruong
{
    public partial class frmDuDoan : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        Nhom18Context db = new Nhom18Context();
        public frmDuDoan()
        {
            InitializeComponent();
        }
        private float MoHoa(float x, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
        {
             if(x >= x1 && x <= x2)
            {
                return (x - x1) * (y2 - y1) / (x2 - x1) + y1;
            }
            else if (x >= x2 && x <= x3)
            {
                return (x - x2) * (y3 - y2) / (x3 - x2) + y2;
            }
            else if (x >= x3 && x <= x4)
            {
                return (x - x3) * (y4 - y3) / (x4 - x3) + y3;
            }
            else
            {
                return 0;
            }
        }
        
        private void DuDoan()
        {
            // Độ tuổi
            float DT = float.Parse(txtDoTuoi.Text);
            float DT0_3 = MoHoa(DT, 0, 1, 0, 1, 3, 1, 6, 0);
            float DT3_6 = MoHoa(DT, (float)1.5, 0, 3, 1, 6, 1, 9, 0);
            float DT6_12 = MoHoa(DT, 4, 0, 6, 1, 12, 1, 12, 1);
            // Cân nặng
            float CN = float.Parse(txtCanNang.Text);
            float CN_nhe = MoHoa(CN, (float)1.5, 0, 2, 1, (float)2.5, 1, 3, 0);
            float CN_binhthuong = MoHoa(CN, 2, 0, (float)2.5, 1, 4, 1, (float)4.5, 0);
            float CN_nang = MoHoa(CN, 3, 0, 4, 0, 5, 0, 5, 0);
            //Lượng sữa
            float LS = float.Parse(txtLuongSua.Text);
            float LS_A = MoHoa(LS, 50, 0, 100, 1, 150, 1, 250, 0);
            float LS_B = MoHoa(LS, 100, 0, 200, 1, 300, 1, 450, 0);
            float LS_C = MoHoa(LS, 300, 0, 450, 1, 550, 1, 750, 0);
            float LS_D = MoHoa(LS, 500, 0, 700, 1, 850, 1, 950, 0);
            //Kết quả
            KetQua kqThap = new KetQua(0, (float)0.4, (float)0.8, (float)0.8);
            KetQua kqVua = new KetQua((float)0.6, (float)0.8, (float)0.8, (float)1.2);
            KetQua kqCao = new KetQua((float)0.8, (float)1.2, (float)1.4, (float)1.6);
            var query = from s in db.TapLuats
                        orderby s.MaLuat
                        select s;
            float tuoi = 0, canNang = 0, luongSua = 0, tuSo = 0, mauSo = 0;
            KetQua ketqua = new KetQua();
            foreach (var item in query)
            {
                if(item.DoTuoi == "0-3")
                    tuoi = DT0_3;
                if (item.DoTuoi == "3-6")
                    tuoi = DT3_6;
                if (item.DoTuoi == "6-12")
                    tuoi = DT6_12;

                if (item.CanNang == "Nhẹ")
                    canNang = CN_nhe;
                if (item.CanNang == "Bình thường")
                    canNang = CN_binhthuong;
                if (item.CanNang == "Nặng")
                    canNang = CN_nang;

                if (item.LuongSua == "LS loại A")
                    luongSua = LS_A;
                if (item.LuongSua == "LS loại B")
                    luongSua = LS_B;
                if (item.LuongSua == "LS loại C")
                    luongSua = LS_C;
                if (item.LuongSua == "LS loại D")
                    luongSua = LS_D;

                if (item.KetQua == "Thấp")
                    ketqua = kqThap;
                if (item.KetQua == "Vừa")
                    ketqua = kqVua;
                if (item.KetQua == "Cao")
                    ketqua = kqCao;

                float min = Math.Min(tuoi, Math.Min(canNang, luongSua));
                if (min != 0)
                {
                    tuSo += ketqua.TinhTuSo(min);
                    mauSo += ketqua.TinhMauSo(min);
                }

            }
            txtTangTruong.Text = (tuSo / mauSo).ToString();
        }

        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                DuDoan();
            }
        }

        private void txtDoTuoi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDoTuoi, "");
        }

        private void txtCanNang_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCanNang, "");
        }

        private void txtLuongSua_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtLuongSua, "");
        }
        private bool validData()
        {
            if(txtDoTuoi.Text == "")
            {
                errorProvider1.SetError(txtDoTuoi, "Bạn phải nhập độ tuổi của bé");
                txtDoTuoi.Focus();
                return false;
            }
            else
            {
                try
                {
                    float tuoi = float.Parse(txtDoTuoi.Text);
                    if(tuoi < 0 || tuoi > 12)
                    {
                        errorProvider1.SetError(txtDoTuoi, "Nhập độ tuổi lớn hơn 0 và nhỏ hơn 12 tháng");
                        txtDoTuoi.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtDoTuoi, "Nhập độ tuổi là số");
                    txtDoTuoi.Focus();
                    return false;
                }
            }
            if (txtCanNang.Text == "")
            {
                errorProvider1.SetError(txtCanNang, "Bạn phải nhập cân nặng của bé");
                txtCanNang.Focus();
                return false;
            }
            else
            {
                try
                {
                    float canNang = float.Parse(txtCanNang.Text);
                    if (canNang < 1.5 || canNang > 5)
                    {
                        errorProvider1.SetError(txtCanNang, "Nhập cân nặng lớn hơn 1.5 và nhỏ hơn 5 kg");
                        txtCanNang.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtCanNang, "Nhập cân n là số");
                    txtCanNang.SelectAll();
                    return false;
                }
            }
            if (txtLuongSua.Text == "")
            {
                errorProvider1.SetError(txtLuongSua, "Bạn phải nhập lượng sữa uống hàng ngày");
                txtLuongSua.Focus();
                return false;
            }
            else
            {
                try
                {
                    float luongSua = float.Parse(txtLuongSua.Text);
                    if (luongSua < 50 || luongSua > 950)
                    {
                        errorProvider1.SetError(txtLuongSua, "Nhập lượng sữa lớn hơn 50ml và nhỏ hơn 950ml");
                        txtLuongSua.SelectAll();
                        return false;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtLuongSua, "Nhập lượng sữa là số");
                    txtLuongSua.SelectAll();
                    return false;
                }
            }
            return true;
        }//kiểm tra dữu liệu người dùng
    }
}
