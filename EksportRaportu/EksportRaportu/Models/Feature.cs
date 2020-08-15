using System.Xml.Serialization;

namespace ReportExport.Models
{
    [XmlRoot(ElementName = "Feature")]
    public class Feature
    {
        [XmlAttribute(AttributeName = "Code")]
        public string Code { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
