using DuAnOne.BUS.Interface;
using DuAnOne.BUS.ViewModel.TaiKhoans;

namespace DuAnOne.PL
{
    public partial class TabForm : Form
    {
        List<TaiKhoanVM> taiKhoans;
        ITaiKhoanService _taiKhoanService;
        string _ma;
        public TabForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
