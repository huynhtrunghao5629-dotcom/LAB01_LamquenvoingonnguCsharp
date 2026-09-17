using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai16
    {
        public void sapXephoten()
        {
            Console.Write("Nhap so luong nguoi: ");
            int n = int.Parse(Console.ReadLine());
            // Khởi tạo mảng chuỗi để lưu tên với độ dài n
            string[] dsTen = new string[n];

            // Vòng lặp lấy dữ liệu họ tên
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten nguoi thu {i + 1}: ");
                dsTen[i] = Console.ReadLine();
            }

            // Sử dụng hàm Sort có sẵn của lớp Array để tự động sắp xếp tên theo bảng chữ cái
            Array.Sort(dsTen);

            Console.WriteLine("Danh sach ho ten sau khi sap xep: ");
            // Duyệt mảng để in ra danh sách đã sắp xếp
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dsTen[i]);
            }
        }
    }
}
