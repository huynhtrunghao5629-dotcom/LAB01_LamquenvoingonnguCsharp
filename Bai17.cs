using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH01
{
    public class Bai17
    {
        private int[,] a; // Khai báo mảng 2 chiều
        private int dong, cot; // Biến lưu số lượng dòng và cột

        public void sinhMangngaunhien()
        {
            // Nhập kích thước cho mảng 2 chiều
            Console.Write("Nhap so dong: ");
            dong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            cot = int.Parse(Console.ReadLine());

            // Cấp phát bộ nhớ cho mảng với số dòng, cột vừa nhập
            a = new int[dong, cot];
            // Khởi tạo đối tượng Random để sinh số ngẫu nhiên
            Random r = new Random();

            // Sử dụng 2 vòng lặp for lồng nhau để duyệt qua từng ô trong mảng
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    // Gán giá trị ngẫu nhiên từ 10 đến 99 (số có 2 chữ số) cho ô hiện tại
                    a[i, j] = r.Next(10, 100);
                }
            }
        }

        public void inMang()
        {
            Console.WriteLine("Mang hien tai: ");
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    // In giá trị ra màn hình, dùng \t (tab) để các cột cách đều nhau nhìn cho giống ma trận
                    Console.Write(a[i, j] + "\t");
                }
                // Xuống dòng sau khi in xong một dòng (hết vòng lặp cột)
                Console.WriteLine();
            }
        }

        // Dùng từ khóa out để hàm có thể trả về đồng thời 2 mảng (mảng chẵn và mảng lẻ)
        public void traVechanle(out ArrayList mangChan, out ArrayList mangLe)
        {
            // Bắt buộc phải khởi tạo đối tượng (new) cho biến out trước khi thao tác
            mangChan = new ArrayList();
            mangLe = new ArrayList();

            // Duyệt lại toàn bộ mảng 2 chiều
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    // Nếu phần tử chia hết cho 2 thì thêm vào mảng chẵn
                    if (a[i, j] % 2 == 0)
                    {
                        mangChan.Add(a[i, j]);
                    }
                    else // Ngược lại thì thêm vào mảng lẻ
                    {
                        mangLe.Add(a[i, j]);
                    }
                }
            }
        }
    }
}