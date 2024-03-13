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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HoaDon_API_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void hanghoa_Click(object sender, RoutedEventArgs e)
        {
            UI.HangHoaWindow hanghoa=new UI.HangHoaWindow();
            hanghoa.Show();
        }

        private void hoadon_Click(object sender, RoutedEventArgs e)
        {
            UI.HoaDonWindows hoadon = new UI.HoaDonWindows();
            hoadon.Show();
        }
    }
}
