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
            // Chuyển chuỗi thành mảng các ký tự 
            char[] mangKyTu = s.ToCharArray();
            // Gọi hàm đảo ngược mảng
            Array.Reverse(mangKyTu);
            // Ghép mảng ký tự lại thành chuỗi mới
            return new string(mangKyTu);
        }
    }
}
