using System;

namespace Gig.PensionCalc.Domain.Model
{
    /// <summary>
    /// Информация о месте работы 
    /// </summary>
    public class Work
    {
        /// <summary>
        /// дата трудоустройства
        /// </summary>
        public DateTime PeriodStart { get; set; }
        /// <summary>
        /// дата увольнения
        /// </summary>
        public DateTime PeriodEnd { get; set; }
        /// <summary>
        /// должность 
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// отчисления за весь период
        /// </summary>
        public double Money { get; set; }
    }
}