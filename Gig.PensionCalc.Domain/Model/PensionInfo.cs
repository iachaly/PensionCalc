using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Domain.Model
{
    /// <summary>
    /// информация о пенсии
    /// </summary>
    public class PensionInfo
    {
        /// <summary>
        /// сколько лет осталось работать
        /// </summary>
        public TimeSpan RemainingYears { get; set; }
        /// <summary>
        /// стаж
        /// </summary>
        public TimeSpan ExpirienceYears { get; set; }

        public string Info { get; set; }

        public override string ToString()
        {
            return $"{RemainingYears.TotalDays}, {ExpirienceYears.TotalDays}" + Environment.NewLine + Info;
        }
    }
}
