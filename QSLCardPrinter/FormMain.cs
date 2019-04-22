using QSLCardPrinter.DataClasses;
using QSLCardPrinter.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSLCardPrinter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
        /// Read ADIF from Clipboard
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonReadClipboardClick(object sender, EventArgs e)
        {

            var listOfAdifs = this.EvaluateStringAdif(Clipboard.GetText());

            this.dataGridViewAdifItems.Rows.Clear();
            foreach (var adifItem in listOfAdifs)
            {
                this.dataGridViewAdifItems.Rows.Add(new Object[] { adifItem.AdifName, adifItem.AdifValue });
            }

        }

        /// <summary>
        /// Double click on the ADIF data grid view
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void DataGridViewAdifItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Create a new Label on the panel
            var label = new Label()
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

        private void LabelOnDoubleClick(object sender, EventArgs e)
        {
            new FormConfigLabel((Label)sender).ShowDialog();
        }

        private List<Label> labelList = new List<Label>();

              /// <summary>
        /// Click on the exit menu button
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Saves the current configuration (= position of labels) to XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ToDo: Rework to SaveFileDialog
            XmlHandler.WriteToXmlFile(this.labelList, "LabelList.xml");
        }

        /// <summary>
        /// Read a configuration (= position of labels) to the labelList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ToDo: Rework to OpenFileDialog
            this.labelList.Clear();
            this.labelList = XmlHandler.ReadFromXmlFile<List<Label>>("LabelList.xml");
        }
    }
}
