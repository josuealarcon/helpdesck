using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Docs_E200
	{
		#region [ Variables ]

		private Guid m_id;
		private string m_fecha_mod;
		private string m_hora_mod;
		private string m_estado;
		private string m_observacion;
		private string m_usuario;
		private string m_usuario_cert;
		private string m_fecha_cert;
		private string m_hora_cert;
		private string m_tipotrabajo;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_E200.
		/// </summary>
		public Docs_E200()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Guid ID
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
		/// Gets or sets el valor de: TIPOTRABAJO.
		/// </summary>
		public string TIPOTRABAJO
		{
			get { return m_tipotrabajo; }
			set
			{
				if (m_tipotrabajo != value)
				{
					m_tipotrabajo = value;
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
