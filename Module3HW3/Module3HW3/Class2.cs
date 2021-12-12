using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Class2
    {
        private int _y;

        private Predicate<int> Calc(Func<int, int, int> func, int a, int b)
        {
            _y = func.Invoke(a, b);
            return Result;
        }

        private bool Result(int x)
        {
            if (_y % x == 0)
            {
                return true;
            }

            return false;
        }
    }
}
