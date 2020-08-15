using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReportExport.Models
{
    [XmlRoot(ElementName = "ProducedCars")]
    public class ProducedCars
    {
        [XmlElement(ElementName = "Car")]
        public List<Car> Car { get; set; }
    }
}
