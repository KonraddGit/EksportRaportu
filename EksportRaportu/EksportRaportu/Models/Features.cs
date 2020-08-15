using System.Xml.Serialization;

namespace ReportExport.Models
{
    public class Features
    {
        [XmlAttribute("Code")]
        public string Code { get; set; }
        public string Feature { get; set; }
    }
}
