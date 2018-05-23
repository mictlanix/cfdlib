using System;
using System.Xml.Serialization;

namespace Mictlanix.CFDv33 {
	// Too many values to be an enumeration.
	//
	// c_Colonia:			ComercioExteriorEmisorDomicilio.Colonia
	// c_Localidad			ComercioExteriorEmisorDomicilio.Localidad
	// c_Municipio: 		ComercioExteriorEmisorDomicilio.Municipio
	// c_Pais:			ComercioExteriorEmisorDomicilio.Pais, ComercioExteriorPropietario.ResidenciaFiscal, ComercioExteriorReceptorDomicilio.Pais, ComercioExteriorDestinatarioDomicilio.Pais
	// c_FraccionArancelaria:	ComercioExteriorMercancia.FraccionArancelaria

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/ComExt")]
	public enum c_TipoOperacion {
		[XmlEnum ("2")]
		Exportacion = 2
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/ComExt")]
	public enum c_ClavePedimento {
		[XmlEnum ("A1")]
		ImportacionExportacionDefinitiva = 1
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/ComExt")]
	public enum c_UnidadAduana {

		/// <remarks/>
		[XmlEnum ("01")]
		Item01 = 1,

		/// <remarks/>
		[XmlEnum ("02")]
		Item02,

		/// <remarks/>
		[XmlEnum ("03")]
		Item03,

		/// <remarks/>
		[XmlEnum ("04")]
		Item04,

		/// <remarks/>
		[XmlEnum ("05")]
		Item05,

		/// <remarks/>
		[XmlEnum ("06")]
		Item06,

		/// <remarks/>
		[XmlEnum ("07")]
		Item07,

		/// <remarks/>
		[XmlEnum ("08")]
		Item08,

		/// <remarks/>
		[XmlEnum ("09")]
		Item09,

		/// <remarks/>
		[XmlEnum ("10")]
		Item10,

		/// <remarks/>
		[XmlEnum ("11")]
		Item11,

		/// <remarks/>
		[XmlEnum ("12")]
		Item12,

		/// <remarks/>
		[XmlEnum ("13")]
		Item13,

		/// <remarks/>
		[XmlEnum ("14")]
		Item14,

		/// <remarks/>
		[XmlEnum ("15")]
		Item15,

		/// <remarks/>
		[XmlEnum ("16")]
		Item16,

		/// <remarks/>
		[XmlEnum ("17")]
		Item17,

		/// <remarks/>
		[XmlEnum ("18")]
		Item18,

		/// <remarks/>
		[XmlEnum ("19")]
		Item19,

		/// <remarks/>
		[XmlEnum ("20")]
		Item20,

		/// <remarks/>
		[XmlEnum ("21")]
		Item21,

		/// <remarks/>
		[XmlEnum ("99")]
		Item99 = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/ComExt")]
	public enum c_MotivoTraslado {

		/// <remarks/>
		[XmlEnum ("01")]
		Item01 = 1,

		/// <remarks/>
		[XmlEnum ("02")]
		Item02,

		/// <remarks/>
		[XmlEnum ("03")]
		Item03,

		/// <remarks/>
		[XmlEnum ("04")]
		Item04,

		/// <remarks/>
		[XmlEnum ("05")]
		Item05,

		/// <remarks/>
		[XmlEnum ("99")]
		Item99 = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/ComExt")]
	public enum c_INCOTERM {
		CFR,
		CIF,
		CPT,
		CIP,
		DAF,
		DAP,
		DAT,
		DES,
		DEQ,
		DDU,
		DDP,
		EXW,
		FCA,
		FAS,
		FOB,
	}
}
