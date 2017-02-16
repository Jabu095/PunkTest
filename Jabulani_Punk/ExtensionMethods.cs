using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jabulani_Punk
{
   public static class ExtensionMethods
    {
      
        /// <summary>
        /// creating an extension method to get the xml string
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
            public static string GetString(this XmlDocument xmlDoc)
            {
                using (StringWriter str = new StringWriter())
                {
                    using (XmlTextWriter tx = new XmlTextWriter(str))
                    {
                        xmlDoc.WriteTo(tx);
                        string strXmlText = str.ToString();
                        return strXmlText;
                    }
                }
            }
       
    }
}
