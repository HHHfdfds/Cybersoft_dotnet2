public class GiaoDich  
{  
    public double SoTien { get; set; }  
    public string PhuongThuc { get; set; }  
    public DateTime ThoiGian { get; set; }  

    public GiaoDich(double soTien, string phuongThuc)  
    {  
        SoTien = soTien;  
        PhuongThuc = phuongThuc;  
        ThoiGian = DateTime.Now;  
    }  
}  