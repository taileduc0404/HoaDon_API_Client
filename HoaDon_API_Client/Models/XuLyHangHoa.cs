
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows;

namespace HoaDon_API_Client.Models
{
    public class XuLyHangHoa
    {
        public static List<HangHoa> GetHangHoaList()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = @"https://localhost:44300/api/HangHoa/GetAll";
                var connect = client.GetAsync(url);
                connect.Wait();
                if (connect.Result.IsSuccessStatusCode == false)
                {
                    return null!;
                }
                else
                {
                    var res = connect.Result.Content.ReadFromJsonAsync<List<HangHoa>>();
                    res.Wait();
                    return res.Result!;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw new Exception(e.Message);
            }
        }
		public static bool ThemHangHoa(HangHoa hangHoa)
		{
			try
			{
				HttpClient client = new HttpClient();
				string url = @"https://localhost:44300/api/HangHoa/Create";
                var connect = client.PostAsJsonAsync<HangHoa>(url, hangHoa);
				connect.Wait();
                return connect.Result.IsSuccessStatusCode;

			}
			catch (Exception)
			{
                return false;
			}
		}
		public static bool XoaHangHoa(string mahang)
		{
			try
			{
				HttpClient client = new HttpClient();
				string url = @"https://localhost:44300/api/HangHoa/Delete?id=" + mahang;
				var connect = client.DeleteAsync(url);
				connect.Wait();
				return connect.Result.IsSuccessStatusCode;

			}
			catch (Exception)
			{
				return false;
			}
		}

		public static bool SuaHangHoa(HangHoa hh)
		{
			try
			{
				HttpClient client = new HttpClient();
				string url = @"https://localhost:44300/api/HangHoa/Update?mahang=" + hh.Mahang;
				
				var connect = client.PutAsJsonAsync<HangHoa>(url,hh);
				connect.Wait();
				return connect.Result.IsSuccessStatusCode;

			}
			catch (Exception)
			{
				return false;
			}
		}


	}
}
