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
        string TenHang;
        public string status = "Trong";
        public List<HangHoa> Hang = new List<HangHoa>();
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
        public string GetTenHang()
        {
            return TenHang;
        }
        public int GetSLHang()
        {
            return SLHang;
        }
        public void SetSLHang(int sl)
        {
            SLHang = sl;
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
            Console.Write("Ten khu: " + TenKV);
            Console.Write(" , So luong hang: " + SLHang);
            Console.Write(" , Dien tich con: " + DTich);
            Console.Write(" , Status: " + status + "\n");
        }
        public void NhapHang()
        {
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            if (TenHang == "cpu" || TenHang == "CPU")
            {
                CPU cpu = new CPU();
                cpu.NhapCPU();
                Hang.Add(cpu);
                SLHang += cpu.GetSL();
            }
            if (TenHang == "man hinh" || TenHang == "MAN HINH")
            {
                ManHinh mh = new ManHinh();
                mh.NhapManHinh();
                Hang.Add(mh);
                SLHang += mh.GetSL();
            }
            if(TenHang=="ban phim" || TenHang=="BAN PHIM")
            {
                BanPhim bp = new BanPhim();
                bp.NhapBanPhim();
                Hang.Add(bp);
                SLHang += bp.GetSL();
            }
        }
    }
}