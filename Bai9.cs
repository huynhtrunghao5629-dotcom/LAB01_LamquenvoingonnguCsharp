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
            // Dùng từ khóa out để có thể trả về nhiều kết quả qua tham số
            min = Math.Min(a, Math.Min(b, c));
            max = Math.Max(a, Math.Max(b, c));
        }
    }
}