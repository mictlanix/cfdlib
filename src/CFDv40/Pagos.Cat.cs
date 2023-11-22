using System;
using System.Xml.Serialization;

namespace Mictlanix.CFDv40 {
	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Pagos")]
	public enum c_TipoCadenaPago {
		[XmlEnum ("01")]
		SPEI = 01
	}



}
