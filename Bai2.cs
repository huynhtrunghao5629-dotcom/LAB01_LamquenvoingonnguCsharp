using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai2
    {
        public void Chaybai2()
        {
            // Yêu cầu người dùng nhập họ tên
            Console.Write("Nhap ho ten cua ban : ");
            // Lưu dữ liệu nhập vào vào biến hoten
            string hoten = Console.ReadLine();
            // In ra câu chào, dùng $ để đưa trực tiếp biến hoten vào trong ngoặc {}
            Console.WriteLine($"Chao ban {hoten} !");
        }
    }
}
