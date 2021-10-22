using LottoClassLibrary.Numbers.Abstract;

namespace LottoClassLibrary.Numbers
{
    public class JokerNumber : Number
    {
        public JokerNumber()
        {
            No = rnd.Next(1, 10);
        }
    }
}
