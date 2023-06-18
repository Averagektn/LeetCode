using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    public class Steps
    {
        public int NumberOfSteps(int num)
        {
            int steps = 0;

            while (num != 0)
            {
                if (num % 2 == 1 && num != 1)
                {
                    steps++;
                }
                num /= 2;
                steps++;
            }

            return steps;
        }
    }
}
