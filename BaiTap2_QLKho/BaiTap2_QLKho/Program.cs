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

        private static void ThemKho()
        {
            int SLKho;
            Console.Write("Nhap so luong kho: ");
            SLKho = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < SLKho; i++)
            {
                Kho k = new Kho();
                k.ThemKho();
                kho.Add(k);
            }
            NhapKhu();
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
        private static void ThemHang()
        {
            Console.WriteLine("List kho va khu ");
            for (int i = 0; i < kho.Count; i++)
            {
                Console.WriteLine("Ten kho: " + kho[i].TenKho);
                for (int j = 0; j < kho[i].kv.Count; j++)
                    Console.WriteLine("     Khu : " + kho[i].kv[j].TenKV + "       Status : " + kho[i].kv[j].GetStatus());
            }

            Console.WriteLine("----------Them hang--------");
            string tenkho, tenkhu;
            Console.WriteLine("Nhap vao ten kho can them mat hang: ");
            tenkho = Console.ReadLine();
            Console.WriteLine("Nhap vao ten khu can them mat hang: ");
            tenkhu = Console.ReadLine();

            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; j < kho[i].kv.Count; j++)
                    if (tenkho == kho[i].TenKho && tenkhu == kho[i].kv[j].TenKV)
                    {
                        kho[i].kv[j].NhapHang();
                        kho[i].kv[j].SetSLHang(kho[i].kv[j].Hang.GetSL());
                        kho[i].kv[j].SetStatus("Co hang");
                    }
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
                }
        }
        private static void GetListKho()
        {
            for (int i = 0; i < kho.Count; i++)
            {
                kho[i].GetList();
            }
        }
        private static void XuatKho()
        {

            string TenHang, TenKho, TenKhu;
            int slx;
            Console.Write("Nhap vao ten hang: ");
            TenHang = Console.ReadLine();
            //Console.WriteLine("-------------Kho va khu co mat hang muon xuat--------------");

            //for (int i = 0; i < kho.Count; i++)
            //    for (int j = 0; i < kho[i].kv.Count; j++)
            //        if (TenHang == kho[i].kv[i].Hang.GetTenHang())
            //        {
            //            Console.WriteLine("Kho: " + kho[i].GetTenKho());
            //            kho[i].kv[j].HienThiKhu();
            //        }
            Console.Write("Nhap vao ten kho: ");
            TenKho = Console.ReadLine();
            Console.Write("Nhap vao ten khu: ");
            TenKhu = Console.ReadLine();
            Console.Write("Nhap vao so luong xuat: ");
            slx = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < kho.Count; i++)
                for (int j = 0; i < kho[i].kv.Count; j++)
                    if (kho[i].kv[j].GetSLHang() > slx)
                    {
                        kho[i].kv[j].SetDT(kho[i].kv[j].GetDTich() - slx * kho[i].kv[j].Hang.GetDTCanChua());
                        kho[i].kv[j].SetSLHang(kho[i].kv[j].GetSLHang() - slx);
                    }
        }
        private static void Menu()
        {
            do
            {
                Console.WriteLine("---------------Menu------------------");
                Console.WriteLine("Moi ban chon muc:");
                Console.WriteLine("1. Them kho hang ");
                Console.WriteLine("2. Them hang ");
                Console.WriteLine("3. Xem kho hang ");
                Console.WriteLine("4. List kho hang");
                Console.WriteLine("5. Xuat kho");


                LC = Convert.ToInt16(Console.ReadLine());

                switch (LC)
                {
                    case 1:
                        ThemKho();
                        break;
                    case 2:
                        ThemHang();
                        break;
                    case 3:
                        XemKho();
                        break;
                    case 4:
                        GetListKho();
                        break;
                    case 5:
                        XuatKho();
                        break;
                }
            } while (LC < 6);
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}