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
    /// Interaction logic for pageTinhToan.xaml
    /// </summary>
    public partial class pageTinhToan : Window
    {
        public pageTinhToan()
        {
            InitializeComponent();
        }
        private void sl(object sender, SelectionChangedEventArgs e)
        {
            // TODO: Viết logic khi ComboBox thay đổi
            // Ví dụ:
            ComboBox cb = sender as ComboBox;
            if (cb != null)
            {
                MessageBox.Show("Bạn chọn: " + cb.SelectedItem);
            }
        }
    }
}
