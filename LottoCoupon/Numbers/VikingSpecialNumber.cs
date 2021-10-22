namespace LottoClassLibrary.Numbers
{
    public class VikingSpecialNumber : VikingNumber
    {
        public VikingSpecialNumber()
        {
            No = rnd.Next(1, 6);
        }
    }
}
