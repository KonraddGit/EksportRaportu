using System;
using System.Xml;
using System.Xml.Serialization;

namespace EksportRaportu
{
    public class DeserializeXml
    {
        public DeserializeXml()
        {
            string path = "BmwOriginal.xml";

            XmlSerializer ser = new XmlSerializer(typeof(Cars));
            Cars cars;

            using (XmlReader reader = XmlReader.Create(path))
            {
                cars = (Cars)ser.Deserialize(reader);
            }

            Console.WriteLine(cars.Items);
        }
    }
}

