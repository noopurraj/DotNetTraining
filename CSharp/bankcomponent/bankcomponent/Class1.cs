using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankcomponent
{
    public class SavingsBank
    {
        public double GetInterest(int p, int r,int t)
        {
            var Interest = (p * r * t) / 100;
            return Interest;
        }
        
    }
}
