using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai10
    {
        public bool kiemTraDoiXung(string s)
        {
            // Tự đảo ngược chuỗi ngay trong hàm này
            char[] mangKyTu = s.ToCharArray();
            Array.Reverse(mangKyTu);
            string chuoiDao = new string(mangKyTu);

            // So sánh 2 chuỗi, bỏ qua việc phân biệt chữ hoa hay chữ thường
            bool laDoiXung = s.Equals(chuoiDao, StringComparison.OrdinalIgnoreCase);

            if (laDoiXung == true)
            {
                Console.WriteLine("dung");
            }
            else
            {
                Console.WriteLine("khong");
            }
            return laDoiXung;
        }
    }
}