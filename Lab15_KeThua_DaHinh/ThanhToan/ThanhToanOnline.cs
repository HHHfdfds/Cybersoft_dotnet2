public class ThanhToanOnline : IThanhToan
{
    public void ThanhToan(double soTien)
    {
        if (soTien <= 0)
        {
            Console.WriteLine("Thanh toán thất bại: Số tiền phải lớn hơn 0. Vui lòng nhập lại.");
            return;
        }
        bool optcheck = false;
        do
        {
            Console.Write("Vui lòng nhập mã OTP: ");
            string otp = Console.ReadLine();
            if (otp == "1234")
            {
                optcheck = true;
                Console.WriteLine($"Đã thanh toán {soTien} VNĐ online. Mã OTP hợp lệ.");
            }
            else
            {
                Console.WriteLine("Mã OTP không hợp lệ. Vui lòng thử lại.");
            }
        }
        while (!optcheck);
    }
}
