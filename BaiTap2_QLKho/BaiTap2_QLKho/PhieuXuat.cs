using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class PhieuXuat
    {
        string TenHang;
        int SLXuat;
        string ViTri;

        public string GetTenHang()
        {
            return TenHang;
        }
        public int GetSLXuat()
        {
            return SLXuat;
        }
        public string GetViTri()
        {
            return ViTri;
        }
        public void HienThiPhieu()
        {
            Console.WriteLine("Ten hang: "+ GetTenHang());
            Console.WriteLine("So luong xuat: " + GetSLXuat());
            Console.WriteLine("Vi tri: " + GetViTri());
        }
    }
}
