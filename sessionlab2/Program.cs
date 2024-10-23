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
    // Console.WriteLine("Nhập số tiền USD cần chuyển đổi là : ");
    // string USD = Console.ReadLine();
    // double formatUSD = Convert.ToDouble(USD);

    // Console.WriteLine("Nhập tỷ giá chuyển đổi USD qua VNĐ là: ");
    // string tyGia = Console.ReadLine();
    // double formattyGia = Convert.ToDouble(tyGia);

    // // Process
    // double KQ = formatUSD * formattyGia;
    // // OutPut
    // Console.WriteLine($" Số tiền {formatUSD} USD = {KQ} VNĐ");
#endregion
// Bài tập Extra
#region Bài tập 6 
// Input Nhập tiền và tỷ giá chuyển đổi
    // Console.WriteLine("Nhập số dư tài khoản : ");
    // string soDuTK = Console.ReadLine();
    // double formatsoDuTK = Convert.ToDouble(soDuTK);

    // Console.WriteLine("Nhập số tiền cần rút : ");
    // string rutTien = Console.ReadLine();
    // double formatrutTien = Convert.ToDouble(rutTien);

    // // Process
    // double KQ = formatsoDuTK - formatrutTien;
    // // OutPut
    // Console.Write($" Số tiền còn lại sau khi rút là: {KQ}");
#endregion

#region Bài tập 7
    // Input
    // Console.Write("Nhập quãng đường đã đi (KM):");
    // string quangDuong = Console.ReadLine();
    // double formatquangDuong = Convert.ToDouble(quangDuong);

    // Console.Write("Nhập thời gian dã đi :");
    // string Time = Console.ReadLine();
    // double formatTime = Convert.ToDouble(Time);
    // // Process
    // double tocDoTrungBinh = formatquangDuong / formatTime;
    // // Output
    // Console.Write($"Tốc độ trung bình là : {tocDoTrungBinh} (KM/H)");
#endregion

#region Bài tập 8 
    // Input 
    // Console.Write("Nhập tổng số cần tính:");
    // string tongSo = Console.ReadLine();
    // double formattongSo = Convert.ToDouble(tongSo);

    // Console.Write("Nhập số cần tính % trong tổng số:");
    // string phanTram = Console.ReadLine();
    // double formatphanTram = Convert.ToDouble(phanTram);
    // // Process Tổng số == 100% && 25 == ?? %
    // double KQ = (formatphanTram/formattongSo * 100);
    // Console.Write($"phần trăm của {formatphanTram} trong tổng số {formattongSo} là {KQ}%");
#endregion

#region Bài tập 9 
    // Input
    // Console.Write("Nhập tốc độ (Km/H) là :");
    // string tocDoKm = Console.ReadLine();
    // double formattocDoKm = Convert.ToDouble(tocDoKm);
    // // Process 
    // double formattocDoms = formattocDoKm / 3.6;
    // // Out Put
    // Console.Write($"Kết quả chuyển đổi từ {formattocDoKm} km/h sang m/s là {formattocDoms}");
#endregion

#region Bài tập 10
    // Input giá trị các bài tập ...
    double boi = 25.0;
    double chayBo = 30.0;
    double dapXe = 40.0;
    
    Console.Write("Nhập vào số phút đã tập thể dục:");
    string soPhutTap = Console.ReadLine();
    double formatsoPhutTap = Convert.ToDouble(soPhutTap);

    int formartChon = 0;
    double Calo = 0.0;
    do
    { 
        Console.WriteLine("Chọn loại hình tập thể dục:");
        Console.WriteLine("1.Bơi");
        Console.WriteLine("2.Chạy bộ");
        Console.WriteLine("3.Đạp xe");
        Console.Write("Nhập lựa chọn của bạn tương ứng là: ");
        string Chon = Console.ReadLine();
        formartChon = Convert.ToInt32(Chon);
    } while (formartChon < 1 || formartChon > 3);
    // process & output
    switch(formartChon)
    {
        case 1:
            Calo = formatsoPhutTap * boi;
            Console.Write($"Số calo đã tiêu hao khi bơi trong {formatsoPhutTap} là :{Calo} ");
            break;
        case 2:
            Calo = formatsoPhutTap * chayBo;
            Console.Write($"Số calo đã tiêu hao khi chạy bọ trong {formatsoPhutTap} là :{Calo} ");
            break;
        case 3:
            Calo = formatsoPhutTap * dapXe;
            Console.Write($"Số calo đã tiêu hao khi đạp xe trong {formatsoPhutTap} là :{Calo} ");
            break;
        default:
            Console.Write("Lựa chọn sai");
            break;
    }
#endregion
