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
           
            ProductionReport i = xmlSerializerHelper.DeserializeXml(XML_FILE);

            Console.WriteLine(i.Date);

            xmlSerializerHelper.SerializeObject();

            Console.ReadLine();
        }
    }
}
