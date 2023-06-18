namespace TopInterview
{
    public class Longest_Substring_Without_Repeating_Characters
    {
        public int Find(string s)
        {
            var letters = new HashSet<char>();
            var max = 0;
            var i = 0;
            var j = 0;

            while (i < s.Length)
            {
                if (!letters.Contains(s[i]))
                {
                    letters.Add(s[i]);
                    i++;
                }
                else
                {
                    max = Math.Max(max, letters.Count);
                    letters.Remove(s[j]);
                    j++;
                }
            }

            return Math.Max(max, letters.Count);
        }
    }
}
