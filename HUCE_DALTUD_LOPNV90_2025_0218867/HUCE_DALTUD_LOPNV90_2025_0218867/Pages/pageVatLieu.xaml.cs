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
    /// Interaction logic for pageVatLieu.xaml
    /// </summary>
    public partial class pageVatLieu : Window
    {
        public pageVatLieu()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: viết logic lưu vật liệu
            MessageBox.Show("Đã bấm Lưu vật liệu");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: xóa dữ liệu
            MessageBox.Show("Đã bấm Xóa dữ liệu");
        }
    }
}
