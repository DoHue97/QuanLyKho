using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class ManHinh : HangHoa
    {
        string KichThuoc;
        public string GetKichThuoc()
        {
            return KichThuoc;
        }
        public void NhapManHinh()
        {
            Console.Write("Nhap kich thuoc: ");
            KichThuoc = Console.ReadLine();
        }
    }
}
