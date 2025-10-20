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

namespace HUCE_DALTUD_LOPNV90_2025_0218867.Pages
{
    /// <summary>
    /// Interaction logic for pageTietDien.xaml
    /// </summary>
    public partial class pageTietDien : Window
    {
        public pageTietDien()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            // Code xử lý khi click button
            MessageBox.Show("Đã nhấn nút Lưu");
        }
    }
}
