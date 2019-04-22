using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QSLCardPrinter.Helper
{
    /// <summary>
    /// Class for handling XML file creation and read-back
    /// </summary>
    class XmlHandler
    {
        #region Public methods

        /// <summary>
        /// Read an object back from a XML file
        /// </summary>
        /// <typeparam name="T">Type parameter of object to be read from xml</typeparam>
        /// <param name="filePath">path where the XML-File is located</param>
        /// <returns>The object that was once saved, otherwise null</returns>
        public static T ReadFromXmlFile<T>(string filePath)
             where T : new()
        {
            StreamReader sr = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                sr = new StreamReader(filePath);
                return (T)serializer.Deserialize(sr);
            }
            finally
            {
                sr?.Close();
            }
        }

        /// <summary>
        /// An object of any type is being written to an XML file using the XMLSerializer   
        /// </summary>
        /// <typeparam name="T">Type parameter of object to be saved as xml</typeparam>
        /// <param name="objectForXml">object which should be written to XML</param>     
        /// <param name="pathToFile">path where the file should be saved</param>
        public static void WriteToXmlFile<T>(T objectForXml, string pathToFile)
            where T : new()
        {

            // Init 
            StreamWriter tw = null;
            try
            {
                // Create serializer for the given object type
                var serializer = new XmlSerializer(typeof(T));

                // location to save the xml file
                var saveDirectory = Path.GetDirectoryName(pathToFile);

                // Create directory, if not already exists (should not be the case due to SaveFileDialog)
                if (!Directory.Exists(saveDirectory))
                {                  
                   Directory.CreateDirectory(saveDirectory);
                }

                // create new StreamWriter and serialize object
                tw = new StreamWriter(pathToFile);
                serializer.Serialize(tw, objectForXml);
            }
            finally
            {
                tw?.Close();
            }
        }

        #endregion
    }
}
