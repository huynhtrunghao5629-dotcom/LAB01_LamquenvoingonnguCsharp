using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai15
    {
        private int[] a; // Khai báo mảng số nguyên
        private int n;   // Biến lưu số lượng phần tử

        public void NhapMang()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n]; // Cấp phát bộ nhớ cho mảng với kích thước n

            // Duyệt vòng lặp để nhập từng phần tử
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void InMang()
        {
            Console.Write("Mang hien tai: ");
            // Duyệt mảng và in từng phần tử nằm ngang
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public void TimMinMax()
        {
            // Giả sử phần tử đầu tiên đang là lớn nhất và nhỏ nhất
            int max = a[0];
            int min = a[0];
            // Duyệt từ phần tử thứ 2 trở đi để so sánh
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max) max = a[i]; // Cập nhật max nếu tìm thấy số lớn hơn
                if (a[i] < min) min = a[i]; // Cập nhật min nếu tìm thấy số nhỏ hơn
            }
            Console.WriteLine($"Gia tri nho nhat trong mang: {min}");
            Console.WriteLine($"Gia tri lon nhat trong mang: {max}");
        }

        public ArrayList TraVeMangSNT()
        {
            // Khởi tạo một mảng động ArrayList để lưu các số nguyên tố tìm được
            ArrayList DSSNT = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                int so = a[i];
                bool laSNT = true; // Đánh dấu ban đầu mặc định là số nguyên tố
                if (so < 2)
                {
                    laSNT = false; // Số nhỏ hơn 2 chắc chắn không phải SNT
                }
                else
                {
                    // Thuật toán kiểm tra số nguyên tố
                    for (int j = 2; j <= Math.Sqrt(so); j++)
                    {
                        if (so % j == 0)
                        {
                            laSNT = false; // Nếu chia hết thì đổi 
                            break; // Bổ sung break để dừng vòng lặp sớm cho tối ưu
                        }
                    }

                    if (laSNT == true)
                    {
                        DSSNT.Add(so);
                    }
                }
            }
            return DSSNT; // Trả về danh sách SNT
        }


        public void chayBai15()
        {
        
            NhapMang();
            InMang();
            TimMinMax();

            ArrayList DSSNT = TraVeMangSNT();
            Console.Write("Cac so nguyen to trong mang la: ");

            if (DSSNT.Count == 0)
            {
                Console.Write("Khong co so nguyen to nao.");
            }
            else
            {
                foreach (int so in DSSNT)
                {
                    Console.Write(so + " ");
                }
            }
            Console.WriteLine();
        }
    }
}