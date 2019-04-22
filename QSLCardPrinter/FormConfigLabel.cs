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
    }
}
