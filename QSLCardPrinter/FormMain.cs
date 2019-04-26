// ----------------------------------------------------------------------
// <copyright>
// file = "FormMain.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 26.04.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter
{
    #region using directives

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using QSLCardPrinter.DataClasses;
    using QSLCardPrinter.Helper;

    #endregion

    public partial class FormMain : Form
    {
        /// <summary>
        /// List of labels that are displayed or printed
        /// </summary>
        private readonly List<Label> labelList = new List<Label>();

        public FormMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Add a labelItem to the label list (also to the panel)
        /// </summary>
        /// <param name="labelItem">label item which should be added</param>
        private void AddLabel(LabelItem labelItem)
        {
            Label label;

            // Check if font is not null, then add
            label = new Label
                        {
                            Name = labelItem.AdifKey,
                            Text =
                                string.IsNullOrEmpty(labelItem.CustomString)
                                    ? labelItem.AdifKey
                                    : labelItem.CustomString,
                            AutoSize = true,
                            BackColor = Color.Transparent,
                            Top = labelItem.PositionTop,
                            Left = labelItem.PositionLeft,
                            Font = labelItem.SelectedFont.ToFont(),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

            label.DoubleClick += this.LabelOnDoubleClick;

            this.labelList.Add(label);
            this.panelDesigner.Controls.Add(label);
        }

        /// <summary>
        /// Read ADIF from Clipboard
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonReadClipboardClick(object sender, EventArgs e)
        {
            var listOfAdifs = this.EvaluateStringAdif(Clipboard.GetText());

            this.dataGridViewAdifItems.Rows.Clear();
            foreach (var adifItem in listOfAdifs)
                this.dataGridViewAdifItems.Rows.Add(adifItem.AdifName, adifItem.AdifValue);
        }

        /// <summary>
        /// Double click on the ADIF data grid view
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void DataGridViewAdifItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Create a new Label on the panel
            var label = new Label
                            {
                                Name = "label" + this.dataGridViewAdifItems.Rows[e.RowIndex].Cells[0].Value,
                                Text = this.dataGridViewAdifItems.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                AutoSize = true
                            };

            // Add event to the label in order to config the label
            label.DoubleClick += this.LabelOnDoubleClick;

            this.labelList.Add(label);
            this.panelDesigner.Controls.Add(label);
        }

        /// <summary>
        /// Evaluates the ADIF string which was posted to clipboard
        /// </summary>
        /// <param name="adifString"></param>
        private List<AdifItem> EvaluateStringAdif(string adifString)
        {
            var regex = new Regex(@"<(?'name'\w+):(?'length'\d+)>(?'value'[^<]*)");
            var matches = regex.Matches(adifString);

            var adifItems = new List<AdifItem>();
            foreach (var match in matches)
            {
                var x = (Match)match;
                adifItems.Add(new AdifItem(x.Groups["name"].Value.ToUpper(), x.Groups["value"].Value.TrimEnd()));
            }

            return adifItems;
        }

        /// <summary>
        /// Click on the exit menu button
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelOnDoubleClick(object sender, EventArgs e)
        {
            new FormConfigLabel((Label)sender).ShowDialog();
        }

        /// <summary>
        /// Read a configuration (= position of labels) to the labelList
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void OpenTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Use open file dialog 
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = @"XML files|*.xml";
                ofd.Title = @"Read QSLCardPrinter template file";
                ofd.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                ofd.RestoreDirectory = true;

                // Show Dialog, only if successful continue loading
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Dispose all old labels
                    foreach (var label in this.labelList) label.Dispose();

                    // Clear the list to be clean for items out of XML file
                    this.labelList.Clear();

                    // De-serialize items of once saved xml list to temporary label list
                    var labelItemList = XmlHandler.ReadFromXmlFile<List<LabelItem>>(ofd.FileName);

                    // Add all labels from temporary label list to global list which is currently active
                    foreach (var labelItem in labelItemList) this.AddLabel(labelItem);
                }
            }
        }

        /// <summary>
        /// Saves the current configuration (= position of labels) to XML
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void SaveTemplateToolStripMenuItemClick(object sender, EventArgs e)
        {
            // use save file dialog
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = @"XML files|*.xml";
                sfd.Title = @"Save QSLCardPrinter template file";
                sfd.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                sfd.RestoreDirectory = true;

                // Show dialog - check if the file name is not an empty string, then serialize list for saving.  
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    var labelItemList = new List<LabelItem>();
                    foreach (var label in this.labelList)
                        labelItemList.Add(
                            new LabelItem(
                                label.Name,
                                label.Top,
                                label.Left,
                                new SerializableFont(label.Font),
                                label.Name.StartsWith("custom") ? label.Text : null));

                    XmlHandler.WriteToXmlFile(labelItemList, sfd.FileName);
                }
            }
        }

        /// <summary>
        /// Start the label wizard so the user can add new items of a loaded adif file
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void StartLabelWizardToolStripMenuItemClick(object sender, EventArgs e)
        {

        }
    }
}