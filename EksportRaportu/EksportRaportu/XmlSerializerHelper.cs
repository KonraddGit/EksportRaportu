using ReportExport.Models;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ReportExport
{
    public class XmlSerializerHelper
    {
        public ProductionReport DeserializeObject(string filename)
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
    }
}
