using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    class BanPhim : HangHoa
    {
        string DacTinh;
        public string GetDacTinh()
        {
            return DacTinh;
        }
        public void NhapBanPhim()
        {
            base.NhapHang();
            Console.Write("Nhap dac tinh: ");
            DacTinh = Console.ReadLine();
        }
        public void GetTTBanPhim()
        {
            base.XuatTTHang();
            Console.Write(" , Dac tinh: " + DacTinh);
        }
    }
}
