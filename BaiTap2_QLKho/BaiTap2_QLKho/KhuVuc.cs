using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class KhuVuc : Kho
    {
        public string TenKV;
        public float DTich;
        public string TenHang;
        public int SLHang;
        public float DTCanChua;
       
        public void SetSL(int SLg)
        {
            SLHang = SLg;
        }
        public int GetSL()
        {
            return SLHang;
        }
        public void SetDT(float dientich)
        {
            DTich = dientich;
        }
        public float GetDienTich()
        {
            return DTich;
        }
        public float GetDTChua()
        {
            return DTCanChua;
        }
        public string GetTenHang()
        {
            return TenHang;
        }
        public bool KTKVTrong()
        {
            if (GetSL() <= 0)
                return true;
            else return false;
        } 
        public void GetThongTin()
        {
            Console.WriteLine("Ten khu: " + TenKV);
            Console.WriteLine("Dien tich con: " + GetDienTich());
            Console.WriteLine("Ten mat hang: " + GetTenHang());
            Console.WriteLine("So luong mat hang: " + GetSL());
        }
        public void NhapKhu()
        {
            Console.Write("Nhap ten khu: ");
            TenKV = Console.ReadLine();
        }
        public void NhapHang(string tenkho, string tenkhu,int sln)
        {
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap dien tich can chua: ");
            DTCanChua = float.Parse(Console.ReadLine());
        }
        public void Xuat(string tenkho, string tenkhu, int slx)
        {
            Console.Write("Nhap so luong hang: ");
            SetSL(GetSL()-slx);
        }

    }
}