using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterCapstone.FormApp.Models
{
    [Serializable()]
    [XmlRoot("Package")]
    public class Package
    {
        [XmlElement("Shape")]
        public string Shape { get; set; }
    }
}
