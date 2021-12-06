
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Videos
    {
        #region [ Variables ]
        
    	private String m_modulo;

		private Nullable<Int32> m_modulo_v4;

		private String m_usuario;
	
    	private String m_fecha_mod;
	
    	private String m_descripcion;
	
    	private String m_activo;
	
    	private String m_version;
	
    	private String m_privado;
	
    	private String m_hora_mod;
	
    	private Byte[] m_archivo;
	
    	private String m_nombre_archivo;
	
    	private String m_tipo_contenido;
	
    	private Decimal m_id;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Videos.
        /// </summary>
        public Videos()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: MODULO.
		/// </summary>
		public String MODULO
		{
			get { return m_modulo; }
			set
			{
				if (m_modulo != value)
				{
					m_modulo = value;
				}
			}
		}

		/// <summary>
		/// Gets or sets el valor de: MODULO_V4.
		/// </summary>
		public Nullable<Int32> MODULO_V4
		{
			get { return m_modulo_v4; }
			set
			{
				if (m_modulo_v4 != value)
				{
					m_modulo_v4 = value;
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
		/// Gets or sets el valor de: FECHA_MOD.
		/// </summary>
		public String FECHA_MOD
		{
			get { return m_fecha_mod; }
			set
			{
				if (m_fecha_mod != value)
				{
					m_fecha_mod = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public String DESCRIPCION
		{
			get { return m_descripcion; }
			set
			{
				if (m_descripcion != value)
				{
					m_descripcion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public String ACTIVO
		{
			get { return m_activo; }
			set
			{
				if (m_activo != value)
				{
					m_activo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: VERSION.
		/// </summary>
		public String VERSION
		{
			get { return m_version; }
			set
			{
				if (m_version != value)
				{
					m_version = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PRIVADO.
		/// </summary>
		public String PRIVADO
		{
			get { return m_privado; }
			set
			{
				if (m_privado != value)
				{
					m_privado = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: HORA_MOD.
		/// </summary>
		public String HORA_MOD
		{
			get { return m_hora_mod; }
			set
			{
				if (m_hora_mod != value)
				{
					m_hora_mod = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ARCHIVO.
		/// </summary>
		public Byte[] ARCHIVO
		{
			get { return m_archivo; }
			set
			{
				if (m_archivo != value)
				{
					m_archivo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: NOMBRE_ARCHIVO.
		/// </summary>
		public String NOMBRE_ARCHIVO
		{
			get { return m_nombre_archivo; }
			set
			{
				if (m_nombre_archivo != value)
				{
					m_nombre_archivo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: TIPO_CONTENIDO.
		/// </summary>
		public String TIPO_CONTENIDO
		{
			get { return m_tipo_contenido; }
			set
			{
				if (m_tipo_contenido != value)
				{
					m_tipo_contenido = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Decimal ID
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
	