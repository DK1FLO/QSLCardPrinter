// ----------------------------------------------------------------------
// <copyright>
// file = "AdifParser.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 27.05.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter.Helper
{
    #region using directives

    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using QSLCardPrinter.DataClasses;

    #endregion

    /// <summary>
    /// Parser helper for ADIF related data conversions
    /// </summary>
    public static class AdifHelper
    {
        /// <summary>
        /// Evaluates the ADIF string which was posted to clipboard
        /// </summary>
        /// <param name="adifString"> A complete adif string </param>
        /// <returns> A list of all found ADIF-Items</returns>
        public static List<AdifItem> EvaluateStringAdif(string adifString)
        {
            var regex = new Regex(@"<(?'name'\w+):(?'length'\d+)>(?'value'[^<]*)");
            var matches = regex.Matches(adifString);

            var adifItems = new List<AdifItem>();
            foreach (Match match in matches)
            {
                adifItems.Add(
                    new AdifItem(match.Groups["name"].Value.ToUpper(), match.Groups["value"].Value.TrimEnd()));
            }

            return adifItems;
        }
    }
}