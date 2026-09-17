using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai5
    {
        public void Chaybai5()
        {
            int luachon = 0;
            double x = 0;
            double y = 0;
            // Dùng vòng lặp do-while để đảm bảo menu luôn hiện ra ít nhất 1 lần
            do
            {
                // Hiển thị các lựa chọn của menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Nhap 2 gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang : ");

                // Kiểm tra xem người dùng có nhập đúng định dạng số nguyên không
                if (!int.TryParse(Console.ReadLine(), out luachon))
                {
                    Console.WriteLine("Vui long nhap so nguyen tu 1 den 4.");
                    continue; // Bỏ qua phần dưới, quay lại đầu vòng lặp để bắt nhập lại
                }

                // Xử lý từng chức năng dựa vào lựa chọn
                switch (luachon)
                {
                    case 1:
                        Console.Write("Nhap x: ");
                        double.TryParse(Console.ReadLine(), out x); // Ép kiểu sang số thực
                        Console.Write("Nhap y: ");
                        double.TryParse(Console.ReadLine(), out y);
                        break;
                    case 2:
                        // Sử dụng hàm tính lũy thừa
                        Console.WriteLine($"Ket qua {x}^{y} = {Math.Pow(x, y)}");
                        break;
                    case 3:
                        // Kiểm tra điều kiện số dương trước khi tính căn bậc 2
                        if (x >= 0) Console.WriteLine($"Can bac 2 cua {x} = {Math.Sqrt(x)}");
                        else Console.WriteLine($"Khong the tinh can bac 2 cua {x} vi no la so am.");
                        if (y >= 0) Console.WriteLine($"Can bac 2 cua {y} = {Math.Sqrt(y)}");
                        else Console.WriteLine($"Khong the tinh can bac 2 cua {y} vi no la so am.");
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Chuc nang khong hop le. Vui long chon tu 1 den 4.");
                        break;
                }
            } while (luachon != 4); // Nếu chọn 4 thì thoát vòng lặp và kết thúc
        }
            

    }
    }

