using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReportExport.Models
{
    [XmlRoot(ElementName = "Features")]
    public class Features
    {
        [XmlElement(ElementName = "Feature")]
        public List<Feature> Feature { get; set; }
    }
}
