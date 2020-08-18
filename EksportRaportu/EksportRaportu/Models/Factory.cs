using System.Xml.Serialization;

namespace ReportExport.Models
{
    [XmlRoot(ElementName = "Factory")]
    public class Factory
    {

        [XmlElement(ElementName = "ProducedCars")]
        public ProducedCars ProducedCars { get; set; }


        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }
}
