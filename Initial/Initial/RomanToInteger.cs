namespace Initial
{
    public class RomanToInteger
    {

        private Dictionary<char, int> Integer = new()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        public int RomanToInt(string s)
        {
            int res = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int num = Integer[s[i]];
                if (num < Integer[s[i + 1]])
                {
                    res -= num;
                }
                else
                {
                    res += num;
                }
            }

            return res + Integer[s[^1]];
        }
    }
}