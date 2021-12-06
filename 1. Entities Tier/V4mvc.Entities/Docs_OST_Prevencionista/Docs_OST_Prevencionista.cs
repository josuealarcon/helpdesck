
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Docs_OST_Prevencionista
    {
        #region [ Variables ]
        
    	private String m_fechamod;
	
    	private String m_rut_prevencionista;
	
    	private String m_certhora;
	
    	private String m_fechaaporte;
	
    	private String m_motivo;
	
    	private String m_estado;
	
    	private String m_certusuario;
	
    	private String m_empresa;
	
    	private String m_usrmod;
	
    	private String m_horacreacion;
	
    	private String m_horamod;
	
    	private String m_certfecha;
	
    	private String m_aporte_anglo;
	
    	private String m_ost;
	
    	private Nullable<Int32> m_dotacion;
	
    	private String m_usrcreacion;
	
    	private String m_fechacreacion;
	
    	private String m_horasube;
	
    	private String m_madre;
	
    	private String m_usrsube;
	
    	private String m_observacion;
	
    	private Int64  m_id;
	
    	private String m_fechasube;
	
    	private String m_usraporte;
	
    	private Nullable<Guid> m_id_archivo;
	
    	private String m_horaaporte;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Docs_OST_Prevencionista.
        /// </summary>
        public Docs_OST_Prevencionista()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: FECHAMOD.
		/// </summary>
		public String FECHAMOD
		{
			get { return m_fechamod; }
			set
			{
				if (m_fechamod != value)
				{
					m_fechamod = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: RUT_PREVENCIONISTA.
		/// </summary>
		public String RUT_PREVENCIONISTA
		{
			get { return m_rut_prevencionista; }
			set
			{
				if (m_rut_prevencionista != value)
				{
					m_rut_prevencionista = value;
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
		/// Gets or sets el valor de: FECHAAPORTE.
		/// </summary>
		public String FECHAAPORTE
		{
			get { return m_fechaaporte; }
			set
			{
				if (m_fechaaporte != value)
				{
					m_fechaaporte = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: MOTIVO.
		/// </summary>
		public String MOTIVO
		{
			get { return m_motivo; }
			set
			{
				if (m_motivo != value)
				{
					m_motivo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ESTADO.
		/// </summary>
		public String ESTADO
		{
			get { return m_estado; }
			set
			{
				if (m_estado != value)
				{
					m_estado = value;
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
		/// Gets or sets el valor de: USRMOD.
		/// </summary>
		public String USRMOD
		{
			get { return m_usrmod; }
			set
			{
				if (m_usrmod != value)
				{
					m_usrmod = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: HORACREACION.
		/// </summary>
		public String HORACREACION
		{
			get { return m_horacreacion; }
			set
			{
				if (m_horacreacion != value)
				{
					m_horacreacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: HORAMOD.
		/// </summary>
		public String HORAMOD
		{
			get { return m_horamod; }
			set
			{
				if (m_horamod != value)
				{
					m_horamod = value;
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
		/// Gets or sets el valor de: APORTE_ANGLO.
		/// </summary>
		public String APORTE_ANGLO
		{
			get { return m_aporte_anglo; }
			set
			{
				if (m_aporte_anglo != value)
				{
					m_aporte_anglo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: OST.
		/// </summary>
		public String OST
		{
			get { return m_ost; }
			set
			{
				if (m_ost != value)
				{
					m_ost = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DOTACION.
		/// </summary>
		public Nullable<Int32> DOTACION
		{
			get { return m_dotacion; }
			set
			{
				if (m_dotacion != value)
				{
					m_dotacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: USRCREACION.
		/// </summary>
		public String USRCREACION
		{
			get { return m_usrcreacion; }
			set
			{
				if (m_usrcreacion != value)
				{
					m_usrcreacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FECHACREACION.
		/// </summary>
		public String FECHACREACION
		{
			get { return m_fechacreacion; }
			set
			{
				if (m_fechacreacion != value)
				{
					m_fechacreacion = value;
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
		/// Gets or sets el valor de: MADRE.
		/// </summary>
		public String MADRE
		{
			get { return m_madre; }
			set
			{
				if (m_madre != value)
				{
					m_madre = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: USRSUBE.
		/// </summary>
		public String USRSUBE
		{
			get { return m_usrsube; }
			set
			{
				if (m_usrsube != value)
				{
					m_usrsube = value;
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
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Int64  ID
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
		/// Gets or sets el valor de: USRAPORTE.
		/// </summary>
		public String USRAPORTE
		{
			get { return m_usraporte; }
			set
			{
				if (m_usraporte != value)
				{
					m_usraporte = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ID_ARCHIVO.
		/// </summary>
		public Nullable<Guid> ID_ARCHIVO
		{
			get { return m_id_archivo; }
			set
			{
				if (m_id_archivo != value)
				{
					m_id_archivo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: HORAAPORTE.
		/// </summary>
		public String HORAAPORTE
		{
			get { return m_horaaporte; }
			set
			{
				if (m_horaaporte != value)
				{
					m_horaaporte = value;
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
	