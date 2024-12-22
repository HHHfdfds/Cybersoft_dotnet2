public class SanPhamManager
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();
    public void ThemSanPham()
    {
        Console.WriteLine("\nChọn loại sản phẩm: [1] Điện Tử, [2] Thời Trang, [3] Thực Phẩm");
        string loai = Console.ReadLine();

        Console.Write("Nhập mã sản phẩm: ");
        string ma = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập giá gốc: ");
        double gia = double.Parse(Console.ReadLine());

        switch (loai)
        {
            case "1": danhSachSanPham.Add(new DienTu(ma, ten, gia)); break;
            case "2": danhSachSanPham.Add(new ThoiTrang(ma, ten, gia)); break;
            case "3": danhSachSanPham.Add(new ThucPham(ma, ten, gia)); break;
            default: Console.WriteLine("Loại không hợp lệ!"); break;
        }
    }

    public void HienThiDanhSach()
    {
        if (danhSachSanPham.Count == 0)
        {
            Console.WriteLine("Danh sách rỗng");
            return;
        }
        Console.WriteLine("\n=== Danh sách sản phẩm ===");
        danhSachSanPham.ForEach(sp =>
        {
            sp.HienThiThongTin();
            Console.WriteLine("-------------------------");
        });
    }

    public void TinhTongDoanhThu()
    {
        double tongDoanhThu = 0;
        danhSachSanPham.ForEach(sp => tongDoanhThu += sp.TinhGiaBan());
        Console.WriteLine($"\nTổng doanh thu dự kiến: {tongDoanhThu:C}");
    }

    public void XoaSanPham()
    {
        Console.Write("\nNhập mã sản phẩm cần xóa: ");
        string maXoa = Console.ReadLine();

        var spXoa = danhSachSanPham.Find(sp => sp.MaSanPham == maXoa);
        if (spXoa != null)
        {
            danhSachSanPham.Remove(spXoa);
            Console.WriteLine("Đã xóa sản phẩm thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm!");
        }
    }
}
