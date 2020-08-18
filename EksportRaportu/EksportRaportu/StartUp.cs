using ReportExport.Models;
using System;
using System.IO;
using System.Text;

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
                Console.WriteLine($"\n{items.VIN}\n");
                foreach (var item in items.Features.Feature)
                {
                    Console.WriteLine($"{item.Code} + {item.Text}");
                }
            }

            xmlSerializerHelper.SerializeObject(deserializedObject.Factories.Factory.ProducedCars);
            
            CsvHelper csvHelper = new CsvHelper();
            csvHelper.TransformToCsv("serializedXml.xml");


            using (StreamReader sr = new StreamReader("output.csv"))
            {
                Console.WriteLine("\n\n Csv file opening ...\n\n");
                sr.ReadLine();

                string csvLine;

                while ((csvLine = sr.ReadLine()) != null)
                {
                    Console.WriteLine(csvLine);
                }
            }

            Console.ReadLine();
        }
    }
}
