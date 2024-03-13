using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;

namespace HoaDon_API_Client.Models
{
	class XuLyHoaDon
	{
		public static List<HoaDonDto> GetDSHoaDon()
		{
			try
			{
				HttpClient client = new HttpClient();
				string url = @"https://localhost:44300/api/HoaDon/GetAll";
				var connect = client.GetAsync(url);
				connect.Wait();
				if (connect.Result.IsSuccessStatusCode is false)
				{
					return null!;
				}
				var res = connect.Result.Content.ReadFromJsonAsync<List<HoaDonDto>>();
				res.Wait();
				return res.Result!;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
