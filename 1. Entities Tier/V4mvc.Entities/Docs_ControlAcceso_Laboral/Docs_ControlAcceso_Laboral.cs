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
	[Serializable()]
	public partial class Docs_ControlAcceso_Laboral
	{
		#region [ Variables ]
		private Int32 m_id;
		private Nullable<Int32> m_id_doc;
		private String m_rut;
		private String m_empresa;
		private String m_nombre_archivo;
		private String m_tipo_contenido;
		private String m_fechasube;
		private String m_horasube;
		private String m_usuario;
		private String m_validado;
		private String m_certusuario;
		private String m_certfecha;
		private String m_certhora;
		private Nullable<Guid> m_idrechazo;
		private String m_obscertificacion;
		private Nullable<Guid> m_id_archivo;
		private String m_fecha_ini;
		private String m_fecha_fin;
		private Nullable<Int32> m_cantdias;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_ControlAcceso_Laboral.
		/// </summary>
		public Docs_ControlAcceso_Laboral()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Int32 ID
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
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Nullable<Int32> ID_DOC
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
		/// Gets or sets el valor de: RUT.
		/// </summary>
		public String RUT
		{
			get { return m_rut; }
			set
			{
				if (m_rut != value)
				{
					m_rut = value;
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
		/// Gets or sets el valor de: IDRECHAZO.
		/// </summary>
		public Nullable<Guid> IDRECHAZO
		{
			get { return m_idrechazo; }
			set
			{
				if (m_idrechazo != value)
				{
					m_idrechazo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBSCERTIFICACION.
		/// </summary>
		public String OBSCERTIFICACION
		{
			get { return m_obscertificacion; }
			set
			{
				if (m_obscertificacion != value)
				{
					m_obscertificacion = value;
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
		/// Gets or sets el valor de: FECHA_INI.
		/// </summary>
		public String FECHA_INI
		{
			get { return m_fecha_ini; }
			set
			{
				if (m_fecha_ini != value)
				{
					m_fecha_ini = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA_FIN.
		/// </summary>
		public String FECHA_FIN
		{
			get { return m_fecha_fin; }
			set
			{
				if (m_fecha_fin != value)
				{
					m_fecha_fin = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CANTDIAS.
		/// </summary>
		public Nullable<Int32> CANTDIAS
		{
			get { return m_cantdias; }
			set
			{
				if (m_cantdias != value)
				{
					m_cantdias = value;
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
