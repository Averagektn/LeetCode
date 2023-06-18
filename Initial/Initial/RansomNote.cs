namespace Initial
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineLetters = new();

            foreach (var c in magazine)
            {
                if (magazineLetters.ContainsKey(c))
                {
                    magazineLetters[c]++;
                }
                else
                {
                    magazineLetters.Add(c, 1);
                }
            }

            foreach (var c in ransomNote)
            {
                if (magazineLetters.ContainsKey(c) && magazineLetters[c] != 0)
                {
                    magazineLetters[c]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
