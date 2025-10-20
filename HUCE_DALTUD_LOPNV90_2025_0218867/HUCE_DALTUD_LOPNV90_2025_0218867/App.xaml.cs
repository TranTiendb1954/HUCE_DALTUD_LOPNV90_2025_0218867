using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HUCE_DALTUD_LOPNV90_2025_0218867
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Mở cửa sổ đăng nhập trước
            var loginWindow = new View.ViewDangNhap();
            loginWindow.Show();
        }
    }
}
