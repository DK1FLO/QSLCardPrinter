// ----------------------------------------------------------------------
// <copyright>
// file = "ConfigurationDialog.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 28.04.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter
{
    #region using directives

    using System;
    using System.Windows.Forms;

    using QSLCardPrinter.Properties;

    #endregion

    /// <summary>
    /// Form for configuration of QSLCardPrinter
    /// </summary>
    public partial class ConfigurationDialog : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDialog"/> class.  
        /// </summary>
        public ConfigurationDialog()
        {
            this.InitializeComponent();

            // Load settings from settings
            this.LoadSettings();
        }

        /// <summary>
        /// User canceled settings
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonCancelClick(object sender, EventArgs e)
        {
            // Result is canceled, close
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Ok (=save settings) and close
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void ButtonOkClick(object sender, EventArgs e)
        {
            // Save settings
            this.SaveSettings();

            // Result is OK, close the dialog
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Load settings from settings file
        /// </summary>
        private void LoadSettings()
        {
            // Load last active template + path
            this.checkBoxLoadLastTemplate.Checked = Settings.Default.LoadLastActiveTemplate;
            this.textBoxLastActiveTemplateFileName.Text = Settings.Default.LastActiveTemplatePath;

            // Load last active template + path
            this.checkBoxLoadLastActiveBackgroundImage.Checked = Settings.Default.LastActiveBackgroundImage;
            this.textBoxLastActiveTemplateFileName.Text = Settings.Default.LastActiveBackgroundImagePath;
        }

        /// <summary>
        /// Save settings to settings file
        /// </summary>
        private void SaveSettings()
        {
            // Load last active template
            Settings.Default.LoadLastActiveTemplate = this.checkBoxLoadLastTemplate.Checked;

            // Background image load by default?
            Settings.Default.LastActiveBackgroundImage = this.checkBoxLoadLastActiveBackgroundImage.Checked;

            // Save settings
            Settings.Default.Save();
        }
    }
}