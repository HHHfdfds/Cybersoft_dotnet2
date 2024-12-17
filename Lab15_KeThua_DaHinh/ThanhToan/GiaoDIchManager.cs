using Newtonsoft.Json;

public class GiaoDichManager  
{  
    private List<GiaoDich> lichSuGiaoDich = new List<GiaoDich>();  
    private const string LichSuFile = "lichSuGiaoDich.json";  

    public void LuuLichGiaoDich(double soTien, string phuongThuc)  
    {  
        GiaoDich giaoDich = new GiaoDich(soTien, phuongThuc);  
        lichSuGiaoDich.Add(giaoDich);  
        File.WriteAllText(LichSuFile, JsonConvert.SerializeObject(lichSuGiaoDich, Formatting.Indented));  
    }  
    public void XemLichSuGiaoDich()  
    {  
        if (File.Exists(LichSuFile))  
        {  
            string json = File.ReadAllText(LichSuFile);  
            var giaoDichs = JsonConvert.DeserializeObject<List<GiaoDich>>(json);  
            Console.WriteLine("Lịch sử giao dịch:");  
            foreach (var gd in giaoDichs)  
            {  
                Console.WriteLine($"Phương thức: {gd.PhuongThuc} - Số tiền: {gd.SoTien} VNĐ - Thời gian: {gd.ThoiGian}");  
            }  
        }  
        else  
        {  
            Console.WriteLine("Chưa có lịch sử giao dịch nào.");  
        }  
    }  
}