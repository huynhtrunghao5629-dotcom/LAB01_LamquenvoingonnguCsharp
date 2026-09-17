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
                Console.WriteLine("Day la chuoi doi xung");
            }
            else
            {
                Console.WriteLine("Day khong phai la chuoi doi xung");
            }
            return laDoiXung;
        }

        public void chaybai10()
        {
   
            Console.Write("Nhap vao mot chuoi bat ky: ");
            string s = Console.ReadLine();

            kiemTraDoiXung(s);
        }
    }
}