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
	/// Interaction logic for HangHoaWindow.xaml
	/// </summary>
	public partial class HangHoaWindow : Window
	{
		public HangHoaWindow()
		{
			InitializeComponent();
		}

		private void show()
		{
			List<HangHoa> hangHoas = XuLyHangHoa.GetHangHoaList();
			if (hangHoas == null)
			{
				MessageBox.Show("connect error");
			}
			else
			{
				dgHangHoa.ItemsSource = hangHoas;
			}
		}
		private void Window_Load(object sender, RoutedEventArgs e)
		{
			show();
		}

		private void dgHangHoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgHangHoa.SelectedItem is null) return;
			HangHoa hangHoa = dgHangHoa.SelectedItem as HangHoa;
			gridHangHoa.DataContext = new HangHoa
			{
				Mahang = hangHoa!.Mahang,
				Tenhang = hangHoa.Tenhang,
				Dvt = hangHoa.Dvt,
				Dongia = hangHoa.Dongia,
			};
		}

		private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			HangHoa hangHoa = gridHangHoa.DataContext as HangHoa;
			bool ok = XuLyHangHoa.ThemHangHoa(hangHoa!);
			if (ok == false)
			{
				MessageBox.Show("Thêm không thành công", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				show();
				MessageBox.Show("Thêm thành công", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
			}
		}

		private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void lenhXoa_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			HangHoa hangHoa = gridHangHoa.DataContext as HangHoa;
			bool ok = XuLyHangHoa.XoaHangHoa(hangHoa!.Mahang!);
			if (ok == false)
			{
				MessageBox.Show("Xóa không thành công", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				show();
				MessageBox.Show("Xóa thành công", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
			}
		}

		private void lenhXoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void lenhSua_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void lenhSua_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			HangHoa hangHoa = gridHangHoa.DataContext as HangHoa;
			HangHoa hh= new HangHoa();
			bool ok = XuLyHangHoa.SuaHangHoa(hangHoa!);
			if (ok == false)
			{
				MessageBox.Show("Sửa không thành công", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				show();
				MessageBox.Show("Sửa thành công", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
			}
		}
	}
}
