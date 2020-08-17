using ReportExport.Models;
using System;

namespace ReportExport
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            const string XML_FILE = "BmwOriginal.xml";

            XmlSerializationHelper xmlSerializerHelper = new XmlSerializationHelper();
           
            ProductionReport deserializedObject = xmlSerializerHelper.DeserializeXml(XML_FILE);

            foreach (var items in deserializedObject.Factories.Factory.ProducedCars.Car)
            {
                Console.WriteLine(items.Features.Feature);
            }

            xmlSerializerHelper.SerializeObject(deserializedObject);

            Console.ReadLine();
        }
    }
}
