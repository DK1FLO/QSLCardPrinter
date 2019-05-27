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
    using QSLCardPrinter.Helper;

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
        /// Initializes a new instance of the <see cref="LabelWizard"/> class.
        /// </summary>
        public LabelWizard()
        {
            this.InitializeComponent();

            this.bindingSourceLabelList.DataSource = FormMain.labelItemList;
            this.listBoxLabelItems.DataSource = this.bindingSourceLabelList;
        }

        public event EventHandler LabelListUpdated;


        /// <summary>
        /// Read ADIF from clipboard (for example copied from HamRadioDeluxe)
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonReadClipboardClick(object sender, EventArgs e)
        {
            // Clear old data
            this.dataGridViewAdifItems.Rows.Clear();

            // Evaluate the given ADIF text from clip
            var listOfAdifs = AdifHelper.EvaluateStringAdif(Clipboard.GetText());
            
            // Add to GridView
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
            //// throw new NotImplementedException("Not featured yet.");
        }

        /// <summary>
        /// Add a label based on selected item in dataGridView
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonToLabelItemListClick(object sender, EventArgs e)
        {
            // Add label based on selected dataGridView row, if not null
            var dataGridViewRow = this.dataGridViewAdifItems.CurrentRow;
            if (dataGridViewRow != null)
            {
                FormMain.labelItemList.Add(
                    new LabelItem(
                        dataGridViewRow.Cells[0].Value.ToString(),
                        0,
                        0,
                        new SerializableFont(new Font(FontFamily.GenericSerif, 8, FontStyle.Regular)),
                        string.Empty));

                // Update the listview
                this.UpdateListView();
            }
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
            this.OnLabelListUpdated();
        }

        /// <summary>
        /// Position change: Position top
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void NumericUpDownPositionTopValueChanged(object sender, EventArgs e)
        {
            ((LabelItem)this.listBoxLabelItems.SelectedItem).PositionTop = (int)this.numericUpDownPositionTop.Value;
            this.OnLabelListUpdated();
        }

        /// <summary>
        /// Text change: default text
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void TextBoxDefaultValueTextChanged(object sender, EventArgs e)
        {
            ((LabelItem)this.listBoxLabelItems.SelectedItem).DefaultString = this.textBoxDefaultValue.Text;
            this.OnLabelListUpdated();
        }

        /// <summary>
        /// Updates the listview with all current labels
        /// </summary>
        private void UpdateListView()
        {
            this.bindingSourceLabelList.ResetBindings(false);
            this.OnLabelListUpdated();
        }

        /// <summary>
        /// Delete a label from the label list
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonDeleteLabelClick(object sender, EventArgs e)
        {
            // Remove the currently selected label, then update the list view
            FormMain.labelItemList.Remove((LabelItem)this.listBoxLabelItems.SelectedItem);
            this.UpdateListView();
        }

        protected virtual void OnLabelListUpdated()
        {
            this.LabelListUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonAddFreeTextClick(object sender, EventArgs e)
        {
            var diagForm = new FormAddFreeText();
            if (diagForm.ShowDialog() == DialogResult.OK)
            {
                FormMain.labelItemList.Add(new LabelItem(@"freetext_" + DateTime.Now.ToBinary(), 0, 0, new SerializableFont(new Font(FontFamily.GenericSansSerif, 10)), diagForm.ReturnText));
                this.UpdateListView();
               
            }
        }
    }
}