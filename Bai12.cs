using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai12
    {
        public void xuLyChuoi(string s)
        {
            Console.WriteLine($"Chuoi chu thuong : {s.ToLower()}");
            Console.WriteLine($"Chuoi chu hoa : {s.ToUpper()}");

            string[] cacTu = s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"So tu trong chuoi : {cacTu.Length}");
        }

        public void chayBai12()
        {
          
            Console.Write("Nhap vao mot doan van hoac cau: ");
            string s = Console.ReadLine();

            xuLyChuoi(s);
        }
    }
}