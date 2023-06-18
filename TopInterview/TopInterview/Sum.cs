namespace TopInterview
{
    public class Sum
    {
        public int[]? TwoSum(int[] nums, int target)
        {
            var pairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var res = 0;

                if (pairs.TryGetValue(target - nums[i], out res))
                {
                    return new int[] { res, i };
                }
                else
                {
                    pairs.TryAdd(nums[i], i);
                }
            }

            return default;
        }
    }
}