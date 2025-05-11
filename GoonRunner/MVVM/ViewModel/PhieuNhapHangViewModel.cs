using GoonRunner.MVVM.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GoonRunner.MVVM.ViewModel
{
    public class PhieuNhapHangViewModel : BaseViewModel
    {
        private ObservableCollection<PHIEUNHAPHANG> _phieunhaphanglist;
        public ObservableCollection<PHIEUNHAPHANG> PhieuNhapHangList { get { return _phieunhaphanglist; } set { _phieunhaphanglist = value; OnPropertyChanged(); } }
        public ICommand RefreshCommand { get; set; }
        public PhieuNhapHangViewModel()
        {
            LoadPhieuNhapHangList();
            RefreshCommand = new RelayCommand<Button>((p) => true, (p) => { LoadPhieuNhapHangList(); });
        }
        private void LoadPhieuNhapHangList()
        {
            PhieuNhapHangList = new ObservableCollection<PHIEUNHAPHANG>();
            var DanhSachPhieuNhapHang = DataProvider.Ins.goonRunnerDB.PHIEUNHAPHANGs;
            int i = 1;
            foreach (var item in DanhSachPhieuNhapHang)
            {
                PHIEUNHAPHANG phieunhaphang = new PHIEUNHAPHANG();
                phieunhaphang.MaPNH = DataProvider.Ins.goonRunnerDB.PHIEUNHAPHANGs.Where((n) => n.MaPNH == i).Select(n => n.MaPNH).FirstOrDefault();
                phieunhaphang.MaNCC = DataProvider.Ins.goonRunnerDB.PHIEUNHAPHANGs.Where(n => n.MaPNH == i).Select(n => n.MaNCC).FirstOrDefault();
                phieunhaphang.TenNCC = DataProvider.Ins.goonRunnerDB.PHIEUNHAPHANGs.Where(n => n.MaPNH == i).Select(n => n.TenNCC).FirstOrDefault();
                phieunhaphang.NgayNhap = DataProvider.Ins.goonRunnerDB.PHIEUNHAPHANGs.Where((n) => n.MaPNH == i).Select(n => n.NgayNhap).FirstOrDefault();
                phieunhaphang.MaNV = DataProvider.Ins.goonRunnerDB.PHIEUNHAPHANGs.Where((n) => n.MaPNH == i).Select(n => n.MaNV).FirstOrDefault();
                PhieuNhapHangList.Add(phieunhaphang);
                i++;
            }
        }
    }
}
