using Gig.PensionCalc.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    public interface IPensionRule
    {

        PensionInfo Apply(PensionInfo pensionInfo, UserInfo userinfo);
    }
}
