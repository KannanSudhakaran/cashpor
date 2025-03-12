using FixedDepositCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitonBankClientApp.QuarterlyPolicy
{
    internal class QuarterOnePolicy : IRatePolicy
    {
        public double CalcuateRate()
        {
            return .08;
        }
    }
}
