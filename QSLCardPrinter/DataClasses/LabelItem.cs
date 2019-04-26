// ----------------------------------------------------------------------
// <copyright>
// file = "LabelItem.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 26.04.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter.DataClasses
{
    /// <summary>
    /// Class which holds information belonging to one ADIF item
    /// </summary>
    public class LabelItem
    {
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
            this.CustomString = customString;
        }

        /// <summary>
        /// Gets or sets the key which relates to the adif
        /// </summary>
        public string AdifKey { get; set; }

        /// <summary>
        /// Gets or sets the string that indicates that the label has a custom string
        /// </summary>
        public string CustomString { get; set; }

        /// <summary>
        /// Gets or sets the Position from left
        /// </summary>
        public int PositionLeft { get; set; }

        /// <summary>
        /// Gets or sets the position from top
        /// </summary>
        public int PositionTop { get; set; }

        /// <summary>
        /// Gets or sets the font that was selected
        /// </summary>
        public SerializableFont SelectedFont { get; set; }
    }
}