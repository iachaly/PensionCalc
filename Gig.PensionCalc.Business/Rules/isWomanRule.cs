using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain.Model;

namespace Gig.PensionCalc.Business.Rules
{
    public class isWomanRule : ISexRule
    {
        public Sex Sex => Sex.Woman;

        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo)
        {

                pensionInfo.RemainingYears = pensionInfo.RemainingYears.Add(new TimeSpan(-365 * 2, 0, 0, 0));
                pensionInfo.Info += "for woman - 2" + Environment.NewLine;

            return pensionInfo;
        }
    }
}
