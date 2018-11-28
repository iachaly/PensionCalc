using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain.Model;

namespace Gig.PensionCalc.Business.Rules
{
    public class DefaultRule : IPensionRule
    {
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo)
        {
            var age = userinfo.Sex == Sex.Woman ? 63 : 65;
            var years = userinfo.BirthDay.AddYears(65) - DateTime.Today;
            pensionInfo.RemainingYears = years;
            pensionInfo.Info += "standart - 65"+Environment.NewLine;
            return pensionInfo;
        }
    }
}
