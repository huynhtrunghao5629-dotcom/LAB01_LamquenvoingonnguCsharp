using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class SinhVien
    {
        // Khai báo các thuộc tính với get; set; để tự động tạo getter/setter
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int NamHoc { get; set; }

        public void Nhap()
        {
            // Nhập và gán dữ liệu cho từng thuộc tính
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi sinh vien: ");
            DiaChi = Console.ReadLine();
            Console.Write("Sinh vien nam: ");
            NamHoc = int.Parse(Console.ReadLine()); // Ép sang kiểu int vì NamHoc là số nguyên
        }

        public void Xuat()
        {
            Console.WriteLine("\nThong tin sinh vien: ");
            // In thông tin sinh viên ra màn hình
            Console.WriteLine("- Ma sinh vien: " + MaSV);
            Console.WriteLine("- Ho ten sinh vien: " + HoTen);
            Console.WriteLine("- Dia chi sinh vien: " + DiaChi);
            Console.WriteLine("- Sinh vien nam: " + NamHoc);
        }
    }
}