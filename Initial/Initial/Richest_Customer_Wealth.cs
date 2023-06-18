namespace Initial
{
    public class Wealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            return accounts.Max(wealth => wealth.Sum());
        }
    }
}
