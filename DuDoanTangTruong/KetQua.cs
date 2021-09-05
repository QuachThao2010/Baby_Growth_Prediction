using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuDoanTangTruong
{
    class KetQua
    {
        public float x1 { set; get; }
        public float x2 { set; get; }
        public float x3 { set; get; }
        public float x4 { set; get; }
        public float a { set; get; }
        public float b { set; get; }
        public float m1 { set; get; }
        public float m2 { set; get; }


        public KetQua()
        {

        }
        public KetQua( float x1, float x2, float x3, float x4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
        }
        public float TinhTuSo(float H) { 
            a = H * (x2 - x1);
            m1 = x1 + a;
            b = H * (x4 - x3);
            m2 = x4 - b;
            return ((H / 6) * (3 * m2 * m2 - 3 * m1 * m1 + b * b - a * a + 3 * m2 * b + 3 * m1 * a));
        }
        public float TinhMauSo(float H)
        {
            return ((H / 2) * (2 * m2 - 2 * m1 + a + b));
        }
    }
}
