
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


    }
}
