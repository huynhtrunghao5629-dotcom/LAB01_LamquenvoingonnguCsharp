using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai8
    {
        public void hoanvi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public void chayBai8()
        {
        
            Console.Write("Nhap so thu nhat : ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai :  ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Truoc khi hoan vi: x = {x}, y = {y}");
            hoanvi(ref x, ref y);
            Console.WriteLine($"Sau khi hoan vi: x = {x}, y = {y}");
        }
    }
}