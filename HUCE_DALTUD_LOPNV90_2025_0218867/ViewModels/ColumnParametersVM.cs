using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HUCE_DALTUD_LOPNV90_2025_0218867.ViewModels
{
    public class ColumnParametersVM
    {
        public ICommand cmNhapEtab { get; set; }
        public ICommand cmLuuCot { get; set; }

        public ColumnParametersVM()
        {
            //cmNhapEtab = new RelayCommand<pageColumnParameters>((parameter) => true, (parameter) => LayThongTinTuEtab(parameter));
            //cmLuuCot = new RelayCommand<pageColumnParameters>((parameter) => true, (parameter) => LuuCot(parameter));
        }
    }
}
