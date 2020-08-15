using System.Xml.Serialization;

namespace ReportExport.Models
{
    [XmlRoot(ElementName = "Car")]
    public class Car
    {
        [XmlElement(ElementName = "ProductionYear")]
        public string ProductionYear { get; set; }
        [XmlElement(ElementName = "Model")]
        public string Model { get; set; }
        [XmlElement(ElementName = "Features")]
        public Features Features { get; set; }
        [XmlAttribute(AttributeName = "VIN")]
        public string VIN { get; set; }
    }
}
