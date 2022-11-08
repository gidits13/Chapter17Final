using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17Final.AcoountProfiles
{
    internal class RegularAccount : BaseAccount, IInterestCalculator
    {
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
