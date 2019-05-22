// ----------------------------------------------------------------------
// <copyright>
// file = "LabelItem.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 21.05.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter.DataClasses
{
    #region using directives

    using System.Windows.Forms;
    using System.Xml.Serialization;

    #endregion

    /// <summary>
    /// Class which holds information belonging to one ADIF item
    /// </summary>
    public class LabelItem
    {
        private Label label;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelItem"/> class.
        /// Empty constructor for serialization
        /// </summary>
        public LabelItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelItem"/> class.
        /// Create a new label item
        /// </summary>
        /// <param name="adifKey">Key value which is stored in adif</param>
        /// <param name="posTop">Position measured from top</param>
        /// <param name="posLeft">Position measured from left</param>
        /// <param name="selectedFont">Font that was selected</param>
        /// <param name="customString">Custom string for label, default null</param>
        public LabelItem(string adifKey, int posTop, int posLeft, SerializableFont selectedFont, string customString)
        {
            this.AdifKey = adifKey;
            this.PositionTop = posTop;
            this.PositionLeft = posLeft;
            this.SelectedFont = selectedFont;
            this.DefaultString = customString;
        }

        /// <summary>
        /// Gets or sets the key which relates to the adif
        /// </summary>
        public string AdifKey { get; set; }

        /// <summary>
        /// Gets or sets the string that indicates that the label has a custom string
        /// </summary>
        public string DefaultString { get; set; }

        /// <summary>
        /// Gets or sets the label relating to this data class
        /// </summary>
        [XmlIgnore]
        public Label Label
        {
            // If label is currently null, then create it (after de-serialization it is null)
            get => this.label ?? this.ToLabel();
            set => this.label = value;
        }

        /// <summary>
        /// Gets or sets the Position from left [mm]
        /// </summary>
        public int PositionLeft { get; set; }

        /// <summary>
        /// Gets or sets the position from top [mm]
        /// </summary>
        public int PositionTop { get; set; }

        /// <summary>
        /// Gets or sets the font that was selected
        /// </summary>
        public SerializableFont SelectedFont { get; set; }

        /// <summary>
        /// Converts the data of this class to a real label object
        /// </summary>
        /// <returns>A label object</returns>
        public Label ToLabel()
        {
            return new Label
                       {
                           Name = this.AdifKey,
                           Top = this.PositionTop,
                           Left = this.PositionLeft,
                           Font = this.SelectedFont.ToFont(),
                           Text = string.IsNullOrEmpty(this.DefaultString)
                                      ? this.AdifKey
                                      : this.DefaultString // Show, if available, custom string
                       };
        }

        /// <summary>
        /// Override to string function (to display in ListViews, etc.)
        /// </summary>
        /// <returns>adif key + default value</returns>
        public override string ToString()
        {
            return "[" + this.AdifKey + "] " + this.DefaultString;
        }
    }
}