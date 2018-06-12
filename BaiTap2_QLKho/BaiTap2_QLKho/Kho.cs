using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class Kho
    {
        public string TenKho;
        public float CDai, CRong;
        public int SLKhu;

        public List<KhuVuc> kv = new List<KhuVuc>();
        public List<PhieuXuat> Phieu = new List<PhieuXuat>();
        public float GetDT()
        {
            return CDai * CRong;
        }
        public int GetSLKhu()
        {
            return SLKhu;
        }
        public string GetTenKho()
        {
            return TenKho;
        }
        public float DienTich()
        {
            return CDai * CRong;
        }
        public void ThemKho()
        {
            Console.Write("Nhap ten kho: ");
            this.TenKho = Console.ReadLine();
            Console.Write("Nhap chieu dai: ");
            this.CDai = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            this.CRong = float.Parse(Console.ReadLine());
            Console.Write("Nhap so luong khu vuc: ");
            this.SLKhu = Convert.ToInt32(Console.ReadLine());
            
        }
        public void Xem()
        {
            for (int j = 0; j < kv.Count; j++)
                if (kv[j].KTKVTrong() == false)
                {
                    Console.Write("Ten kho " + TenKho);
                    Console.Write(" , Chieu dai " + CDai);
                    Console.Write(" , Chieu rong " + CRong);
                    Console.Write(" , So luong khu vuc " + SLKhu+"  ");
                    kv[j].HienThiKhu();
                }
                else Console.WriteLine("Khu vuc " + kv[j].TenKV + " trong");
        }
        public void GetList()
        {
            for (int j = 0; j < kv.Count; j++)
                if (kv[j].KTKVTrong() == false)
                {
                    Console.WriteLine("Ten kho " + TenKho);
                    Console.WriteLine("Chieu dai " + CDai);
                    Console.WriteLine("Chieu rong " + CRong);
                    Console.WriteLine("So luong khu vuc " + SLKhu+" ");
                    kv[j].HienThiKhu();
                }
        }
    }
}
