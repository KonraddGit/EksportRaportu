using System.Xml.Serialization;

namespace ReportExport.Models
{
    [XmlRoot(ElementName = "Factories")]
    public class Factories
    {
        [XmlElement(ElementName = "Factory")]
        public Factory Factory { get; set; }
    }
}
