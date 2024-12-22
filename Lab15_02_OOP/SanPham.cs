public abstract class SanPham
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double GiaGoc { get; set; }

    public SanPham(string ma, string ten, double gia)
    {
        MaSanPham = ma;
        TenSanPham = ten;
        GiaGoc = gia;
    }

    public abstract double TinhGiaBan();

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Mã: {MaSanPham} | Tên: {TenSanPham} | Giá gốc: {GiaGoc:C}");
    }
}
public class DienTu : SanPham
{
    private const double Thue = 0.1;
    public DienTu(string ma, string ten, double gia) : base(ma, ten, gia) { }
    public override double TinhGiaBan() => GiaGoc * (1 + Thue);
    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán: {TinhGiaBan():C} (Bao gồm thuế 10%)");
    }
}

public class ThoiTrang : SanPham
{
    private const double GiamGia = 0.2;
    public ThoiTrang(string ma, string ten, double gia) : base(ma, ten, gia) { }
    public override double TinhGiaBan() => GiaGoc * (1 - GiamGia);
    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán: {TinhGiaBan():C} (Giảm giá 20%)");
    }
}

public class ThucPham : SanPham
{
    private const double PhiVanChuyen = 5000;
    public ThucPham(string ma, string ten, double gia) : base(ma, ten, gia) { }
    public override double TinhGiaBan() => GiaGoc + PhiVanChuyen;
    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giá bán: {TinhGiaBan():C} (Phí vận chuyển 5000)");
    }
}
