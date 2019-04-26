using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSLCardPrinter
{
    public partial class FormConfigLabel : Form
    {
        #region Fields

        /// <summary>
        /// Reference to the label that should be edited
        /// </summary>
        private readonly Label labelToEdit;

        #endregion

        #region Constructors

        public FormConfigLabel(Label labelToEdit)
        {
            this.InitializeComponent();

            this.labelToEdit = labelToEdit;
            this.LoadPropertiesOfLabelToControls();
        }

        /// <summary>
        /// Load the properties that are available of the label to the controls
        /// </summary>
        private void LoadPropertiesOfLabelToControls()
        {
            this.numericUpDownPositionX.Value = this.labelToEdit.Left;
            this.numericUpDownPositionY.Value = this.labelToEdit.Top;
        }
        #endregion


        /// <summary>
        /// Change of the left (y) value of the label
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void NumericUpDownPositionYValueChanged(object sender, EventArgs e)
        {
            this.labelToEdit.Top = (int)this.numericUpDownPositionY.Value;
        }

        /// <summary>
        /// Select a suitable font for the label
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonSelectFontClick(object sender, EventArgs e)
        {
            var fontDialog1 = new FontDialog { ShowColor = true, Font = this.labelToEdit.Font, Color = this.labelToEdit.ForeColor };

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.labelToEdit.Font = fontDialog1.Font;
                this.labelToEdit.ForeColor = fontDialog1.Color;
            }
        }

        /// <summary>
        /// Change of the left (x) value of the label
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void NumericUpDownPositionXValueChanged(object sender, EventArgs e)
        {
            this.labelToEdit.Left = (int)this.numericUpDownPositionX.Value;
        }

        /// <summary>
        /// Click of the close button
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonCloseClick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
