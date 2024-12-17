// Thanh toán cod
public class ThanhToanTienMat : IThanhToan
{
    public void ThanhToan(double soTien)
    {
        if (soTien <= 0)
        {
            Console.WriteLine("Thanh toán thất bại: Số tiền phải lớn hơn 0. Vui lòng nhập lại.");
            return;
        }
        Console.WriteLine($"Đã thanh toán {soTien} VNĐ bằng tiền mặt. Không cần xác nhận thêm.");
    }
}