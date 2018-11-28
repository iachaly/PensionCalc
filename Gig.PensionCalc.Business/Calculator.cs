using Gig.PensionCalc.Business.Rules;
using Gig.PensionCalc.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Business
{
    
  
    public class Calculator
    {
        private IEnumerable<IPensionRule> Rules { get; set; } 
        public Calculator()
        {
            Rules = new List<IPensionRule>()
            {
                new DefaultRule(),
                new isWomanRule(),
                new BD1959Rule()
            };
        }
        public PensionInfo Calc(UserInfo userinfo)
        {
            var result = new PensionInfo();
            var currentRules = new List<IPensionRule>();
            //var age = userinfo.Sex == Sex.Woman ? 63 : 65;
            //var years = userinfo.BirthDay.AddYears(age) - DateTime.Today;

            //result.RemainingYears = years;

            var sexRules = Rules.OfType<ISexRule>();
            var otherRules = sexRules.Except(Rules);
            var currentSexRules = sexRules.Where(
                rule => rule.Sex ==userinfo.Sex
                );
            currentRules.AddRange(otherRules);
            foreach (var rule in Rules)
            {

                result = rule.Apply(result, userinfo);
            }
            
            return result;
        }
    }
}
