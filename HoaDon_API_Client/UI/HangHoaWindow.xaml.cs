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
            gridHangHoa.DataContext = dgHangHoa.SelectedItem;
        }
    }
}
