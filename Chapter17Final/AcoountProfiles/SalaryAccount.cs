using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17Final.AcoountProfiles
{
    internal class SalaryAccount : BaseAccount, IInterestCalculator
    {

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }

    }

}
