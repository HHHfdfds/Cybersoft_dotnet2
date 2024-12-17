using System;  

internal class Program  
{  
    private static void Main(string[] args)  
    {  
        GiaoDichManager giaoDichManager = new GiaoDichManager();
        int luaChon;  
        do  
        {  
            Console.WriteLine("----- Chương Trình Thanh Toán -------");  
            Console.WriteLine("1. Thanh toán bằng tiền mặt");  
            Console.WriteLine("2. Thanh toán bằng thẻ");  
            Console.WriteLine("3. Thanh toán trực tuyến");  
            Console.WriteLine("4. Xem lịch sử giao dịch");  
            Console.WriteLine("5. Thoát");  
            Console.Write("Nhập lựa chọn của bạn: ");  

            luaChon = int.Parse(Console.ReadLine() ?? "0");  
            IThanhToan thanhToan = null;  

            switch (luaChon)  
            {  
                case 1:  
                    thanhToan = new ThanhToanTienMat();  
                    break;  
                case 2:  
                    thanhToan = new ThanhToanBangThe();  
                    break;  
                case 3:  
                    thanhToan = new ThanhToanOnline();  
                    break;  
                case 4:  
                    giaoDichManager.XemLichSuGiaoDich();  
                    continue;  
                case 5:  
                    Console.WriteLine("Thoát");  
                    return;  
                default:  
                    Console.WriteLine("Lựa chọn không hợp lệ!");  
                    continue;  
            }  
            Console.Write("Nhập số tiền muốn thanh toán: ");
            double soTien = Convert.ToDouble(Console.ReadLine());
            thanhToan.ThanhToan(soTien);
            giaoDichManager.LuuLichGiaoDich(soTien, thanhToan.GetType().Name);

        } while (true);  
    }  
}