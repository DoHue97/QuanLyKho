using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class HangHoa
    {
        public string MaHang;
        public string TenHang;
        public int SLHang;
        int Gia;
        public float DTCanChua;

        public void SetSL(int SLg)
        {
            SLHang = SLg;
        }
        public int GetSL()
        {
            return SLHang;
        }       
        public float GetDTCanChua()
        {
            return DTCanChua;
        }
        public string GetTenHang()
        {
            return TenHang;
        }
        public int GetGia()
        {
            return Gia;
        }
        public void NhapHang()
        {
            Console.Write("Nhap ma hang: ");
            MaHang = Console.ReadLine();
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap so luong hang: ");
            SLHang += Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia: ");
            Gia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dien tich can chua: ");
            DTCanChua = Convert.ToInt32(Console.ReadLine());
            
            if (GetTenHang() == "cpu" || GetTenHang() == "CPU")
            {
                CPU cpu = new CPU();
                cpu.NhapCPU();    
            }
            if (GetTenHang() == "man hinh" || GetTenHang() == "MAN HINH")
            {
                ManHinh mh = new ManHinh();
                mh.NhapManHinh();
            }
        }
    }
}