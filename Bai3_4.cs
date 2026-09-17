using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace THUCHANH01
{
    public class Bai3_4
    {
        public void Chaybai3_4()
        {
            // Yêu cầu nhập số x và y dưới dạng chuỗi
            Console.Write("Nhap so nguyen x: ");
            string inputX = Console.ReadLine();
            Console.Write("Nhap so nguyen y: ");
            string inputY = Console.ReadLine();

            // Cố gắng ép kiểu chuỗi sang số nguyên, nếu thành công thì lưu vào x, y và trả về true
            bool isValidX = int.TryParse(inputX, out int x);
            bool isValidY = int.TryParse(inputY, out int y);

            // Kiểm tra xem cả 2 số nhập vào có hợp lệ không
            if (isValidX && isValidY)
            {
                // Dùng hàm Math.Pow có sẵn để tính x mũ y  
                Console.WriteLine($"Ket qua {x} mu {y} la : {Math.Pow(x, y)}");
            }
            else
            {
                // Báo lỗi nếu người dùng nhập sai định dạng 
                Console.WriteLine("Gia tri nhap khong phai so nguyen !");
            }
        }
    }
}
