using System;
using System.Xml;
using System.Xml.Serialization;

namespace Mictlanix.CFDv2
{
    public partial class Comprobante
    {
        XmlSerializerNamespaces xmlns;

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns
        {
            get
            {
                if (xmlns == null)
                {
                    xmlns = new XmlSerializerNamespaces(new XmlQualifiedName[] {
                        new XmlQualifiedName("", "http://www.sat.gob.mx/cfd/2"),
                        new XmlQualifiedName("xsi", "http://www.w3.org/2001/XMLSchema-instance")
                    });
                }

                return xmlns;
            }
            set { xmlns = value; }
        }
        
        [XmlAttributeAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "http://www.sat.gob.mx/cfd/2 http://www.sat.gob.mx/sitio_internet/cfd/2/cfdv2.xsd";
    }
}
