// ----------------------------------------------------------------------
// <copyright>
// file = "FormAddFreeText.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 27.05.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter
{
    #region using directives

    using System;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    /// Form for getting the free text
    /// </summary>
    public partial class FormAddFreeText : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormAddFreeText"/> class.
        /// Ask the user for the free text that should be added
        /// </summary>
        public FormAddFreeText()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the text returned by user
        /// </summary>
        public string ReturnText { get; private set; }

        /// <summary>
        /// Click on the button add, dialog successful
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonAddClick(object sender, EventArgs e)
        {
            this.ReturnText = this.textBoxFreeText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancel the add, dialog is not successful
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}