// ----------------------------------------------------------------------
// <copyright>
// file = "LabelWizard.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 26.04.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter
{
    #region using directives

    using System;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    /// Class for helping the user to create labels out of ADIF data
    /// </summary>
    public partial class LabelWizard : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelWizard"/> class.
        /// </summary>
        public LabelWizard()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Read adif from file. Not supported yet, must be defined if one or all items are loaded
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonReadFromFileClick(object sender, EventArgs e)
        {
            throw new NotImplementedException("Not featured yet.");
        }
    }
}