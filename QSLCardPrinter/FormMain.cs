// ----------------------------------------------------------------------
// <copyright>
// file = "FormMain.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 21.05.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
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
    using System.Windows.Forms;

    using QSLCardPrinter.DataClasses;
    using QSLCardPrinter.Helper;
    using QSLCardPrinter.Properties;

    #endregion

    /// <summary>
    /// Main form of the application
    /// </summary>
    public partial class FormMain : Form
    {
        public static List<LabelItem> labelItemList = new List<LabelItem>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class. 
        /// </summary>
        public FormMain()
        {
            this.InitializeComponent();

            // Load last active template, if selected
            if (Settings.Default.LoadLastActiveTemplate
                && !string.IsNullOrEmpty(Settings.Default.LastActiveTemplatePath))
            {
                try
                {
                    this.LoadFromTemplate(Settings.Default.LastActiveTemplatePath);
                }
                catch (Exception e)
                {
                    ExceptionManager.ShowException(new Exception("Could not load last active template.", e));
                }
            }

            // Load last active background image, if selected
            if (Settings.Default.LastActiveBackgroundImage
                && !string.IsNullOrEmpty(Settings.Default.LastActiveBackgroundImagePath))
            {
                try
                {
                    // Load last image to panel
                    this.panelDesigner.BackgroundImage = Image.FromFile(Settings.Default.LastActiveBackgroundImagePath);
                }
                catch (Exception e)
                {
                    ExceptionManager.ShowException(new Exception("Could not load last active background image.", e));
                }
            }
        }

        /// <summary>
        /// Clear the background image
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ClearBackgroundImageToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.panelDesigner.BackgroundImage = null;
        }

        /// <summary>
        /// Show configuration dialog
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ConfigureToolStripMenuItemClick(object sender, EventArgs e)
        {
            new ConfigurationDialog().ShowDialog();
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

        /// <summary>
        /// Event handler for showing Label config form
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void LabelOnDoubleClick(object sender, EventArgs e)
        {
            new FormConfigLabel((Label)sender).ShowDialog();
        }

        /// <summary>
        /// Load background image in panel designed
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void LoadBackgroundImageToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = @"JPG files (*.jpg)|*.jpg,*jpeg|Portable Network Graphic files (*.png)|*.png";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    this.panelDesigner.BackgroundImage = Image.FromFile(ofd.FileName);

                    // Save image path as last active
                    Settings.Default.LastActiveBackgroundImagePath = ofd.FileName;
                    Settings.Default.Save();
                }
            }
        }

        /// <summary>
        /// Load label items from file to labelList
        /// </summary>
        /// <param name="fileName">Filename / path that should be loaded</param>
        private void LoadFromTemplate(string fileName)
        {
            // Clear the list to be clean for items out of XML file
            labelItemList.Clear();

            // De-serialize items of once saved xml list to temporary label list
            labelItemList = XmlHandler.ReadFromXmlFile<List<LabelItem>>(fileName);

            // Show the labels from the list
            this.UpdateDisplayedLabels();
        }

        /// <summary>
        /// Displays all label items
        /// </summary>
        private void UpdateDisplayedLabels()
        {
            // Clear old items
            this.panelDesigner.Controls.Clear();

            // Add all labels to panel designer
            foreach (var labelItem in labelItemList)
            {
                var label = labelItem.Label;

                // Change Top/Left according to width of the panel designer
                label.Left = (int)(this.panelDesigner.Width
                                   * (labelItem.PositionLeft / (double)Settings.Default.QSLCardWidth));
                label.Top = (int)(this.panelDesigner.Height
                                  * (labelItem.PositionTop / (double)Settings.Default.QSLCardHeight));

                label.BorderStyle = BorderStyle.FixedSingle;

                // Check if current string is empty -> display adif key. Later in print, there is the decision between default value or current
                label.Text = string.IsNullOrEmpty(labelItem.CurrentValueString) ? labelItem.AdifKey : labelItem.CurrentValueString;
                

                this.panelDesigner.Controls.Add(label);

                label.DoubleClick += this.LabelOnDoubleClick;
            }
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
                    // Load from template
                    this.LoadFromTemplate(ofd.FileName);

                    // Save in settings as last loaded file
                    Settings.Default.LastActiveTemplatePath = ofd.FileName;
                    Settings.Default.Save();
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
                    XmlHandler.WriteToXmlFile(labelItemList, sfd.FileName);

                    // Save in settings as last active file
                    Settings.Default.LastActiveTemplatePath = sfd.FileName;
                    Settings.Default.Save();
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
            var labelWizard = new LabelWizard();
            labelWizard.LabelListUpdated += this.LabelWizardLabelListUpdated;
            labelWizard.ShowDialog();
        }

        private void LabelWizardLabelListUpdated(object sender, EventArgs e)
        {
            this.UpdateDisplayedLabels();
        }

        private void ButtonLoadFromClip_Click(object sender, EventArgs e)
        {
            var listOfAdifs = AdifHelper.EvaluateStringAdif(Clipboard.GetText());

            foreach (var adifItem in listOfAdifs)
            {
                var labelItem = labelItemList.Find(x => x.AdifKey == adifItem.AdifName);
                if (labelItem != null)
                {
                    labelItem.CurrentValueString = adifItem.AdifValue;
                }
            }

            this.UpdateDisplayedLabels();
        }
    }
}