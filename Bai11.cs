using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai11
    {
        public string traVeChuoiDao(string s)
        {
            char[] mangKyTu = s.ToCharArray();
            Array.Reverse(mangKyTu);
            return new string(mangKyTu);
        }

        public void chayBai11()
        {
     
            Console.Write("Nhap vao mot chuoi can dao nguoc: ");
            string s = Console.ReadLine();

            string chuoiDao = traVeChuoiDao(s);
            Console.WriteLine($"Chuoi sau khi dao nguoc: {chuoiDao}");
        }
    }
}