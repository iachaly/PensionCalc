using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gig.PensionCalc.Domain.Model;

namespace Gig.PensionCalc.Business.Rules
{
    public class BD1959Rule : IPensionRule
    {
        public PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo)
        {
            if (userinfo.BirthDay.Year == 1959 && userinfo.Sex==Sex.Man)
            {
                pensionInfo.RemainingYears = new DateTime(2020,1,1)-DateTime.Today;
                pensionInfo.Info += "born 1959 out 2020" + Environment.NewLine;
            }
            return pensionInfo;
        }
    }
}
