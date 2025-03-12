using FixedDepositCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankClientApp.FestivalPolicy
{
    internal class NewYearPolicy : IRatePolicy
    {
        public double CalcuateRate()
        {
            //complex alogrithm

            return .08;
        }
    }
}
