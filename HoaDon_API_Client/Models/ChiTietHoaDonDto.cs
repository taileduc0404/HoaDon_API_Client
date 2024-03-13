
namespace HoaDon_API_Client.Models
{
	public class ChiTietHoaDonDto
	{
		public string? Sohd { get; set; }
		public string? Mahang { get; set; }
		public double? Dongia { get; set; }
		public int? Soluong { get; set; }
		public virtual HangHoa? Hanghoa { get; set; }
    }
}
