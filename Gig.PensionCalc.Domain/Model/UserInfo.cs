using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gig.PensionCalc.Domain.Model
{
    /// <summary>
    /// инфа о челе
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// фио
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// дата рождения
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// пол
        /// </summary>
        public Sex Sex { get; set; }
        /// <summary>
        /// места работы
        /// </summary>
        public Work[] Works { get; set; }
    }
}
