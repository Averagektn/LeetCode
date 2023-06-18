namespace Initial
{
    public class WeakestRows
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            return mat
                .Select((row, ind) => new { count = row.Sum(), ind })
                .OrderBy(res => res.count)
                .Select(res => res.ind)
                .Take(k)
                .ToArray();
        }
    }
}
