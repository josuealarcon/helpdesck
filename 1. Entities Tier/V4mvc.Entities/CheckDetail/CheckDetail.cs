using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class CheckDetail
	{
		#region [ Variables ]

		private string m_id_tipo;
		private Int32 m_id_check;
		private Int32 m_id_checkdet;
		private string m_nombre;
		private string m_descripcion;
		private string m_reqfoto;
		private string m_reqcodbarra;
		private string m_reqdocumento;
		private Int32? m_orden;
		private Int32? m_idsync;
		private string m_usrcrea;
		private DateTime m_feccrea;
		private string m_usrmod;
		private DateTime? m_fecmod;
		private string m_reqvideo;
		private Int32? m_id_checkgroup;
		private string m_tipo;
		private string m_valormult;
		private string m_valida;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CheckDetail.
		/// </summary>
		public CheckDetail()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ID_TIPO.
		/// </summary>
		public string ID_TIPO
		{
			get { return m_id_tipo; }
			set
			{
				if (m_id_tipo != value)
				{
					m_id_tipo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_CHECK.
		/// </summary>
		public Int32 ID_CHECK
		{
			get { return m_id_check; }
			set
			{
				if (m_id_check != value)
				{
					m_id_check = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_CHECKDET.
		/// </summary>
		public Int32 ID_CHECKDET
		{
			get { return m_id_checkdet; }
			set
			{
				if (m_id_checkdet != value)
				{
					m_id_checkdet = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE.
		/// </summary>
		public string NOMBRE
		{
			get { return m_nombre; }
			set
			{
				if (m_nombre != value)
				{
					m_nombre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public string DESCRIPCION
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
		/// Gets or sets el valor de: REQFOTO.
		/// </summary>
		public string REQFOTO
		{
			get { return m_reqfoto; }
			set
			{
				if (m_reqfoto != value)
				{
					m_reqfoto = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REQCODBARRA.
		/// </summary>
		public string REQCODBARRA
		{
			get { return m_reqcodbarra; }
			set
			{
				if (m_reqcodbarra != value)
				{
					m_reqcodbarra = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REQDOCUMENTO.
		/// </summary>
		public string REQDOCUMENTO
		{
			get { return m_reqdocumento; }
			set
			{
				if (m_reqdocumento != value)
				{
					m_reqdocumento = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ORDEN.
		/// </summary>
		public Int32? ORDEN
		{
			get { return m_orden; }
			set
			{
				if (m_orden != value)
				{
					m_orden = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDSYNC.
		/// </summary>
		public Int32? IDSYNC
		{
			get { return m_idsync; }
			set
			{
				if (m_idsync != value)
				{
					m_idsync = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USRCREA.
		/// </summary>
		public string USRCREA
		{
			get { return m_usrcrea; }
			set
			{
				if (m_usrcrea != value)
				{
					m_usrcrea = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECCREA.
		/// </summary>
		public DateTime FECCREA
		{
			get { return m_feccrea; }
			set
			{
				if (m_feccrea != value)
				{
					m_feccrea = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USRMOD.
		/// </summary>
		public string USRMOD
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
		/// Gets or sets el valor de: FECMOD.
		/// </summary>
		public DateTime? FECMOD
		{
			get { return m_fecmod; }
			set
			{
				if (m_fecmod != value)
				{
					m_fecmod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REQVIDEO.
		/// </summary>
		public string REQVIDEO
		{
			get { return m_reqvideo; }
			set
			{
				if (m_reqvideo != value)
				{
					m_reqvideo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_CHECKGROUP.
		/// </summary>
		public Int32? ID_CHECKGROUP
		{
			get { return m_id_checkgroup; }
			set
			{
				if (m_id_checkgroup != value)
				{
					m_id_checkgroup = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO.
		/// </summary>
		public string TIPO
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
		/// Gets or sets el valor de: VALORMULT.
		/// </summary>
		public string VALORMULT
		{
			get { return m_valormult; }
			set
			{
				if (m_valormult != value)
				{
					m_valormult = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDA.
		/// </summary>
		public string VALIDA
		{
			get { return m_valida; }
			set
			{
				if (m_valida != value)
				{
					m_valida = value;
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
