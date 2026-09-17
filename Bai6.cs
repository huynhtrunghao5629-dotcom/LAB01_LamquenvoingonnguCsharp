using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai6
    {
        public int max(int a, int b, int c)
        {
            // Lồng 2 hàm Math.Max để tìm số lớn nhất trong 3 số
            return Math.Max(a, Math.Max(b, c));
        }

        public void chayBai6()
        {
           
            Console.Write("Nhap so nguyên thu nhat : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyên thu hai : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyên thu ba : ");
            int c = int.Parse(Console.ReadLine());

            int ketQua = max(a, b, c);
            Console.WriteLine($"So lon nhat trong 3 so {a}, {b}, {c} la: {ketQua}");
        }
    }
}