using LottoClassLibrary.Coupons;
using LottoClassLibrary.Coupons.Abstract;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace LottoAppWPF.ViewModel
{
    public class LottoViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<KeyValuePair<string, Coupon>> Coupons { get; set; } = new();

        private KeyValuePair<string, Coupon> currentshowncoupon;
        public KeyValuePair<string, Coupon> CurrentShownCoupon
        {
            get => currentshowncoupon;
            set
            {
                currentshowncoupon = value;
                OnPropertyChanged("CurrentShownCoupon");
            }
        }

        private Coupon temp;
        public void GenerateCoupons(int amount, int rows, string type, bool joker)
        {
            Coupons.Clear();
            for (int i = 0; i < amount; i++)
            {
                if (type == "Lotto") temp = new LottoCoupon(rows);
                if (type == "Viking") temp = new VikingCoupon(rows);
                if (joker) temp.AddJokers();
                Coupons.Add(new KeyValuePair<string, Coupon>($"{temp.GetType().Name}: {Coupons.Count + 1}", temp));
            }

            if (Coupons.Count < 1) return;
            CurrentShownCoupon = Coupons[0];
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
