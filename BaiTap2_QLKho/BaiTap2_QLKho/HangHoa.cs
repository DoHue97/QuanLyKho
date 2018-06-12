using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class HangHoa
    {
        string MaHang;
        string TenHang;
        int SLHang;
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
            
            Console.Write("Nhap so luong hang: ");
            SLHang += Convert.ToInt32(Console.ReadLine());            
            Console.Write("Nhap dien tich can chua: ");
            DTCanChua = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia: ");
            Gia = Convert.ToInt32(Console.ReadLine());
        }
        public void XuatTTHang()
        {
            Console.Write("Ma hang: "+ MaHang);
            Console.Write(", Ten hang: " + TenHang);
            Console.Write(" , So luong: " + SLHang);
            Console.Write(" , Dien tich can chua: " + DTCanChua);
            Console.Write(" , Gia: " + Gia+"\n");
        }
    }
}