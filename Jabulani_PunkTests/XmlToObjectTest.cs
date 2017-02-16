using Jabulani_Punk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jabulani_PunkTests
{
    [TestClass]
    public class XmlToObjectTest
    {
        [TestMethod]
        public void testxmltoObject()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "DebitOrders.xml");
            var obj = XmlToObject<debitorders>.GetXmlObject(xmlDoc.GetString(), typeof(debitorders));
            Assert.AreNotEqual(obj, null);
        }
    }
}
