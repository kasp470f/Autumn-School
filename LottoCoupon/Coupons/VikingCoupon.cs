using LottoClassLibrary.Coupons.Abstract;
using LottoClassLibrary.Rows;
using LottoClassLibrary.Rows.Abstract;
using System.Diagnostics;

namespace LottoClassLibrary.Coupons
{
    public class VikingCoupon : Coupon
    {
        public VikingCoupon(int rowCount)
        {
            rowCount = rowCount > 10 ? 10 : rowCount;
            Rows = new Row[rowCount];
            Row temp;
            for (int i = 0; i < rowCount;)
            {
                temp = new VikingRow();
                if (!RowExists(temp))
                {
                    Rows[i] = temp;
                    i++;
                }
                else
                {
                    Debug.WriteLine($"{temp} already exists");
                }
            }
        }
    }
}
