internal class Program
{
    private static void Main(string[] args)
    {
        mapHocSinh map = new mapHocSinh();
        int luaChon;
        do
        {
            Console.WriteLine("----- Danh Sách Học Sinh -------");
            Console.WriteLine("0. Xuất ds học sinh");
            Console.WriteLine("1. Thêm học sinh");
            Console.WriteLine("2. Tìm kiếm học sinh");
            Console.WriteLine("3. Cập nhật điểm học sinh");
            Console.WriteLine("4. Xóa học sinh");
            Console.WriteLine("5. Hiển thị danh sách theo đtb ");
            Console.WriteLine("6. Hiển thị danh sách theo tên");
            Console.WriteLine("7. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            luaChon = int.Parse(Console.ReadLine() ?? "0");
            switch (luaChon)
            {
                case 0:
                    map.XuatDanhSachHocSinh();
                    break;
                case 1:
                    map.ThemHocSinh();
                    break;
                case 2:
                    map.TimKiemHocSinh();
                    break;
                case 3:
                    map.CapNhatDiemHocSinh();
                    break;
                case 4:
                    map.XoaHocSinh();
                    break;
                case 5:
                    map.HienThiTheoDiemTB();
                    break;
                case 6:
                    map.HienThiTheoTen();
                    break;
                case 7:
                    Console.WriteLine("Thoát");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        } while(luaChon != 0);
    }
}