 #region Bài Tập 1 
//Bài tập 1: tính số ngày trong tuần và số ngày lẻ
// Input
// Console.WriteLine("Nhập số ngày cần tính : ");
// string soNgay = Console.ReadLine();
// int formatsoNgay = Convert.ToInt32(soNgay);
// // Process
// int Tuan = formatsoNgay / 7 ;
// int Ngay = formatsoNgay % 7 ;
// // Output
// Console.WriteLine($"Kêt quả là {Tuan} tuần và {Ngay} ngày");
#endregion

#region Bài Tập 2
    // // Input 
    // Console.WriteLine("Nhập giá trị đơn hàng :");
    // string donHang = Console.ReadLine();
    // double formatdonHang = Convert.ToDouble(donHang);

    // Console.WriteLine("Nhập phần trăm giảm giá cho đơn hàng: ");
    // string phanTram = Console.ReadLine();
    // double formatphanTram = Convert.ToDouble(phanTram);
    // // Process
    // double tongTien = formatdonHang - (formatdonHang * (formatphanTram/100));
    // // Out put
    // Console.WriteLine($"Tổng giá trị đơn hàng là : {tongTien}");
#endregion

#region Bài Tập 3 
//Bài tập 1: tính số phút
// // Input
// Console.WriteLine("Nhập số phút cần tính : ");
// string soPhut = Console.ReadLine();
// int formatsoPhut = Convert.ToInt32(soPhut);
// // Process
// int Gio = formatsoPhut / 60 ;
// int Phut = formatsoPhut % 60 ;
// // Output
// Console.WriteLine($"Kêt quả là {Gio} giờ và {Phut} phút");
#endregion

#region Bài tập 4 
// Input 
    // Console.WriteLine("Nhập số tiền gốc :");
    // string Price = Console.ReadLine();
    // double formatPrice = Convert.ToDouble(Price);

    // Console.WriteLine("Nhập phần trăm giảm thuế VAT: ");
    // string VAT = Console.ReadLine();
    // double formatVAT = Convert.ToDouble(VAT);
    // // Process
    // double tongTien = formatPrice + (formatPrice * (formatVAT/100));
    // // Out put
    // Console.WriteLine($"Tổng giá trị đơn hàng là : {tongTien}");
#endregion

#region Bài tập 5
    // Input Nhập tiền và tỷ giá chuyển đổi
    Console.WriteLine("Nhập số tiền USD cần chuyển đổi là : ");
    string USD = Console.ReadLine();
    double formatUSD = Convert.ToDouble(USD);

    Console.WriteLine("Nhập tỷ giá chuyển đổi USD qua VNĐ là: ");
    string tyGia = Console.ReadLine();
    double formattyGia = Convert.ToDouble(tyGia);

    // Process
    double KQ = formatUSD * formattyGia;
    // OutPut
    Console.WriteLine($" Số tiền {formatUSD} USD = {KQ} VNĐ");
#endregion