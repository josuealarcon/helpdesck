using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Docs_Cotizacion
	{
		#region [ Variables ]

		private string m_idempresa;
		private string m_ost;
		private string m_division;
		private string m_fecha;
		private Int32 m_tipo;
		private Guid? m_id;
		private string m_fecha_mod;
		private string m_hora_mod;
		private string m_estado;
		private string m_observacion;
		private string m_usuario;
		private string m_usuario_cert;
		private string m_fecha_cert;
		private string m_hora_cert;
		private string m_nombre_archivo;
		private string m_tipo_contenido;
		private byte[] m_archivo;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Cotizacion.
		/// </summary>
		public Docs_Cotizacion()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDEMPRESA.
		/// </summary>
		public string IDEMPRESA
		{
			get { return m_idempresa; }
			set
			{
				if (m_idempresa != value)
				{
					m_idempresa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OST.
		/// </summary>
		public string OST
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
		/// Gets or sets el valor de: DIVISION.
		/// </summary>
		public string DIVISION
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
		/// Gets or sets el valor de: FECHA.
		/// </summary>
		public string FECHA
		{
			get { return m_fecha; }
			set
			{
				if (m_fecha != value)
				{
					m_fecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO.
		/// </summary>
		public Int32 TIPO
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
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Guid? ID
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
		/// Gets or sets el valor de: FECHA_MOD.
		/// </summary>
		public string FECHA_MOD
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
		/// Gets or sets el valor de: HORA_MOD.
		/// </summary>
		public string HORA_MOD
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
		/// Gets or sets el valor de: ESTADO.
		/// </summary>
		public string ESTADO
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
		/// Gets or sets el valor de: OBSERVACION.
		/// </summary>
		public string OBSERVACION
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
		/// Gets or sets el valor de: USUARIO.
		/// </summary>
		public string USUARIO
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
		/// Gets or sets el valor de: USUARIO_CERT.
		/// </summary>
		public string USUARIO_CERT
		{
			get { return m_usuario_cert; }
			set
			{
				if (m_usuario_cert != value)
				{
					m_usuario_cert = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA_CERT.
		/// </summary>
		public string FECHA_CERT
		{
			get { return m_fecha_cert; }
			set
			{
				if (m_fecha_cert != value)
				{
					m_fecha_cert = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORA_CERT.
		/// </summary>
		public string HORA_CERT
		{
			get { return m_hora_cert; }
			set
			{
				if (m_hora_cert != value)
				{
					m_hora_cert = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CONTENIDO.
		/// </summary>
		public string TIPO_CONTENIDO
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
		/// Gets or sets el valor de: ARCHIVO.
		/// </summary>
		public byte[] ARCHIVO
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
