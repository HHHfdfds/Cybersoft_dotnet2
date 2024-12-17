public class ThanhToanBangThe : IThanhToan
{
    public void ThanhToan(double soTien)
    {
        if (soTien <= 0)
        {
            Console.WriteLine("Thanh toán thất bại: Số tiền phải lớn hơn 0. Vui lòng nhập lại.");
            return;
        }

        bool pincheck = false;
        do
        {
            Console.Write("Vui lòng nhập mã PIN: ");
            string pin = Console.ReadLine();
            if (pin == "9999")
            {
                pincheck = true;
                Console.WriteLine($"Đã thanh toán {soTien} VNĐ bằng thẻ. Mã PIN hợp lệ.");
            }
            else
            {
                Console.WriteLine("Mã PIN không hợp lệ. Vui lòng thử lại.");
            }
        }
        while (!pincheck);
    }
}