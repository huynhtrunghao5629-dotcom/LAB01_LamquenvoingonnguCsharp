using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai7
    {
        public bool kiemtrasnt(int n)
        {
            bool laSNT = true;

            if (n < 2)
            {
                laSNT = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        laSNT = false;
                        break;
                    }
                }
            }
            return laSNT;
        }

        public void chayBai7()
        {
            Console.Write("Nhap vao mot so nguyen : ");
            int n = int.Parse(Console.ReadLine());

            bool ketQua = kiemtrasnt(n);
            if (ketQua)
            {
                Console.WriteLine($"So {n} la so nguyen to ");
            }
            else
            {
                Console.WriteLine($"So {n} khong phai la so nguyen to ");
            }
        }
    }
}