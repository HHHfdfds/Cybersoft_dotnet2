using System;

class Program
{
    static void Main(string[] args)
    {
        SanPhamManager quanLy = new SanPhamManager();
        bool check = true;

        while (check)
        {
            Console.WriteLine("\n=== QUẢN LÝ SẢN PHẨM ===");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu dự kiến");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            switch (Console.ReadLine())
            {
                case "1": 
                    quanLy.ThemSanPham(); 
                    break;
                case "2": 
                    quanLy.HienThiDanhSach(); 
                    break;
                case "3": 
                    quanLy.TinhTongDoanhThu(); 
                    break;
                case "4": 
                    quanLy.XoaSanPham(); 
                    break;
                case "5":
                    Console.WriteLine("Kết thúc chương trình.");
                    check = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
