public class HocSinh
{
    public string? MaHocSinh { get; set; }
    public string? TenHocSinh { get; set; }
    public double DiemToan { get; set; }
    public double DiemVan { get; set; }
    public double DiemAnh { get; set; }
    
    public double TinhDiemTrungBinh()
    {
        return (DiemToan + DiemVan + DiemAnh) / 3;
    }

    public string XepLoai()
    {
        double dtb = TinhDiemTrungBinh();
        if(dtb < 5) 
        {
            return "Yếu";
        }
        else if(dtb <= 6.5) 
        {
            return "Trung bình";
        }
        else if(dtb < 8) 
        {
            return "Khá";
        }
        else return "Giỏi";
    }
}