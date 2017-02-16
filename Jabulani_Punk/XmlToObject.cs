using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Jabulani_Punk
{
   public static class XmlToObject<T>
   {
     public static T GetXmlObject(string xml, Type objectType)
        {
                T obj;
                using (StringReader str = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(objectType);
                    using (XmlTextReader xmlTextReader = new XmlTextReader(str))
                    {
                        obj = (T)serializer.Deserialize(xmlTextReader);
                    }
                   
                }
                return obj;
           
        }
   }
}
