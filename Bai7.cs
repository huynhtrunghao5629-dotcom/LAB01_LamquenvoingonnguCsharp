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

            // Kiểm tra logic số nguyên tố
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

            if (laSNT == true)
            {
                Console.WriteLine("Dung");
            }
            else
            {
                Console.WriteLine("Sai");
            }

            return laSNT;
        }
    }
}