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
    }
}