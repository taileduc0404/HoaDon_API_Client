
using System;
using System.Collections.Generic;

namespace HoaDon_API_Client.Models
{
	public class HoaDonDto
	{
		public HoaDonDto()
		{
			Chitiethoadons = new List<ChiTietHoaDonDto>();
		}
		public string? Sohd { get; set; }
		public DateTime? Ngaylaphd { get; set; }
		public string? Tenkh { get; set; }

		public virtual IEnumerable<ChiTietHoaDonDto>? Chitiethoadons { get; set; }
	}
}
