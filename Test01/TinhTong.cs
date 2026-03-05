using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public class TinhTong
    {
        public int TinhTongCacSo(int[] n)
        {
            if (n == null || n.Length == 0)
                return 0;
            int sum = 0;
            foreach (var i in n)
            {
                sum += i;
            }
            return sum;
        }
    }
}
