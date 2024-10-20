#region Tính chỉ số IBM

        // Console.WriteLine("Hãy nhập chỉ số chiều cao của bạn (m)");
        // string? chieucao = Console.ReadLine();
        // double formatChieuCao = Convert.ToDouble(chieucao);

        // Console.WriteLine("Hãy nhập chỉ số cân nặng của bạn (kg)");
        // string? cannang = Console.ReadLine();
        // double formatCanNang = Convert.ToDouble(cannang);

        // double bmi = 0.0;
        // // process
        // // bmi = (chiều cao) / (cân nặng)^ 2
        // bmi = (formatChieuCao * 100) / (formatCanNang * formatCanNang);
        // Console.WriteLine($"Chỉ số BMI của bạn là : {bmi}");

#endregion
#region ChuviHinhTron
    // Input : Nhập hình tròn
    Console.WriteLine("Hãy Nhập Bán Kính Hình Tròn :");
    string? banKinh = Console.ReadLine();
    double formatBanKinh = Convert.ToDouble(banKinh);
    // Output 
    double ChuviHinhTron = 0.0;
    ChuviHinhTron = (formatBanKinh * 2 * Math.PI);
    double DienTichHinhTron = 0.0;
    DienTichHinhTron = (Math.PI * (formatBanKinh*formatBanKinh));
    Console.WriteLine($"Chu vi hình tròn là : {ChuviHinhTron}");
    Console.WriteLine($"Diện tích hình tròn là : {DienTichHinhTron}");
#endregion