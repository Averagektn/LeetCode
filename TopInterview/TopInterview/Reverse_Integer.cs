using System.Text;

namespace TopInterview
{
    public class Reverse_Integer
    {
        public int Reverse(int x)
        {
            var sb = new StringBuilder();
            var sign = 1;

            if (x < 0)
            {
                sign = -1;
                x *= -1;
            }

            while (x != 0)
            {
                sb.Append(x % 10);
                x /= 10;
            }

            if (int.TryParse(sb.ToString(), out x))
            {
                return x * sign;
            }
            return 0;
        }
    }
}
