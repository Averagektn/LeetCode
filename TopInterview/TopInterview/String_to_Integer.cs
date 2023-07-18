using System.Text;

namespace TopInterview
{
    internal class String_to_Integer
    {
        public int MyAtoi(string s)
        {
            var sb = new StringBuilder();
            var sign = 1;
            var i = 0;
            int res;

            s = s.Trim();
            if (s.StartsWith('-'))
            {
                i = 1;
                sign = -1;
            }
            if (s.StartsWith('+'))
            {
                i = 1;
            }

            while (i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                sb.Append(s[i++]);
            }

            if (sb.Length == 0)
            {
                return 0;
            }

            if (int.TryParse(sb.ToString(), out res))
            {
                return sign * res;
            }
            else if (sign == -1)
            {
                return int.MinValue;
            }
            else
            {
                return int.MaxValue;
            }
        }
    }
}
