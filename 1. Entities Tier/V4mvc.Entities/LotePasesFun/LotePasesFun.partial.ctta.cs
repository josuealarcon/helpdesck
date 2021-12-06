using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	public partial class LotePasesFun
	{

		#region [ Variables ]

		public string DIVISION { get; set; }
		public string ACRONIMO { get; set; }

		public string DIVCOD { get; set; }

		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: EMPRESA_FUNC.
		/// </summary>
		public String EMPRESA_FUNC { get; set; }

		/// <summary>
		/// Gets or sets el valor de: NOMBRE_EMPRESA_FUNC.
		/// </summary>
		public String NOMBRE_EMPRESA_FUNC { get; set; }

		/// <summary>
		/// Gets or sets el valor de: AUTOR.
		/// </summary>
		public String AUTOR { get; set; }

		public Boolean PUEDE_PEDIR_PASE { get; set; }

		public Nullable<Int32> CUENTA_VISITAS { get; set; }

		public String CONDUCE_TXT { get; set; }

		public Boolean CONDUCE { get; set; }

		public Boolean HOTEL { get; set; }

		public String HOTEL_TXT { get; set; }

		public String PERIODO { get; set; }

		public Nullable<Int32> LIMITEPASESV { get; set; }

		public String EXAMEN { get; set; }

		public Nullable<Int32> PASES_ACTIVOS { get; set; }

		public String VALIDADO { get; set; }

		public String COMUN { get; set; }

		public String EMPRESA_FINIQ { get; set; }

		public String NOMBRE_EMPRESA_FINIQ { get; set; }

		public String EMPRESA_NOMINA { get; set; }

		public String NOMBRE_EMPRESA_NOMINA { get; set; }

		public String EMPRESA_FINIQ_NOMINA { get; set; }

		public String NOMBRE_EMPRESA_FINIQ_NOMINA { get; set; }

		public String FECNACIM { get; set; }

		public String FECNACIM_PICKER
		{
			get
			{
				return (Utils.Fec_User(FECNACIM, Utils.Formato_Fecha.Guion));
			}
		}

		public Nullable<Int32> IDCATEGORIACTTA { get; set; }

		public Nullable<Int32> IDSUBCATEGORIACCTTA { get; set; }

		public String SUBCATEGORIA_TXT { get; set; }

		public String CATEGORIA_TXT { get; set; }

		public String PATENTE { get; set; }

		public String MARCA { get; set; }

		public String MODELO { get; set; }

		public String ANIO { get; set; }

		public String EMPRESA_VEH { get; set; }

		public String NOMBRE_EMPRESA { get; set; }

		public String NOMINA { get; set; }

		public ObservableCollection<Local> ZONAS_CONDUCCION { get; set; }

		public String TIPOVEHI_TXT { get; set; }

		public Nullable<Int32> ID_PASE { get; set; }

		public String ID_EMPRESA { get; set; }

		public Boolean CASINO { get; set; }

		public Boolean CERTT { get; set; }
		public int CERT { get; set; }
		public int CONDUC { get; set; }
		public string FECHA { get; set; }
		public string ADMINISTRADOR { get; set; }
		public string ESTADO_LOTE { get; set; }
		public Workers SOLICITANTE { get; set; }
		public int LOTENUM { get; set; }
		public string LOTEFINICIO { get; set; }
		public string LOTEFINICIO_LETRA
		{
			get
			{
				return (Utils.Fec_User(LOTEFINICIO, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public string LOTEFFINAL { get; set; }
		public string LOTEFFINAL_LETRA
		{
			get
			{
				return (Utils.Fec_User(LOTEFFINAL, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public string LOTEFECPROCESO { get; set; }
		public string LOTEFECPROCESO_LETRA
		{
			get
			{
				return (Utils.Fec_User(LOTEFECPROCESO, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public string LOTEFECHA { get; set; }
		public string LOTEFECHA_LETRA
		{
			get
			{
				return (Utils.Fec_User(LOTEFECHA, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public bool EXISTE { get; set; }
		public string NOMBRES { get; set; }
		public string APELLIDOS { get; set; }
		public string DESC_ESTADO { get; set; }
		public string RUTLOTE_FORMATO
		{
			get
			{
				return (Utils.strRut(RUTLOTE));
			}
		}
		public String IDEMPRESA { get; set; }
		
		#endregion

	}
}
