
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class LogDocsOST2
    {
        #region [ Variables ]
        
    	private String m_fechamod;
	
    	private String m_certhora_adminost;
	
    	private String m_usuario;
	
    	private String m_certusuario_adminost;
	
    	private String m_certhora;
	
    	private String m_validado_adminost;
	
    	private String m_certusuario;
	
    	private Int16 m_id_doc;
	
    	private String m_validado;
	
    	private Int16 m_nivel;
	
    	private String m_empresa;
	
    	private String m_tipo;
	
    	private String m_horamod;
	
    	private String m_certfecha;
	
    	private String m_ost;
	
    	private String m_obs_re_validador;
	
    	private Nullable<Guid> m_idarch_re_admin;
	
    	private String m_obs_re_adminost;
	
    	private String m_division;
	
    	private String m_horasube;
	
    	private String m_madre;
	
    	private String m_certfecha_adminost;
	
    	private String m_fechasube;
	
    	private Nullable<Guid> m_idarch_re_validador;
	
    	private Nullable<Guid> m_id_archivo;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase LogDocsOST2.
        /// </summary>
        public LogDocsOST2()
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
		/// Gets or sets el valor de: CERTHORA_ADMINOST.
		/// </summary>
		public String CERTHORA_ADMINOST
		{
			get { return m_certhora_adminost; }
			set
			{
				if (m_certhora_adminost != value)
				{
					m_certhora_adminost = value;
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
		/// Gets or sets el valor de: CERTUSUARIO_ADMINOST.
		/// </summary>
		public String CERTUSUARIO_ADMINOST
		{
			get { return m_certusuario_adminost; }
			set
			{
				if (m_certusuario_adminost != value)
				{
					m_certusuario_adminost = value;
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
		/// Gets or sets el valor de: VALIDADO_ADMINOST.
		/// </summary>
		public String VALIDADO_ADMINOST
		{
			get { return m_validado_adminost; }
			set
			{
				if (m_validado_adminost != value)
				{
					m_validado_adminost = value;
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
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Int16 ID_DOC
		{
			get { return m_id_doc; }
			set
			{
				if (m_id_doc != value)
				{
					m_id_doc = value;
				}
			}
		}
	
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
		/// Gets or sets el valor de: NIVEL.
		/// </summary>
		public Int16 NIVEL
		{
			get { return m_nivel; }
			set
			{
				if (m_nivel != value)
				{
					m_nivel = value;
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
		/// Gets or sets el valor de: TIPO.
		/// </summary>
		public String TIPO
		{
			get { return m_tipo; }
			set
			{
				if (m_tipo != value)
				{
					m_tipo = value;
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
		/// Gets or sets el valor de: OBS_RE_VALIDADOR.
		/// </summary>
		public String OBS_RE_VALIDADOR
		{
			get { return m_obs_re_validador; }
			set
			{
				if (m_obs_re_validador != value)
				{
					m_obs_re_validador = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: IDARCH_RE_ADMIN.
		/// </summary>
		public Nullable<Guid> IDARCH_RE_ADMIN
		{
			get { return m_idarch_re_admin; }
			set
			{
				if (m_idarch_re_admin != value)
				{
					m_idarch_re_admin = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: OBS_RE_ADMINOST.
		/// </summary>
		public String OBS_RE_ADMINOST
		{
			get { return m_obs_re_adminost; }
			set
			{
				if (m_obs_re_adminost != value)
				{
					m_obs_re_adminost = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DIVISION.
		/// </summary>
		public String DIVISION
		{
			get { return m_division; }
			set
			{
				if (m_division != value)
				{
					m_division = value;
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
		/// Gets or sets el valor de: CERTFECHA_ADMINOST.
		/// </summary>
		public String CERTFECHA_ADMINOST
		{
			get { return m_certfecha_adminost; }
			set
			{
				if (m_certfecha_adminost != value)
				{
					m_certfecha_adminost = value;
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
		/// Gets or sets el valor de: IDARCH_RE_VALIDADOR.
		/// </summary>
		public Nullable<Guid> IDARCH_RE_VALIDADOR
		{
			get { return m_idarch_re_validador; }
			set
			{
				if (m_idarch_re_validador != value)
				{
					m_idarch_re_validador = value;
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
	