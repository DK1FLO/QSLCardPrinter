using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSLCardPrinter.DataClasses
{
    /// <summary>
    /// Class which holds information belonging to one ADIF item
    /// </summary>
    public class AdifItem
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdifItem"/> class. 
        /// </summary>
        /// <param name="name">Name of the ADIF item</param>
        /// <param name="value">Value of the ADIF item</param>
        public AdifItem(string name, string value)
        {
            this.AdifName = name;
            this.AdifValue = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the ADIF item
        /// example: frequency
        /// </summary>
        public string AdifName { get; set; }

        /// <summary>
        /// Gets or sets the value of the ADIF item
        /// example: 3.580123
        /// </summary>
        public string AdifValue { get; set; }

        #endregion
    }
}
