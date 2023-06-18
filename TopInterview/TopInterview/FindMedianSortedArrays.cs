using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview
{
    public class FindMedianSortedArrays
    {
        public double Find(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return Find(nums2, nums1);
            }

            var m = nums1.Length;
            var n = nums2.Length;
            var l = 0;
            var r = m;
            int partX, partY, maxLeftX, maxLeftY, minRightX, minRightY;

            while (l <= r)
            {
                partX = (l + r) / 2;
                partY = (m + n + 1) / 2 - partX;
                maxLeftX = partX == 0 ? int.MinValue : nums1[partX - 1];
                maxLeftY = partY == 0 ? int.MinValue : nums2[partY - 1];
                minRightX = partX == m ? int.MaxValue : nums1[partX];
                minRightY = partY == n ? int.MaxValue : nums2[partY];

                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    if ((m + n) % 2 == 0)
                    {
                        return ((double)Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;
                    }
                    else
                    {
                        return (double)Math.Max(maxLeftX, maxLeftY);
                    }
                }
                else if (maxLeftX > minRightY)
                {
                    r = partX - 1;
                }
                else
                {
                    l = partX + 1;
                }
            }

            return -1;
        }
    }
}
