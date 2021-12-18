using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Solicitud
	{
		#region [ Variables ]

		private Int32 m_id_solicitud;
		private string m_descripcion;
		private string m_asunto;
		private string m_fecha;
		private string m_hora;
		private Int32? m_num_ticket;
		private string m_dni_usuario;
		private Int32 m_id_servicio;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Solicitud.
		/// </summary>
		public Solicitud()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ID_SOLICITUD.
		/// </summary>
		public Int32 ID_SOLICITUD
		{
			get { return m_id_solicitud; }
			set
			{
				if (m_id_solicitud != value)
				{
					m_id_solicitud = value;
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
		/// Gets or sets el valor de: ASUNTO.
		/// </summary>
		public string ASUNTO
		{
			get { return m_asunto; }
			set
			{
				if (m_asunto != value)
				{
					m_asunto = value;
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
		/// Gets or sets el valor de: HORA.
		/// </summary>
		public string HORA
		{
			get { return m_hora; }
			set
			{
				if (m_hora != value)
				{
					m_hora = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NUM_TICKET.
		/// </summary>
		public Int32? NUM_TICKET
		{
			get { return m_num_ticket; }
			set
			{
				if (m_num_ticket != value)
				{
					m_num_ticket = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DNI_USUARIO.
		/// </summary>
		public string DNI_USUARIO
		{
			get { return m_dni_usuario; }
			set
			{
				if (m_dni_usuario != value)
				{
					m_dni_usuario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_SERVICIO.
		/// </summary>
		public Int32 ID_SERVICIO
		{
			get { return m_id_servicio; }
			set
			{
				if (m_id_servicio != value)
				{
					m_id_servicio = value;
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
