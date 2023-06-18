using System.Text;

namespace TopInterview
{
    internal class Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {
            var maxLen = 1;
            var maxLenStr = "";

            for (var i = 0; i < s.Length; i++)
            {
                var l = i;
                var r = i;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 >= maxLen)
                    {
                        maxLen = r - l + 1;
                        maxLenStr = s.Substring(l, r - l + 1);
                    }
                    l--;
                    r++;
                }

                l = i;
                r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 >= maxLen)
                    {
                        maxLen = r - l + 1;
                        maxLenStr = s.Substring(l, r - l + 1);
                    }
                    l--;
                    r++;
                }
            }
            return maxLenStr;
        }
    }
}
