using ReportExport.Models;
using System;

namespace ReportExport
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            const string XML_FILE = "BmwOriginal.xml";

            XmlSerializerHelper xmlSerializerHelper = new XmlSerializerHelper();
           
            ProductionReport i = xmlSerializerHelper.DeserializeObject(XML_FILE);

            Console.WriteLine(i.Date);


            Console.ReadLine();
        }
    }
}
