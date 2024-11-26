public class mapHocSinh{
    private List<HocSinh> lstHS;
    public mapHocSinh()
    {
        lstHS = new List<HocSinh>();
        lstHS.Add(new HocSinh
        {
            MaHocSinh = "001",
            TenHocSinh = "Nguyen Hoàng",
            DiemToan = 8.0,
            DiemVan = 7.5,
            DiemAnh = 8.5
        });

        lstHS.Add(new HocSinh
        {
            MaHocSinh = "002",
            TenHocSinh = "Lý Liên Kiệt",
            DiemToan = 6.5,
            DiemVan = 7.0,
            DiemAnh = 7.5
        });

        lstHS.Add(new HocSinh
        {
            MaHocSinh = "003",
            TenHocSinh = "Hoàng Phi Hồng",
            DiemToan = 9.0,
            DiemVan = 8.5,
            DiemAnh = 9.0
        });

        lstHS.Add(new HocSinh
        {
            MaHocSinh = "004",
            TenHocSinh = "Lý Tiểu Long",
            DiemToan = 5.0,
            DiemVan = 6.0,
            DiemAnh = 5.5
        });
    }
    public void ThemHocSinh()
    {
        string maHS;
        bool checkmaHS = false;
        do
        {
            Console.Write("Nhập mã học sinh: ");
            maHS = Console.ReadLine();
            if (lstHS.Any(hs => hs.MaHocSinh == maHS))
            {
                Console.WriteLine("Mã học sinh đã có ròi, vui lòng nhập lại !!!");
            }
            else
            {
                checkmaHS = true;
            }
        } while (!checkmaHS);
        Console.Write("Nhập tên học sinh: ");
        string tenHS = Console.ReadLine();
        Console.Write("Nhập điểm Toán: ");
        double diemToan = Convert.ToDouble(Console.ReadLine() ?? "0");
        Console.Write("Nhập điểm Văn: ");
        double diemVan = Convert.ToDouble(Console.ReadLine() ?? "0");
        Console.Write("Nhập điểm Anh: ");
        double diemAnh = Convert.ToDouble(Console.ReadLine() ?? "0");
        lstHS.Add(new HocSinh
        {
            MaHocSinh = maHS,
            TenHocSinh = tenHS,
            DiemToan = diemToan,
            DiemVan = diemVan,
            DiemAnh = diemAnh
        });
        Console.WriteLine("Thêm hsinh thành công !!!");
    }
    public void XuatDanhSachHocSinh()
    {
        Console.WriteLine("---------------Danh sách học sinh:-----------------");
        foreach (var hs in lstHS)
        {
            Console.WriteLine($"Mã: {hs.MaHocSinh}, Tên: {hs.TenHocSinh}, Điểm TB: {hs.TinhDiemTrungBinh():0.0}, Xếp loại: {hs.XepLoai()}");
        }
    }

    public void TimKiemHocSinh()
    {
        Console.Write("Nhập tên hsinh cần tìm: ");
        string tenHS = Console.ReadLine();
        var ketQua = lstHS.Where(hs => hs.TenHocSinh.Contains(tenHS, StringComparison.OrdinalIgnoreCase)).ToList();

        if (ketQua.Any())
        {
            foreach (var hs in ketQua)
            {
                Console.WriteLine($"Mã: {hs.MaHocSinh}, Tên: {hs.TenHocSinh}, Điểm TB: {hs.TinhDiemTrungBinh():0.0}, Xếp loại: {hs.XepLoai()}");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy học sinh nào");
        }
    }
    public void CapNhatDiemHocSinh()
    {
        Console.Write("Nhập mã học sinh cần cập nhật: ");
        string maHS = Console.ReadLine();
        var hocSinh = lstHS.FirstOrDefault(hs => hs.MaHocSinh == maHS);

        if (hocSinh != null)
        {
            Console.Write("Nhập điểm Toán mới: ");
            hocSinh.DiemToan = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("Nhập điểm Văn mới: ");
            hocSinh.DiemVan = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("Nhập điểm Anh mới: ");
            hocSinh.DiemAnh = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Cập nhật điểm thành công");
        }
        else
        {
            Console.WriteLine("Không tìm thấy học sinh nào.");
        }
    }
    public void XoaHocSinh()
    {
        Console.Write("Nhập mã học sinh cần xóa: ");
        string maHS = Console.ReadLine();
        var hocSinh = lstHS.FirstOrDefault(hs => hs.MaHocSinh == maHS);

        if (hocSinh != null)
        {
            lstHS.Remove(hocSinh);
            Console.WriteLine("Xóa học sinh thành công");
        }
        else
        {
            Console.WriteLine("Không tìm thấy học sinh");
        }
    }
    public void HienThiTheoDiemTB()
    {
        var danhSachSapXep = lstHS.OrderBy(hs => hs.TinhDiemTrungBinh()).ToList();
        foreach (var hs in danhSachSapXep)
        {
            Console.WriteLine($"Mã: {hs.MaHocSinh}, Tên: {hs.TenHocSinh}, Điểm TB: {hs.TinhDiemTrungBinh():0.0}, Xếp loại: {hs.XepLoai()}");
        }
    }
    public void HienThiTheoTen()
    {
        var danhSachSapXep = lstHS.OrderBy(hs => hs.TenHocSinh.Split(' ').Last()).ToList();
        foreach (var hs in danhSachSapXep)
        {
            Console.WriteLine($"Mã: {hs.MaHocSinh}, Tên: {hs.TenHocSinh}, Điểm TB: {hs.TinhDiemTrungBinh():0.0}, Xếp loại: {hs.XepLoai()}");
        }
    }
}
