using ReportExport.Models;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ReportExport
{
    public class XmlSerializationHelper
    {
        public ProductionReport DeserializeXml(string filename)
        {
            Console.WriteLine("Reading with Stream");

            XmlSerializer serializer = new XmlSerializer(typeof(ProductionReport));

            ProductionReport i;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                i = (ProductionReport)serializer.Deserialize(reader);
            }

            return i;
        }

        public void SerializeObject()
        {
            ProductionReport i = new ProductionReport();
            
            XmlSerializer mySerializer = new XmlSerializer(typeof(ProductionReport));
            
            StreamWriter myWriter = new StreamWriter("serializedXml.xml");
            mySerializer.Serialize(myWriter, i);
            myWriter.Close();
        }
    }
}
