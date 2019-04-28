// ----------------------------------------------------------------------
// <copyright>
// file = "ExceptionManager.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 28.04.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter.Helper
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Class for handling exceptions
    /// </summary>
    public static class ExceptionManager
    {
        /// <summary>
        /// Show a exception that occurred in the code
        /// </summary>
        /// <param name="e">Exception to be shown</param>
        public static void ShowException(Exception e)
        {
            MessageBox.Show(
                @"QSLCardPrinter encountered an exception: " + Environment.NewLine + e.Message,
                @"Exception occurred",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}