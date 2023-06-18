namespace Initial
{
    public class FizzBuzz
    {
        public IList<string> Count(int n)
        {
            List<string> res = new(n);

            for (int i = 1; i <= n; i++)
            {
                res.Add(
                    (i % 3 == 0, i % 5 == 0) switch
                    {
                        (true, true) => "FizzBuzz",
                        (true, false) => "Fizz",
                        (false, true) => "Buzz",
                        (false, false) => i.ToString()
                    }
                );
            }

            return res;
        }
    }
}
