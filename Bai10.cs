using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class bai10
    {
        public bool kiemTraDoiXung(string s)
        {
            char[] mangKyTu = s.ToCharArray();
            Array.Reverse(mangKyTu);
            string chuoiDao = new string(mangKyTu);

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