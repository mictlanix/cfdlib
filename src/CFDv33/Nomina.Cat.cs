using System;
using System.Xml.Serialization;

namespace Mictlanix.CFDv33 {

	[Serializable]
	[XmlType (AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
	public enum NominaReceptorSindicalizado {
		[XmlEnum ("Si")]
		Si,
		[XmlEnum ("No")]
		No
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoNomina {
		[XmlEnum ("O")]
		Ordinaria,
		[XmlEnum ("E")]
		Extraordinaria
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoIncapacidad {
		[XmlEnum ("01")]
		RiesgoDeTrabajo = 1,
		[XmlEnum ("02")]
		EnfermedadEnGeneral = 2,
		[XmlEnum ("03")]
		Maternidad = 3
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_OrigenRecurso {
		[XmlEnum ("IP")]
		IngresosPropios,
		[XmlEnum ("IF")]
		IngresosFederales,
		[XmlEnum ("IM")]
		IngresosMixtos
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_RiesgoPuesto {
		[XmlEnum ("1")]
		ClaseI = 1,
		[XmlEnum ("2")]
		ClaseII = 2,
		[XmlEnum ("3")]
		ClaseIII = 3,
		[XmlEnum ("4")]
		ClaseIV = 4,
		[XmlEnum ("5")]
		ClaseV = 5,
		[XmlEnum ("99")]
		NoAplica = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoContrato {
		[XmlEnum ("01")]
		ContratoDeTrabajoPorTiempoIndeterminado = 01,
		[XmlEnum ("02")]
		ContratoDeTrabajoParaObraDeterminada = 02,
		[XmlEnum ("03")]
		ContratoDeTrabajoPorTiempoDeterminado = 03,
		[XmlEnum ("04")]
		ContratoDeTrabajoPorTemporada = 04,
		[XmlEnum ("05")]
		ContratoDeTrabajoSujetoAPrueba = 05,
		[XmlEnum ("06")]
		ContratoDeTrabajoConCapacitacionInicial = 06,
		[XmlEnum ("07")]
		ModalidadDeContratacionPorPagoDeHoraLaborada = 07,
		[XmlEnum ("08")]
		ModalidadDeTrabajoPorComisionLaboral = 08,
		[XmlEnum ("09")]
		ModalidadesDeContratacionDondeNoExisteRelacionDeTrabajo = 09,
		[XmlEnum ("10")]
		JubilacionPensionRetiro = 10,
		[XmlEnum ("99")]
		OtroContrato = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoHoras {
		[XmlEnum ("01")]
		Dobles = 01,
		[XmlEnum ("02")]
		Triples = 02,
		[XmlEnum ("03")]
		Simples = 03
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoOtroPago {
		[XmlEnum ("001")]
		ReintegroDeISRPagadoEnExceso = 001,
		[XmlEnum ("002")]
		SubsidioParaElEmpleo = 002,
		[XmlEnum ("003")]
		Viaticos = 003,
		[XmlEnum ("004")]
		AplicacionDeSaldoAFavorPorCompensacionAnual = 004,
		[XmlEnum ("005")]
		ReintegroDeISRRetenidoEnExceso = 005,
		[XmlEnum ("999")]
		PagosDistintosALosListados = 999
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoJornada {
		[XmlEnum ("01")]
		Diurna = 01,
		[XmlEnum ("02")]
		Nocturna = 02,
		[XmlEnum ("03")]
		Mixta = 03,
		[XmlEnum ("04")]
		PorHora = 04,
		[XmlEnum ("05")]
		Reducida = 05,
		[XmlEnum ("06")]
		Continuada = 06,
		[XmlEnum ("07")]
		Partida = 07,
		[XmlEnum ("08")]
		PorTurnos = 08,
		[XmlEnum ("99")]
		OtraJornada = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoRegimen {
		[XmlEnum ("02")]
		Sueldos = 02,
		[XmlEnum ("03")]
		Jubilados = 03,
		[XmlEnum ("04")]
		Pensionados = 04,
		[XmlEnum ("05")]
		AsimiladosMiembrosSociedadesCooperativasProduccion = 05,
		[XmlEnum ("06")]
		AsimiladosIntegrantesSociedadesAsociacionesCiviles = 06,
		[XmlEnum ("07")]
		AsimiladosMiembrosConsejos = 07,
		[XmlEnum ("08")]
		AsimiladosComisionistas = 08,
		[XmlEnum ("09")]
		AsimiladosHonorarios = 09,
		[XmlEnum ("10")]
		AsimiladosAcciones = 10,
		[XmlEnum ("11")]
		AsimiladosOtros = 11,
		[XmlEnum ("12")]
		JubiladosOPensionados = 12,
		[XmlEnum ("99")]
		OtroRegimen = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_PeriodicidadPago {
		[XmlEnum ("01")]
		Diario = 01,
		[XmlEnum ("02")]
		Semanal = 02,
		[XmlEnum ("03")]
		Catorcenal = 03,
		[XmlEnum ("04")]
		Quincenal = 04,
		[XmlEnum ("05")]
		Mensual = 05,
		[XmlEnum ("06")]
		Bimestral = 06,
		[XmlEnum ("07")]
		UnidadObra = 07,
		[XmlEnum ("08")]
		Comision = 08,
		[XmlEnum ("09")]
		PrecioAlzado = 09,
		[XmlEnum ("10")]
		Decenal = 10,
		[XmlEnum ("99")]
		OtraPeriodicidad = 99
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
	public enum c_Estado {
		AGU,
		BCN,
		BCS,
		CAM,
		CHP,
		CHH,
		COA,
		COL,
		DIF,
		DUR,
		GUA,
		GRO,
		HID,
		JAL,
		MEX,
		MIC,
		MOR,
		NAY,
		NLE,
		OAX,
		PUE,
		QUE,
		ROO,
		SLP,
		SIN,
		SON,
		TAB,
		TAM,
		TLA,
		VER,
		YUC,
		ZAC,
		AL,
		AK,
		AZ,
		AR,
		CA,
		NC,
		SC,
		CO,
		CT,
		ND,
		SD,
		DE,
		FL,
		GA,
		HI,
		ID,
		IL,
		IN,
		IA,
		KS,
		KY,
		LA,
		ME,
		MD,
		MA,
		MI,
		MN,
		MS,
		MO,
		MT,
		NE,
		NV,
		NJ,
		NY,
		NH,
		NM,
		OH,
		OK,
		OR,
		PA,
		RI,
		TN,
		TX,
		UT,
		VT,
		VA,
		WV,
		WA,
		WI,
		WY,
		ON,
		QC,
		NS,
		NB,
		MB,
		BC,
		PE,
		SK,
		AB,
		NL,
		NT,
		YT,
		UN
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoPercepcion {
		[XmlEnum ("001")]
		SueldosSalariosRayasYJornales = 001,
		[XmlEnum ("002")]
		GratificacionAnualAguinaldo = 002,
		[XmlEnum ("003")]
		ParticipacionDeLosTrabajadoresEnLasUtilidadesPTU = 003,
		[XmlEnum ("004")]
		ReembolsoDeGastosMedicosDentalesYHospitalarios = 004,
		[XmlEnum ("005")]
		FondoDeAhorro = 005,
		[XmlEnum ("006")]
		CajaDeAhorro = 006,
		[XmlEnum ("009")]
		ContribucionesACargoDelTrabajadorPagadasPorElPatron = 009,
		[XmlEnum ("010")]
		PremiosPorPuntualidad = 010,
		[XmlEnum ("011")]
		PrimadeSeguroDeVida = 011,
		[XmlEnum ("012")]
		SegurodeGastosMedicosMayores = 012,
		[XmlEnum ("013")]
		CuotasSindicalesPagadasPorElPatron = 013,
		[XmlEnum ("014")]
		SubsidiosPorIncapacidad = 014,
		[XmlEnum ("015")]
		BecasParaTrabajadoresYOHijos = 015,
		[XmlEnum ("019")]
		HorasExtra = 019,
		[XmlEnum ("020")]
		PrimaDominical = 020,
		[XmlEnum ("021")]
		PrimaVacacional = 021,
		[XmlEnum ("022")]
		PrimaPorAntiguedad = 022,
		[XmlEnum ("023")]
		PagosPorSeparacion = 023,
		[XmlEnum ("024")]
		SeguroDeRetiro = 024,
		[XmlEnum ("025")]
		Indemnizaciones = 025,
		[XmlEnum ("026")]
		ReembolsoPorFuneral = 026,
		[XmlEnum ("027")]
		CuotasDeSeguridadSocialPagadasPorElPatron = 027,
		[XmlEnum ("028")]
		Comisiones = 028,
		[XmlEnum ("029")]
		ValesDeDespensa = 029,
		[XmlEnum ("030")]
		ValesDeRestaurante = 030,
		[XmlEnum ("031")]
		ValesDeGasolina = 031,
		[XmlEnum ("032")]
		ValesDeRopa = 032,
		[XmlEnum ("033")]
		AyudaParaRenta = 033,
		[XmlEnum ("034")]
		AyudaParaArticulosEscolares = 034,
		[XmlEnum ("035")]
		AyudaParaAnteojos = 035,
		[XmlEnum ("036")]
		AyudaParaTransporte = 036,
		[XmlEnum ("037")]
		AyudaParaGastosDeFuneral = 037,
		[XmlEnum ("038")]
		OtrosIngresosPorSalarios = 038,
		[XmlEnum ("039")]
		JubilacionesPensionesOHaberesDeRetiro = 039,
		[XmlEnum ("044")]
		JubilacionesPensionesOHaberesDeRetiroEnParcialidades = 044,
		[XmlEnum ("045")]
		IngresosEnAccionesOTitulosValorQueRepresentanBienes = 045,
		[XmlEnum ("046")]
		IngresosAsimiladosASalarios = 046,
		[XmlEnum ("047")]
		Alimentacion = 047,
		[XmlEnum ("048")]
		Habitacion = 048,
		[XmlEnum ("049")]
		PremiosPorAsistencia = 049,
		[XmlEnum ("050")]
		Viaticos = 050
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_Banco {
		[XmlEnum ("002")]
		BANAMEX = 002,
		[XmlEnum ("006")]
		BANCOMEXT = 006,
		[XmlEnum ("009")]
		BANOBRAS = 009,
		[XmlEnum ("012")]
		BBVA_BANCOMER = 012,
		[XmlEnum ("014")]
		SANTANDER = 014,
		[XmlEnum ("019")]
		BANJERCITO = 019,
		[XmlEnum ("021")]
		HSBC = 021,
		[XmlEnum ("030")]
		BAJIO = 030,
		[XmlEnum ("032")]
		IXE = 032,
		[XmlEnum ("036")]
		INBURSA = 036,
		[XmlEnum ("037")]
		INTERACCIONES = 037,
		[XmlEnum ("042")]
		MIFEL = 042,
		[XmlEnum ("044")]
		SCOTIABANK = 044,
		[XmlEnum ("058")]
		BANREGIO = 058,
		[XmlEnum ("059")]
		INVEX = 059,
		[XmlEnum ("060")]
		BANSI = 060,
		[XmlEnum ("062")]
		AFIRME = 062,
		[XmlEnum ("072")]
		BANORTE_IXE = 072,
		[XmlEnum ("102")]
		THE_ROYAL_BANK = 102,
		[XmlEnum ("103")]
		AMERICAN_EXPRESS = 103,
		[XmlEnum ("106")]
		BAMSA = 106,
		[XmlEnum ("108")]
		TOKYO = 108,
		[XmlEnum ("110")]
		JP_MORGAN = 110,
		[XmlEnum ("112")]
		BMONEX = 112,
		[XmlEnum ("113")]
		VE_POR_MAS = 113,
		[XmlEnum ("116")]
		ING = 116,
		[XmlEnum ("124")]
		DEUTSCHE = 124,
		[XmlEnum ("126")]
		CREDIT_SUISSE = 126,
		[XmlEnum ("127")]
		AZTECA = 127,
		[XmlEnum ("128")]
		AUTOFIN = 128,
		[XmlEnum ("129")]
		BARCLAYS = 129,
		[XmlEnum ("130")]
		COMPARTAMOS = 130,
		[XmlEnum ("131")]
		BANCO_FAMSA = 131,
		[XmlEnum ("132")]
		BMULTIVA = 132,
		[XmlEnum ("133")]
		ACTINVER = 133,
		[XmlEnum ("134")]
		WAL_MART = 134,
		[XmlEnum ("135")]
		NAFIN = 135,
		[XmlEnum ("136")]
		INTERCAM_BANCO = 136,
		[XmlEnum ("137")]
		BANCOPPEL = 137,
		[XmlEnum ("138")]
		ABC_CAPITAL = 138,
		[XmlEnum ("139")]
		UBS_BANK = 139,
		[XmlEnum ("140")]
		CONSUBANCO = 140,
		[XmlEnum ("141")]
		VOLKSWAGEN = 141,
		[XmlEnum ("143")]
		CIBANCO = 143,
		[XmlEnum ("145")]
		BBASE = 145,
		[XmlEnum ("147")]
		BANKAOOL = 147,
		[XmlEnum ("148")]
		PAGATODO = 148,
		[XmlEnum ("149")]
		FORJADORES = 149,
		[XmlEnum ("150")]
		INMOBILIARIO = 150,
		[XmlEnum ("151")]
		DONDÉ = 151,
		[XmlEnum ("152")]
		BANCREA = 152,
		[XmlEnum ("153")]
		PROGRESO = 153,
		[XmlEnum ("154")]
		BANCO_FINTERRA = 154,
		[XmlEnum ("155")]
		ICBC = 155,
		[XmlEnum ("156")]
		SABADELL = 156,
		[XmlEnum ("157")]
		SHINHAN = 157,
		[XmlEnum ("158")]
		MIZUHO_BANK = 158,
		[XmlEnum ("159")]
		BANK_OF_CHINA = 159,
		[XmlEnum ("160")]
		BANCO_S3 = 160,
		[XmlEnum ("166")]
		BANSEFI = 166,
		[XmlEnum ("168")]
		HIPOTECARIA_FEDERAL = 168,
		[XmlEnum ("600")]
		MONEXCB = 600,
		[XmlEnum ("601")]
		GBM = 601,
		[XmlEnum ("602")]
		MASARI = 602,
		[XmlEnum ("605")]
		VALUE = 605,
		[XmlEnum ("606")]
		ESTRUCTURADORES = 606,
		[XmlEnum ("607")]
		TIBER = 607,
		[XmlEnum ("608")]
		VECTOR = 608,
		[XmlEnum ("610")]
		B_B = 610,
		[XmlEnum ("614")]
		ACCIVAL = 614,
		[XmlEnum ("615")]
		MERRILL_LYNCH = 615,
		[XmlEnum ("616")]
		FINAMEX = 616,
		[XmlEnum ("617")]
		VALMEX = 617,
		[XmlEnum ("618")]
		UNICA = 618,
		[XmlEnum ("619")]
		MAPFRE = 619,
		[XmlEnum ("620")]
		PROFUTURO = 620,
		[XmlEnum ("621")]
		CB_ACTINVER = 621,
		[XmlEnum ("622")]
		OACTIN = 622,
		[XmlEnum ("623")]
		SKANDIA_VIDA = 623,
		[XmlEnum ("626")]
		CBDEUTSCHE = 626,
		[XmlEnum ("627")]
		ZURICH = 627,
		[XmlEnum ("628")]
		ZURICHVI = 628,
		[XmlEnum ("629")]
		SU_CASITA = 629,
		[XmlEnum ("630")]
		CB_INTERCAM = 630,
		[XmlEnum ("631")]
		CI_BOLSA = 631,
		[XmlEnum ("632")]
		BULLTICK_CB = 632,
		[XmlEnum ("633")]
		STERLING = 633,
		[XmlEnum ("634")]
		FINCOMUN = 634,
		[XmlEnum ("636")]
		HDI_SEGUROS = 636,
		[XmlEnum ("637")]
		ORDER = 637,
		[XmlEnum ("638")]
		AKALA = 638,
		[XmlEnum ("640")]
		CB_JPMORGAN = 640,
		[XmlEnum ("642")]
		REFORMA = 642,
		[XmlEnum ("646")]
		STP = 646,
		[XmlEnum ("647")]
		TELECOMM = 647,
		[XmlEnum ("648")]
		EVERCORE = 648,
		[XmlEnum ("649")]
		SKANDIA_FONDOS = 649,
		[XmlEnum ("651")]
		SEGMTY = 651,
		[XmlEnum ("652")]
		ASEA = 652,
		[XmlEnum ("653")]
		KUSPIT = 653,
		[XmlEnum ("655")]
		SOFIEXPRESS = 655,
		[XmlEnum ("656")]
		UNAGRA = 656,
		[XmlEnum ("659")]
		OPCIONES_EMPRESARIALES_DEL_NOROESTE = 659,
		[XmlEnum ("670")]
		LIBERTAD = 670,
		[XmlEnum ("901")]
		CLS = 901,
		[XmlEnum ("902")]
		INDEVAL = 902
	}

	[Serializable]
	[XmlType (Namespace = "http://www.sat.gob.mx/sitio_internet/cfd/catalogos/Nomina")]
	public enum c_TipoDeduccion {
		[XmlEnum ("001")]
		SeguridadSocial = 001,
		[XmlEnum ("002")]
		ISR = 002,
		[XmlEnum ("003")]
		AportacionesARetiro = 003,
		[XmlEnum ("004")]
		Otros = 004,
		[XmlEnum ("005")]
		AportacionesAFondoDeVivienda = 005,
		[XmlEnum ("006")]
		DescuentoPorIncapacidad = 006,
		[XmlEnum ("007")]
		PensionAlimenticia = 007,
		[XmlEnum ("008")]
		Renta = 008,
		[XmlEnum ("009")]
		PrestamosProvenientesDelINFONAVIT = 009,
		[XmlEnum ("010")]
		PagoPorCreditoDeVivienda = 010,
		[XmlEnum ("011")]
		PagoDeAbonosINFONACOT = 011,
		[XmlEnum ("012")]
		AnticipoDeSalarios = 012,
		[XmlEnum ("013")]
		PagosHechosConExcesoAlTrabajador = 013,
		[XmlEnum ("014")]
		Errores = 014,
		[XmlEnum ("015")]
		Perdidas = 015,
		[XmlEnum ("016")]
		Averias = 016,
		[XmlEnum ("017")]
		AdquisicionDeArticulosProducidosPorLaEmpresaOEstablecimiento = 017,
		[XmlEnum ("018")]
		CuotasParaLaConstitucionYFomentoDeSociedadesCooperativasYDeCajasDeAhorro = 018,
		[XmlEnum ("019")]
		Cuotassindicales = 019,
		[XmlEnum ("020")]
		Ausencia = 020,
		[XmlEnum ("021")]
		CuotasObreroPatronales = 021,
		[XmlEnum ("022")]
		ImpuestosLocales = 022,
		[XmlEnum ("023")]
		AportacionesVoluntarias = 023,
		[XmlEnum ("024")]
		AjusteEnGratificacionAnualExento = 024,
		[XmlEnum ("025")]
		AjusteEnGratificacionAnualGravado = 025,
		[XmlEnum ("026")]
		AjusteEnParticipacionDeLosTrabajadoresEnLasUtilidadesPTUExento = 026,
		[XmlEnum ("027")]
		AjusteEnParticipacionDeLosTrabajadoresEnLasUtilidadesPTUGravado = 027,
		[XmlEnum ("028")]
		AjusteEnReembolsoDeGastosMedicosDentalesYHospitalariosExento = 028,
		[XmlEnum ("029")]
		AjusteEnFondodeahorroExento = 029,
		[XmlEnum ("030")]
		AjusteEnCajadeahorroExento = 030,
		[XmlEnum ("031")]
		AjusteEnContribucionesaCargoDelTrabajadorPagadasPorElPatronExento = 031,
		[XmlEnum ("032")]
		AjusteEnPremiosPorPuntualidadGravado = 032,
		[XmlEnum ("033")]
		AjusteEnPrimadeSeguroDeVidaExento = 033,
		[XmlEnum ("034")]
		AjusteEnSegurodeGastosMedicosMayoresExento = 034,
		[XmlEnum ("035")]
		AjusteEnCuotasSindicalesPagadasporelPatronExento = 035,
		[XmlEnum ("036")]
		AjusteEnSubsidiosPorIncapacidadExento = 036,
		[XmlEnum ("037")]
		AjusteEnBecasParaTrabajadoresYOHijosExento = 037,
		[XmlEnum ("038")]
		AjusteEnHorasExtraExento = 038,
		[XmlEnum ("039")]
		AjusteEnHorasExtraGravado = 039,
		[XmlEnum ("040")]
		AjusteEnPrimaDominicalExento = 040,
		[XmlEnum ("041")]
		AjusteEnPrimaDominicalGravado = 041,
		[XmlEnum ("042")]
		AjusteEnPrimaVacacionalExento = 042,
		[XmlEnum ("043")]
		AjusteEnPrimaVacacionalGravado = 043,
		[XmlEnum ("044")]
		AjusteEnPrimaPorAntiguedadExento = 044,
		[XmlEnum ("045")]
		AjusteEnPrimaPorAntiguedadGravado = 045,
		[XmlEnum ("046")]
		AjusteEnPagosPorSeparacionExento = 046,
		[XmlEnum ("047")]
		AjusteEnPagosPorSeparacionGravado = 047,
		[XmlEnum ("048")]
		AjusteEnSeguroDeRetiroExento = 048,
		[XmlEnum ("049")]
		AjusteEnIndemnizacionesExento = 049,
		[XmlEnum ("050")]
		AjusteEnIndemnizacionesGravado = 050,
		[XmlEnum ("051")]
		AjusteEnReembolsoPorFuneralExento = 051,
		[XmlEnum ("052")]
		AjusteEnCuotasDeSeguridadSocialPagadasPorelPatronExento = 052,
		[XmlEnum ("053")]
		AjusteEnComisionesGravado = 053,
		[XmlEnum ("054")]
		AjusteEnValesDeDespensaExento = 054,
		[XmlEnum ("055")]
		AjusteEnValesDeRestauranteExento = 055,
		[XmlEnum ("056")]
		AjusteEnValesDeGasolinaExento = 056,
		[XmlEnum ("057")]
		AjusteEnValesDeRopaExento = 057,
		[XmlEnum ("058")]
		AjusteEnAyudaParaRentaExento = 058,
		[XmlEnum ("059")]
		AjusteEnAyudaParaArticulosEscolaresExento = 059,
		[XmlEnum ("060")]
		AjusteEnAyudaParaAnteojosExento = 060,
		[XmlEnum ("061")]
		AjusteEnAyudaParaTransporteExento = 061,
		[XmlEnum ("062")]
		AjusteEnAyudaParaGastosDeFuneralExento = 062,
		[XmlEnum ("063")]
		AjusteEnOtrosIngresosPorSalariosExento = 063,
		[XmlEnum ("064")]
		AjusteEnOtrosIngresosPorSalariosGravado = 064,
		[XmlEnum ("065")]
		AjusteEnJubilacionesPensionesOHaberesdeRetiroExento = 065,
		[XmlEnum ("066")]
		AjusteEnJubilacionesPensionesOHaberesdeRetiroGravado = 066,
		[XmlEnum ("067")]
		AjusteEnPagosPorseparacionAcumulable = 067,
		[XmlEnum ("068")]
		AjusteEnPagosPorseparacionNoacumulable = 068,
		[XmlEnum ("069")]
		AjusteEnJubilacionesPensionesOHaberesdeRetiroAcumulable = 069,
		[XmlEnum ("070")]
		AjusteEnJubilacionesPensionesOHaberesdeRetiroNoacumulable = 070,
		[XmlEnum ("071")]
		AjusteEnSubsidioParaElEmpleo = 071,
		[XmlEnum ("072")]
		AjusteEnIngresosEnAccionesOTitulosValorQueRepresentanBienesExento = 072,
		[XmlEnum ("073")]
		AjusteEnIngresosEnAccionesOTitulosValorQueRepresentanBienesGravado = 073,
		[XmlEnum ("074")]
		AjusteEnAlimentacionExento = 074,
		[XmlEnum ("075")]
		AjusteEnAlimentacionGravado = 075,
		[XmlEnum ("076")]
		AjusteEnHabitacionExento = 076,
		[XmlEnum ("077")]
		AjusteEnHabitacionGravado = 077,
		[XmlEnum ("078")]
		AjusteEnPremiosPorAsistencia = 078,
		[XmlEnum ("079")]
		AjusteEnPagosDistintosALosListados = 079,
		[XmlEnum ("080")]
		AjusteEnViaticosGravados = 080,
		[XmlEnum ("081")]
		AjusteEnViaticos = 081,
		[XmlEnum ("082")]
		AjusteEnFondoDeAhorroGravado = 082,
		[XmlEnum ("083")]
		AjusteEnCajaDeAhorroGravado = 083,
		[XmlEnum ("084")]
		AjusteEnPrimaDeSegurodevidaGravado = 084,
		[XmlEnum ("085")]
		AjusteEnSeguroDeGastosMedicosMayoresGravado = 085,
		[XmlEnum ("086")]
		AjusteEnSubsidiosPorIncapacidadGravado = 086,
		[XmlEnum ("087")]
		AjusteEnBecasParaTrabajadoresYOHijosGravado = 087,
		[XmlEnum ("088")]
		AjusteEnSeguroDeRetiroGravado = 088,
		[XmlEnum ("089")]
		AjusteEnValesDeDespensaGravado = 089,
		[XmlEnum ("090")]
		AjusteEnValesDeRestauranteGravado = 090,
		[XmlEnum ("091")]
		AjusteEnValesDeGasolinaGravado = 091,
		[XmlEnum ("092")]
		AjusteEnValesDeRopaGravado = 092,
		[XmlEnum ("093")]
		AjusteEnAyudaParaRentaGravado = 093,
		[XmlEnum ("094")]
		AjusteEnAyudaParaArticulosEscolaresGravado = 094,
		[XmlEnum ("095")]
		AjusteEnAyudaParaAnteojosGravado = 095,
		[XmlEnum ("096")]
		AjusteEnAyudaParaTransporteGravado = 096,
		[XmlEnum ("097")]
		AjusteEnAyudaParaGastosDeFuneralGravado = 097,
		[XmlEnum ("098")]
		AjusteAIngresosAsimiladosASalariosGravados = 098,
		[XmlEnum ("099")]
		AjusteAIngresosPorSueldosYSalariosGravados = 099,
		[XmlEnum ("100")]
		AjusteEnViaticosExentos = 100,
		[XmlEnum ("101")]
		ISRRetenidoDeEjercicioAnterior = 101
	}
}
