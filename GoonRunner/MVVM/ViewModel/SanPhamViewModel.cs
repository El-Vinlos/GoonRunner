using GoonRunner.MVVM.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace GoonRunner.MVVM.ViewModel
{
    public class SanPhamViewModel : BaseViewModel
    {
        private ObservableCollection<SANPHAM> _sanphamlist;
        public ObservableCollection<SANPHAM> SanPhamList { get { return _sanphamlist; } set { _sanphamlist = value; OnPropertyChanged(); } }
        public ICommand RefreshCommand { get; set; }
        public SanPhamViewModel()
        {
            LoadSanPhamList();
            RefreshCommand = new RelayCommand<Button>((p) => true, (p) => { LoadSanPhamList(); });
        }
        private void LoadSanPhamList()
        {
            SanPhamList = new ObservableCollection<SANPHAM>();
            var DanhSachSanPham = DataProvider.Ins.goonRunnerDB.SANPHAMs;
            int i = 1;
            foreach (var item in DanhSachSanPham)
            {
                SANPHAM sanpham = new SANPHAM();
                sanpham.MaSP = DataProvider.Ins.goonRunnerDB.SANPHAMs.Where((n) => n.MaSP == i).Select(n => n.MaSP).FirstOrDefault();
                sanpham.TenSP = DataProvider.Ins.goonRunnerDB.SANPHAMs.Where(n => n.MaSP == i).Select(n => n.TenSP).FirstOrDefault();
                sanpham.LoaiSP = DataProvider.Ins.goonRunnerDB.SANPHAMs.Where(n => n.MaSP == i).Select(n => n.LoaiSP).FirstOrDefault();
                sanpham.ThoiGianBH = DataProvider.Ins.goonRunnerDB.SANPHAMs.Where((n) => n.MaSP == i).Select(n => n.ThoiGianBH).FirstOrDefault();
                sanpham.GiaSP = DataProvider.Ins.goonRunnerDB.SANPHAMs.Where((n) => n.MaSP == i).Select(n => n.GiaSP).FirstOrDefault();
                sanpham.NhaSX = DataProvider.Ins.goonRunnerDB.SANPHAMs.Where((n) => n.MaSP == i).Select(n => n.NhaSX).FirstOrDefault();
                sanpham.CoKhuyenMai = DataProvider.Ins.goonRunnerDB.SANPHAMs.Where((n) => n.MaSP == i).Select(n => n.CoKhuyenMai).FirstOrDefault();
                SanPhamList.Add(sanpham);
                i++;
            }
        }
    }
}
