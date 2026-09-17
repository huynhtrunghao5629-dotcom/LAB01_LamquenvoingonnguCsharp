using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai9
    {
        public void timminmax(double a, double b, double c, out double min, out double max)
        {
            min = Math.Min(a, Math.Min(b, c));
            max = Math.Max(a, Math.Max(b, c));
        }

        public void chayBai9()
        {
            Console.Write("Nhap so thuc thu nhat : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc thu hai : ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc thu ba : ");
            double c = double.Parse(Console.ReadLine());

            double min, max;
            timminmax(a, b, c, out min, out max);
            Console.WriteLine($"Gia tri nho nhat la: {min}");
            Console.WriteLine($"Gia tri lon nhat la: {max}");
        }
    }
}