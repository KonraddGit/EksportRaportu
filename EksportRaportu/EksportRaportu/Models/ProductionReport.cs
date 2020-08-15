using System.Xml.Serialization;

namespace ReportExport.Models
{
    [XmlRoot(ElementName = "ProductionReport")]
    public class ProductionReport
    {
        [XmlElement(ElementName = "Factories")]
        public Factories Factories { get; set; }

        [XmlAttribute(AttributeName = "Manufacturer")]
        public string Manufacturer { get; set; }

        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }
    }

}