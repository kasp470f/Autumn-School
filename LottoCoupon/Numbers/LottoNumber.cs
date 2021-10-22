using LottoClassLibrary.Numbers.Abstract;

namespace LottoClassLibrary.Numbers
{
    public class LottoNumber : Number
    {
        public LottoNumber()
        {
            No = rnd.Next(1, 37);
        }
    }
}
