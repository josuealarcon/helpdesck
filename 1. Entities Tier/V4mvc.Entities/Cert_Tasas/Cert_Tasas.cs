
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Cert_Tasas
    {
        #region [ Variables ]
        
    	private String m_validado;
	
    	private String m_fechasube;
	
    	private String m_empresa;
	
    	private String m_horasube;
	
    	private Nullable<Int32> m_dias_accidentes;
	
    	private Nullable<Int32> m_dias_fatales;
	
    	private String m_usuario;
	
    	private String m_certfecha;
	
    	private String m_periodo;
	
    	private String m_certhora;
	
    	private Nullable<Int64 > m_folio;
	
    	private String m_certusuario;
	
    	private Nullable<Int32> m_nro_accidentes;
	
    	private Nullable<Int32> m_dias_enfermedad;
	
    	private String m_observacion;
	
    	private Nullable<Int32> m_total_perdidos;
	
    	private Nullable<Guid> m_id;
	
    	private Nullable<Int32> m_dias_incapacidad;
	
    	private Nullable<Int32> m_nro_enfermedad;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Cert_Tasas.
        /// </summary>
        public Cert_Tasas()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: VALIDADO.
		/// </summary>
		public String VALIDADO
		{
			get { return m_validado; }
			set
			{
				if (m_validado != value)
				{
					m_validado = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FECHASUBE.
		/// </summary>
		public String FECHASUBE
		{
			get { return m_fechasube; }
			set
			{
				if (m_fechasube != value)
				{
					m_fechasube = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: EMPRESA.
		/// </summary>
		public String EMPRESA
		{
			get { return m_empresa; }
			set
			{
				if (m_empresa != value)
				{
					m_empresa = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: HORASUBE.
		/// </summary>
		public String HORASUBE
		{
			get { return m_horasube; }
			set
			{
				if (m_horasube != value)
				{
					m_horasube = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DIAS_ACCIDENTES.
		/// </summary>
		public Nullable<Int32> DIAS_ACCIDENTES
		{
			get { return m_dias_accidentes; }
			set
			{
				if (m_dias_accidentes != value)
				{
					m_dias_accidentes = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DIAS_FATALES.
		/// </summary>
		public Nullable<Int32> DIAS_FATALES
		{
			get { return m_dias_fatales; }
			set
			{
				if (m_dias_fatales != value)
				{
					m_dias_fatales = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: USUARIO.
		/// </summary>
		public String USUARIO
		{
			get { return m_usuario; }
			set
			{
				if (m_usuario != value)
				{
					m_usuario = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CERTFECHA.
		/// </summary>
		public String CERTFECHA
		{
			get { return m_certfecha; }
			set
			{
				if (m_certfecha != value)
				{
					m_certfecha = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PERIODO.
		/// </summary>
		public String PERIODO
		{
			get { return m_periodo; }
			set
			{
				if (m_periodo != value)
				{
					m_periodo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CERTHORA.
		/// </summary>
		public String CERTHORA
		{
			get { return m_certhora; }
			set
			{
				if (m_certhora != value)
				{
					m_certhora = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FOLIO.
		/// </summary>
		public Nullable<Int64 > FOLIO
		{
			get { return m_folio; }
			set
			{
				if (m_folio != value)
				{
					m_folio = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CERTUSUARIO.
		/// </summary>
		public String CERTUSUARIO
		{
			get { return m_certusuario; }
			set
			{
				if (m_certusuario != value)
				{
					m_certusuario = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: NRO_ACCIDENTES.
		/// </summary>
		public Nullable<Int32> NRO_ACCIDENTES
		{
			get { return m_nro_accidentes; }
			set
			{
				if (m_nro_accidentes != value)
				{
					m_nro_accidentes = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DIAS_ENFERMEDAD.
		/// </summary>
		public Nullable<Int32> DIAS_ENFERMEDAD
		{
			get { return m_dias_enfermedad; }
			set
			{
				if (m_dias_enfermedad != value)
				{
					m_dias_enfermedad = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: OBSERVACION.
		/// </summary>
		public String OBSERVACION
		{
			get { return m_observacion; }
			set
			{
				if (m_observacion != value)
				{
					m_observacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: TOTAL_PERDIDOS.
		/// </summary>
		public Nullable<Int32> TOTAL_PERDIDOS
		{
			get { return m_total_perdidos; }
			set
			{
				if (m_total_perdidos != value)
				{
					m_total_perdidos = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Nullable<Guid> ID
		{
			get { return m_id; }
			set
			{
				if (m_id != value)
				{
					m_id = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DIAS_INCAPACIDAD.
		/// </summary>
		public Nullable<Int32> DIAS_INCAPACIDAD
		{
			get { return m_dias_incapacidad; }
			set
			{
				if (m_dias_incapacidad != value)
				{
					m_dias_incapacidad = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: NRO_ENFERMEDAD.
		/// </summary>
		public Nullable<Int32> NRO_ENFERMEDAD
		{
			get { return m_nro_enfermedad; }
			set
			{
				if (m_nro_enfermedad != value)
				{
					m_nro_enfermedad = value;
				}
			}
		}
	

		#endregion

		#region [ Instance Entity ]
		public InstanceEntity m_instance;

		/// <summary>
		/// Gets or sets el valor de: InstanceEntity.
		/// </summary>
		public InstanceEntity Instance
		{
			get { return m_instance; }
			set { m_instance = value; }
		}

		#endregion
	}
}
	