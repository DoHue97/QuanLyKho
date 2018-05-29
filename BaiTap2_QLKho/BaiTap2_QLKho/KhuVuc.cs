using System;
using System.Collections;
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
        public int SLHang;
        public string status="Trong";

        public HangHoa Hang = new HangHoa();
        public void SetStatus(string stt)
        {
            status = stt;
        }
        public string GetStatus()
        {
            return status;
        }
        public string GetTenKhu()
        {
            return TenKV;
        }
        public int GetSLHang()
        {
            return SLHang;
        }
        public void SetSLHang(int sl)
        {
           SLHang=sl;
        }
        public float GetDTich()
        {
            return DTich;
        }
        public void SetDT(float dientich)
        {
            DTich = dientich;
        }
        public bool KTKVTrong()
        {
            if (GetSLHang() <= 0)
                return true;
            else return false;
        }
        public void NhapKhu()
        {
            Console.Write("Nhap ten khu: ");
            TenKV = Console.ReadLine();
        }
        public void HienThiKhu()
        {
            Console.WriteLine("Ten khu: " + TenKV);
            Console.WriteLine("So luong hang: " + SLHang);
            Console.WriteLine("Dien tich ban dau: " + DTich);
            Console.WriteLine("Status: " + status);            
        }
        public void NhapHang()
        {
            Hang.NhapHang();
        }
          
    }
}