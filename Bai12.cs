using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai12
    {
        public void xuLyChuoi(string s)
        {
            // In ra chuỗi viết thường và viết hoa
            Console.WriteLine($"Chuoi chu thuong : {s.ToLower()}");
            Console.WriteLine($"Chuoi chu hoa : {s.ToUpper()}");

            // Cắt chuỗi dựa trên khoảng trắng, tab, và xuống dòng; tự động xóa các phần tử rỗng
            string[] cacTu = s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // Độ dài của mảng sau khi cắt là số từ trong chuỗi
            Console.WriteLine($"So tu trong chuoi : {cacTu.Length}");
        }
    }
}