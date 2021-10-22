using LottoClassLibrary.Coupons;
using LottoClassLibrary.Coupons.Abstract;
using System;

namespace LottoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coupon coupon = new LottoCoupon(10);
            //coupon.AddJokers();
            Console.WriteLine(coupon);

            //Coupon coupon2 = new VikingCoupon(10);
            //coupon2.AddJokers();
            //Console.WriteLine(coupon2);
        }
    }
}
