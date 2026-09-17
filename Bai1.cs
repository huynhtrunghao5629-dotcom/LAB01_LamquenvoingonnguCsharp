using System;

namespace THUCHANH01
{
    public class Bai1
    {
        public void chayBai1()
        {
            // In ra màn hình dòng chữ yêu cầu nhập họ tên
            Console.Write("Nhap ho ten cua ban  : ");
            // Đọc dữ liệu người dùng nhập từ bàn phím và lưu vào biến hoten
            string hoten = Console.ReadLine();
            // In ra kết quả kèm theo tên vừa nhập bằng phép cộng chuỗi
            Console.WriteLine("Ho ten la : " + hoten);
        }
    }
}
