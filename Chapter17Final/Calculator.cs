using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17Final
{
    public class Calculator
    {
        public static void Calculate(IInterestCalculator account)
        {
            account.CalculateInterest();
        }
    }
}
