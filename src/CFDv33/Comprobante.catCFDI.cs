using System;
using System.Xml.Serialization;

namespace Mictlanix.CFDv33 {
	// Too many values to be an enumeration.
	//
	// c_Moneda:		Comprobante.Moneda
	// c_CodigoPostal: 	Comprobante.LugarExpedicion
	// c_Pais:		ComprobanteReceptor.ResidenciaFiscal
	// c_ClaveUnidad:	ComprobanteConcepto.ClaveUnidad
	// c_ClaveProdServ:	ComprobanteConcepto.ClaveProdServ, ComprobanteConceptoParte.ClaveProdServ

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_TipoDeComprobante {
		[XmlEnum ("I")]
		Ingreso,
		[XmlEnum ("E")]
		Egreso,
		[XmlEnum ("T")]
		Traslado,
		[XmlEnum ("N")]
		Nomina,
		[XmlEnum ("P")]
		Pago
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_MetodoPago {
		[XmlEnum ("PUE")]
		PagoEnUnaSolaExhibicion,
		[XmlEnum ("PPD")]
		PagoEnParcialidadesODiferido
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_Impuesto {
		[XmlEnum ("001")]
		ISR = 001,
		[XmlEnum ("002")]
		IVA = 002,
		[XmlEnum ("003")]
		IEPS = 003
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_TipoFactor {
		Tasa,
		Cuota,
		Exento
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_FormaPago {
		[XmlEnum ("01")]
		Efectivo = 01,
		[XmlEnum ("02")]
		ChequeNominativo = 02,
		[XmlEnum ("03")]
		TransferenciaElectronicaDeFondos = 03,
		[XmlEnum ("04")]
		TarjetaDeCredito = 04,
		[XmlEnum ("05")]
		MonederoElectronico = 05,
		[XmlEnum ("06")]
		DineroElectronico = 06,
		[XmlEnum ("08")]
		ValesDeDespensa = 08,
		[XmlEnum ("12")]
		DacionEnPago = 12,
		[XmlEnum ("13")]
		PagoPorSubrogacion = 13,
		[XmlEnum ("14")]
		PagoPorConsignacion = 14,
		[XmlEnum ("15")]
		Condonacion = 15,
		[XmlEnum ("17")]
		Compensacion = 17,
		[XmlEnum ("23")]
		Novacion = 23,
		[XmlEnum ("24")]
		Confusion = 24,
		[XmlEnum ("25")]
		RemisionDeDeuda = 25,
		[XmlEnum ("26")]
		PrescripcionOCaducidad = 26,
		[XmlEnum ("27")]
		ASatisfaccionDelAcreedor = 27,
		[XmlEnum ("28")]
		TarjetaDeDebito = 28,
		[XmlEnum ("29")]
		TarjetaDeServicios = 29,
		[XmlEnum ("30")]
		AplicacionDeAnticipos = 30,
		[XmlEnum ("31")]
		IntermediarioPagos = 31,
		[XmlEnum ("99")]
		PorDefinir = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_TipoRelacion {
		[XmlEnum ("01")]
		NotaDeCredito = 01,
		[XmlEnum ("02")]
		NotaDeDebito = 02,
		[XmlEnum ("03")]
		DevolucionDeMercancia = 03,
		[XmlEnum ("04")]
		Sustitucion = 04,
		[XmlEnum ("05")]
		TrasladosDeMercancias = 05,
		[XmlEnum ("06")]
		TrasladosPrevios = 06,
		[XmlEnum ("07")]
		AplicacionDeAnticipo = 07,
		[XmlEnum ("08")]
		PagosEnParcialidades = 08,
		[XmlEnum ("09")]
		PagosDiferidos = 09
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_RegimenFiscal {
		[XmlEnum ("601")]
		GeneralDeLeyPersonasMorales = 601,
		[XmlEnum ("603")]
		PersonasMoralesConFinesNoLucrativos = 603,
		[XmlEnum ("605")]
		SueldosYSalariosEIngresosAsimiladosASalarios = 605,
		[XmlEnum ("606")]
		Arrendamiento = 606,
		[XmlEnum ("608")]
		DemasIngresos = 608,
		[XmlEnum ("609")]
		Consolidacion = 609,
		[XmlEnum ("610")]
		ResidentesEnElExtranjeroSinEstablecimientoPermanenteEnMexico = 610,
		[XmlEnum ("611")]
		IngresosPorDividendos = 611,
		[XmlEnum ("612")]
		PersonasFisicasConActividadesEmpresarialesYProfesionales = 612,
		[XmlEnum ("614")]
		IngresosPorIntereses = 614,
		[XmlEnum ("616")]
		SinObligacionesFiscales = 616,
		[XmlEnum ("620")]
		SociedadesCooperativasDeProduccionQueOptanPorDiferirSusIngresos = 620,
		[XmlEnum ("621")]
		IncorporacionFiscal = 621,
		[XmlEnum ("622")]
		ActividadesAgricolasGanaderasSilvicolasYPesqueras = 622,
		[XmlEnum ("623")]
		OpcionalParaGruposDeSociedades = 623,
		[XmlEnum ("624")]
		Coordinados = 624,
		[XmlEnum ("628")]
		Hidrocarburos = 628,
		[XmlEnum ("607")]
		RegimenDeEnajenacionOAdquisicionDeBienes = 607,
		[XmlEnum ("629")]
		DelosRegimenesFiscalesPreferentesYDeLasEmpresasMultinacionales = 629,
		[XmlEnum ("630")]
		EnajenacionDeAccionesEnBolsaDeValores = 630,
		[XmlEnum ("615")]
		RegimenDeLosIngresosPorObtencionDePremios = 615
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_UsoCFDI {
		[XmlEnum ("G01")]
		AdquisicionDeMercancias = 001,
		[XmlEnum ("G02")]
		DevolucionesDescuentosOBonificaciones = 002,
		[XmlEnum ("G03")]
		GastosEnGeneral = 003,
		[XmlEnum ("I01")]
		Construcciones = 101,
		[XmlEnum ("I02")]
		MobilarioYEquipoDeOficinaPorInversiones = 102,
		[XmlEnum ("I03")]
		EquipoDeTransporte = 103,
		[XmlEnum ("I04")]
		EquipoDeComputoYAccesorios = 104,
		[XmlEnum ("I05")]
		DadosTroquelesMoldesMatricesYHerramental = 105,
		[XmlEnum ("I06")]
		ComunicacionesTelefonicas = 106,
		[XmlEnum ("I07")]
		ComunicacionesSatelitales = 107,
		[XmlEnum ("I08")]
		OtraMaquinariaYEquipo= 108,
		[XmlEnum ("D01")]
		HonorariosMedicosDentalesYGastosHospitalarios = 201,
		[XmlEnum ("D02")]
		GastosMedicosPorIncapacidadODiscapacidad = 202,
		[XmlEnum ("D03")]
		GastosFunerales = 203,
		[XmlEnum ("D04")]
		Donativos = 204,
		[XmlEnum ("D05")]
		InteresesRealesEfectivamentePagadosPorCreditosHipotecarios = 205,
		[XmlEnum ("D06")]
		AportacionesVoluntariasAlSAR = 206,
		[XmlEnum ("D07")]
		PrimasPorSegurosDeGastosMedicos = 207,
		[XmlEnum ("D08")]
		GastosDeTransportacionEscolarObligatoria = 208,
		[XmlEnum ("D09")]
		DepositosEnCuentasParaElAhorroPrimasQueTenganComoBasePlanesDePensiones = 209,
		[XmlEnum ("D10")]
		PagosPorServiciosEducativos = 210,
		[XmlEnum ("P01")]
		PorDefinir = 901
	}
}
