using ReportExport.Models;
using System.IO;
using System.Xml.Serialization;

namespace ReportExport
{
    public class XmlSerializationHelper
    {
        public ProductionReport DeserializeXml(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProductionReport));

            ProductionReport productionReport;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                productionReport = (ProductionReport)serializer.Deserialize(reader);
            }

            return productionReport;
        }

        public void SerializeObject(ProducedCars producedCars)
        {

            XmlSerializer mySerializer = new XmlSerializer(typeof(ProducedCars));

            using (StreamWriter myWriter = new StreamWriter("serializedXml.xml"))
            {
                mySerializer.Serialize(myWriter, producedCars);
            }
        }
    }
}
