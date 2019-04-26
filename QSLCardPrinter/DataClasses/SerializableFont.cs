#region using directives

using System.Drawing;

#endregion

namespace QSLCardPrinter.DataClasses
{
    /// <summary>
    /// Font descriptor, that can be xml-serialized
    /// </summary>
    public class SerializableFont
    {
        /// <summary>
        /// Initialize a new class of SerializableFont with a given System.Drawing.Font
        /// </summary>
        /// <param name="f">Font to be converted to serializable font</param>
        public SerializableFont(Font f)
        {
            FontFamily = f.FontFamily.Name;
            GraphicsUnit = f.Unit;
            Size = f.Size;
            Style = f.Style;
        }

        /// <summary>
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
            return new Font(FontFamily, Size, Style,
                GraphicsUnit);
        }
    }
}