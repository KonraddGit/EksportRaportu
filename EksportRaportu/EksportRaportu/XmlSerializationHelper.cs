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

            ProductionReport productionReport;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                productionReport = (ProductionReport)serializer.Deserialize(reader);
            }

            return productionReport;
        }

        public void SerializeObject(ProductionReport productionReport)
        {
            
            XmlSerializer mySerializer = new XmlSerializer(typeof(ProductionReport));
            
            StreamWriter myWriter = new StreamWriter("serializedXml.xml");
            mySerializer.Serialize(myWriter, productionReport);
            myWriter.Close();
        }
    }
}
