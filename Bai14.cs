using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai14
    {
        public string HoTen { get; set; }
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public void Nhap()
        {
            
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap muc luong co ban : ");
            MucLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            // Công thức tính lương thực nhận
            return MucLuong - (SoNgayVang * 100000);
        }

        public void XuatLuong()
        {
            
            Console.WriteLine($"\n- Ho ten: {HoTen}");
            // Sử dụng :N0 để tự động phân cách hàng nghìn 
            Console.WriteLine($"Muc luong goc: {MucLuong:N0} VND");
            Console.WriteLine($"So ngay vang: {SoNgayVang} ngay");
            Console.WriteLine($"Tien bi tru: {SoNgayVang * 100000:N0} VND");
            Console.WriteLine($"Luong thuc nhan: {TinhLuong():N0} VND");
        }
    }
}