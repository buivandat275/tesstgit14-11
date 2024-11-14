using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDichHH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Interface trong C#");
            Console.WriteLine("Vi du minh hoa interface");
            Console.WriteLine("--------------------------");

            GiaoDichHangHoa t1 = new GiaoDichHangHoa("001",
           "8/10/2012",200);
            GiaoDichHangHoa t2 = new GiaoDichHangHoa("002",
           "9/10/2012", 400)
                ;
            t1.hienThiThongTinGiaoDich();
            t2.hienThiThongTinGiaoDich();
            Console.WriteLine("So lg gd1 {0}, gd2 {1}", t1.laySoLuong(),t2.laySoLuong());
            Console.ReadKey();
        }
    }
}
