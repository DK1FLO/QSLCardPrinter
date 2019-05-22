// ----------------------------------------------------------------------
// <copyright>
// file = "LabelWizard.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 22.05.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter
{
    #region using directives

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using QSLCardPrinter.DataClasses;

    #endregion

    /// <summary>
    /// Class for helping the user to create labels out of ADIF data
    /// </summary>
    public partial class LabelWizard : Form
    {
        /// <summary>
        /// Binding source for label lsit
        /// </summary>
        private readonly BindingSource bindingSourceLabelList = new BindingSource();

        /// <summary>
        /// Label list which should be edited
        /// </summary>
        private readonly List<LabelItem> labelList;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelWizard"/> class.
        /// </summary>
        public LabelWizard()
        {
            this.InitializeComponent();
        }

        public LabelWizard(List<LabelItem> labelList)
            : this()
        {
            this.labelList = labelList;
            this.bindingSourceLabelList.DataSource = this.labelList;
            this.listBoxLabelItems.DataSource = this.bindingSourceLabelList;
        }

        /// <summary>
        /// Read ADIF from clipboard (for example copied from HamRadioDeluxe
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonReadClipboardClick(object sender, EventArgs e)
        {
            var listOfAdifs = this.EvaluateStringAdif(Clipboard.GetText());

            this.dataGridViewAdifItems.Rows.Clear();
            foreach (var adifItem in listOfAdifs)
            {
                this.dataGridViewAdifItems.Rows.Add(
                    new DataGridViewRow
                        {
                            Cells =
                                {
                                    new DataGridViewTextBoxCell { Value = adifItem.AdifName },
                                    new DataGridViewTextBoxCell { Value = adifItem.AdifValue }
                                }
                        });
            }
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

        private void ButtonToLabelItemList_Click(object sender, EventArgs e)
        {
            this.labelList.Add(
                new LabelItem(
                    this.dataGridViewAdifItems.CurrentRow.Cells[0].Value.ToString(),
                    0,
                    0,
                    new SerializableFont(new Font(FontFamily.GenericSerif, 8, FontStyle.Regular)),
                    string.Empty));

            this.UpdateListView();
        }

        /// <summary>
        /// Evaluates the ADIF string which was posted to clipboard
        /// </summary>
        /// <param name="adifString"> A complete adif string </param>
        /// <returns> A list of all found ADIF-Items</returns>
        private List<AdifItem> EvaluateStringAdif(string adifString)
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

        /// <summary>
        /// New item is selected, show in "Settings for label"
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ListBoxLabelItemsSelectedIndexChanged(object sender, EventArgs e)
        {
            this.numericUpDownPositionLeft.Value = ((LabelItem)this.listBoxLabelItems.SelectedItem).PositionLeft;
            this.numericUpDownPositionTop.Value = ((LabelItem)this.listBoxLabelItems.SelectedItem).PositionTop;
            this.textBoxDefaultValue.Text = ((LabelItem)this.listBoxLabelItems.SelectedItem).DefaultString;
        }

        /// <summary>
        /// Position change: Position left
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void NumericUpDownPositionLeftValueChanged(object sender, EventArgs e)
        {
            ((LabelItem)this.listBoxLabelItems.SelectedItem).PositionLeft = (int)this.numericUpDownPositionLeft.Value;
        }

        /// <summary>
        /// Position change: Position top
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void NumericUpDownPositionTopValueChanged(object sender, EventArgs e)
        {
            ((LabelItem)this.listBoxLabelItems.SelectedItem).PositionTop = (int)this.numericUpDownPositionTop.Value;
        }

        /// <summary>
        /// Text change: default text
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void TextBoxDefaultValueTextChanged(object sender, EventArgs e)
        {
            ((LabelItem)this.listBoxLabelItems.SelectedItem).DefaultString = this.textBoxDefaultValue.Text;
        }

        /// <summary>
        /// Updates the listview with all current labels
        /// </summary>
        private void UpdateListView()
        {
            this.bindingSourceLabelList.ResetBindings(false);
        }
    }
}