using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using LottoAppWPF.ViewModel;
using LottoClassLibrary.Coupons.Abstract;

namespace LottoAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LottoViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = DataContext as LottoViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CouponsAmount.Text == "" || RowsAmount.Text == "" || TypeCombo.SelectedItem == null) return;
            int amount = int.Parse(CouponsAmount.Text);
            int rows = int.Parse(RowsAmount.Text);
            string type = TypeCombo.Text;
            bool joker = isJoker.IsChecked.Value;
            vm.GenerateCoupons(amount, rows, type, joker);
        }


        private void CouponGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0) return;
            KeyValuePair<string, Coupon> selectedCoupon = (KeyValuePair<string, Coupon>)e.AddedItems[0];
            vm.CurrentShownCoupon = selectedCoupon;
        }
    }
}
