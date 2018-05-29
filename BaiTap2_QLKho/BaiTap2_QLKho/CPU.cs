using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_QLKho
{
    public class CPU : HangHoa
    {
        int Ram;
        public int GetRam()
        {
            return Ram;
        }
        public void NhapCPU()
        {
            Console.Write("Nhap ram: ");
            Ram = Convert.ToInt16(Console.ReadLine());
        }
    }
}
