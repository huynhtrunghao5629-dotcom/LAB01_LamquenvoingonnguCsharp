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
            // Dùng từ khóa ref để can thiệp và thay đổi trực tiếp giá trị biến truyền vào
            double temp = a;
            a = b;
            b = temp;
        }
    }
}