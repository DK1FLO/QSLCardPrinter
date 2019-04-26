// ----------------------------------------------------------------------
// <copyright>
// file = "SerializableFont.cs"
// project = QSLCardPrinter, QSLCardPrinter
// last edit 26.04.2019 by Florian Platz (DO1FPI), DO1FPI@darc.de
// // </copyright>
// ----------------------------------------------------------------------

namespace QSLCardPrinter.DataClasses
{
    #region using directives

    using System.Drawing;

    #endregion

    /// <summary>
    /// Font descriptor, that can be xml-serialized
    /// </summary>
    public class SerializableFont
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableFont"/> class. 
        /// </summary>
        /// <param name="drawingFont"> Font to be converted to serializable font </param>
        public SerializableFont(Font drawingFont)
        {
            this.FontFamily = drawingFont.FontFamily.Name;
            this.GraphicsUnit = drawingFont.Unit;
            this.Size = drawingFont.Size;
            this.Style = drawingFont.Style;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="SerializableFont"/> class from being created. 
        /// Intended for xml serialization purposes only
        /// </summary>
        private SerializableFont()
        {
        }

        /// <summary>
        /// Gets or sets the font family
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the unit of the data relating the font
        /// </summary>
        public GraphicsUnit GraphicsUnit { get; set; }

        /// <summary>
        /// Gets or sets the size of the font
        /// </summary>
        public float Size { get; set; }

        /// <summary>
        /// Gets or sets the style of the font (e.g. bold, italic, etc.)
        /// </summary>
        public FontStyle Style { get; set; }

        /// <summary>
        /// Convert and return a serializable font based on a given font
        /// </summary>
        /// <param name="f">System.Drawing.Font that should be converted</param>
        /// <returns>A serializable font</returns>
        public static SerializableFont FromFont(Font f)
        {
            return new SerializableFont(f);
        }

        /// <summary>
        /// Convert the serialized font to a new System.Drawing.Font and return it
        /// </summary>
        /// <returns>A System.Drawing.Font</returns>
        public Font ToFont()
        {
            return new Font(this.FontFamily, this.Size, this.Style, this.GraphicsUnit);
        }
    }
}