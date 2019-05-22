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
        private List<LabelItem> labelItemList = new List<LabelItem>();

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
                                string.IsNullOrEmpty(labelItem.DefaultString)
                                    ? labelItem.AdifKey
                                    : labelItem.DefaultString,
                            AutoSize = true,
                            BackColor = Color.Transparent,
                            Top = labelItem.PositionTop,
                            Left = labelItem.PositionLeft,
                            Font = labelItem.SelectedFont.ToFont(),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

            label.DoubleClick += this.LabelOnDoubleClick;

            this.labelItemList.Add(new LabelItem());

            this.panelDesigner.Controls.Add(label);
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
            this.labelItemList.Clear();

            // De-serialize items of once saved xml list to temporary label list
            this.labelItemList = XmlHandler.ReadFromXmlFile<List<LabelItem>>(fileName);

            // Show the labels from the list
            this.ShowLabelItemListToPanel();


        }

        /// <summary>
        /// Displays all label items
        /// </summary>
        private void ShowLabelItemListToPanel()
        {
            // Add all labels from temporary label list to global list which is currently active
            foreach (var labelItem in labelItemList)
            {
                this.AddLabel(labelItem);
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
                    XmlHandler.WriteToXmlFile(this.labelItemList, sfd.FileName);

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
            new LabelWizard(this.labelItemList).ShowDialog();
        }
    }
}