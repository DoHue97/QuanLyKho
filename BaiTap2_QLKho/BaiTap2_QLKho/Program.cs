using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    class Program
    {
        static List<Kho> kho = new List<Kho>();
        static int LC;

        private static void NhapTTKho()
        {
            //Them kho
            int SLKho;
            Console.Write("Nhap so luong kho: ");
            SLKho = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < SLKho; i++)
            {
                Kho k = new Kho();
                k.ThemKho();
                kho.Add(k);
            }
        }
        private static void NhapKhu()
        {
            string TenKho;
            Console.Write("Nhap vao ten kho muon them: ");
            TenKho = Console.ReadLine();
            for (int i = 0; i < kho.Count; i++)
                if (TenKho == kho[i].TenKho)
                    for (int j = 0; j < kho[i].SLKhu; j++)
                    {
                        KhuVuc khu = new KhuVuc();
                        khu.NhapKhu();
                        kho[i].kv.Add(khu);
                        kho[i].kv[j].SetDT(kho[i].GetDT() / kho[i].SLKhu);
                    }
        }
        private static void NhapHang()
        {
            string tenkho, tenkhu;
            int sln;
            Console.WriteLine("Nhap vao ten kho can them mat hang: ");
            tenkho = Console.ReadLine();
            Console.WriteLine("Nhap vao ten khu can them mat hang: ");
            tenkhu = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            sln = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kho[i].kv.Count; j++)
                    if (tenkho == kho[i].TenKho && tenkhu == kho[i].kv[j].TenKV)
                        if (kho[i].kv[j].GetDienTich() >= sln * kho[i].kv[j].DTCanChua)
                        {
                            kho[i].kv[j].NhapHang(tenkho, tenkho, sln);
                            kho[i].kv[j].SetSL(kho[i].kv[j].GetSL() + sln);
                            kho[i].kv[j].SetDT(kho[i].kv[j].GetDienTich() - sln * kho[i].kv[j].GetDTChua());
                        }
                        else Console.WriteLine("Khu vuc khong du chua!");
        }
        private static void XemKho()
        {
            string tenkho;
            Console.Write("Nhap vao kho muon xem: ");
            tenkho = Console.ReadLine();
            for (int i = 0; i < kho.Count; i++)
                if (tenkho == kho[i].TenKho)
                {
                    kho[i].Xem();
                    for (int j = 0; j < kho[i].kv.Count; j++)
                        if (kho[i].kv[j].KTKVTrong() == false)
                            kho[i].kv[j].GetThongTin();
                        else Console.WriteLine("Kho trong");
                }
        }
        private static void GetListKho()
        {
            for (int i = 0; i < kho.Count; i++)
            {
                kho[i].Xem();
                for (int j = 0; j <kho[i].kv.Count; j++)
                    if (kho[i].kv[j].KTKVTrong() == false)
                    {
                        Console.WriteLine("--------------------------------");
                        kho[i].kv[j].GetThongTin();
                    }
            }
        }
        private static void XuatKho()
        {
            string tenkho, tenkhu;
            int slx;
            Console.Write("Nhap ma kho can xuat: ");
            tenkho = Console.ReadLine();
            Console.Write("Nhap ma khu can xuat: ");
            tenkhu = Console.ReadLine();
            Console.Write("Nhap so luong can xuat: ");
            slx = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kho[i].kv.Count; j++)
                    if (tenkho == kho[i].TenKho && tenkhu == kho[i].kv[j].TenKV)
                        if (kho[i].kv[j].GetSL() >= slx)
                        {
                            kho[i].kv[j].NhapHang(tenkho, tenkho, slx);
                            kho[i].kv[j].SetSL(slx);
                            kho[i].kv[j].SetDT(kho[i].kv[j].GetDienTich() + slx * kho[i].kv[j].GetDTChua());
                        }else Console.WriteLine("Kho khong co hang de xuat hoac so hang khong du.");
        }
        private static void XemHang()
        {
            string tenhang;
            Console.Write("Nhap ten hang: ");
            tenhang = Console.ReadLine();
            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kho[i].kv.Count; j++)
                    if (tenhang == kho[i].kv[j].TenHang)
                    {
                        kho[i].Xem();
                        kho[i].kv[j].GetThongTin();
                    }
        }
        private static void Menu()
        {
            do
            {
                Console.WriteLine("---------------Menu------------------");
                Console.WriteLine("Moi ban chon muc:");
                Console.WriteLine("1. Them kho hang ");
                Console.WriteLine("2. Them khu ");
                Console.WriteLine("3. Them hang ");
                Console.WriteLine("4. Xem kho hang");
                Console.WriteLine("5. List kho hang");
                Console.WriteLine("6. Xem mat hang");

                LC = Convert.ToInt16(Console.ReadLine());

                switch (LC)
                {
                    case 1:
                        NhapTTKho();
                        break;
                    case 2:
                        NhapKhu();
                        break;
                    case 3:
                        NhapHang();
                        break;
                    case 4:                        
                        XemKho();
                        break;
                    case 5:
                        GetListKho();
                        break;
                    case 6:
                        XemHang();
                        break;
                }
            } while (LC < 7);
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}