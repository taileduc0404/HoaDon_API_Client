using HoaDon_API_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HoaDon_API_Client.UI
{
    /// <summary>
    /// Interaction logic for HoaDonWindows.xaml
    /// </summary>
    public partial class HoaDonWindows : Window
    {
        public HoaDonWindows()
        {
            InitializeComponent();
        }

        private void show()
        {
            List<HoaDonDto> hoaDons = XuLyHoaDon.GetDSHoaDon();
            if (hoaDons is null)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            else
            {
                dgHoadon.ItemsSource = hoaDons;
            }
        }
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
            show();
        }
    }
}
