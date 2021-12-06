using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Reserva_Bus 
	{
		#region [ Variables ]
		private Decimal m_idprog;
		private String m_rut;
		private String m_empresa;
		private String m_ost;
		private String m_utilizo;
		private String m_usuario;
		private String m_estado;
		private Nullable<Int64> m_idsync;
		private String m_idtransaccion;
		private String m_fecha_cancela;
		private String m_hora_cancela;
		private String m_usuario_cancela;
		private String m_tipopase;
		private String m_patente_acceso;
		private String m_fecha_reserva;
		private String m_hora_reserva;
		private String m_fecha_reserva2;
		private Nullable<DateTime> m_updated_at;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Reserva_Bus.
		/// </summary>
		public Reserva_Bus()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: IDPROG.
		/// </summary>
		public Decimal IDPROG
		{
			get { return m_idprog; }
			set
			{
				if (m_idprog != value)
				{
					m_idprog = value;
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
		/// Gets or sets el valor de: UTILIZO.
		/// </summary>
		public String UTILIZO
		{
			get { return m_utilizo; }
			set
			{
				if (m_utilizo != value)
				{
					m_utilizo = value;
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
		/// Gets or sets el valor de: IDSYNC.
		/// </summary>
		public Nullable<Int64> IDSYNC
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
		/// Gets or sets el valor de: IDTRANSACCION.
		/// </summary>
		public String IDTRANSACCION
		{
			get { return m_idtransaccion; }
			set
			{
				if (m_idtransaccion != value)
				{
					m_idtransaccion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA_CANCELA.
		/// </summary>
		public String FECHA_CANCELA
		{
			get { return m_fecha_cancela; }
			set
			{
				if (m_fecha_cancela != value)
				{
					m_fecha_cancela = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORA_CANCELA.
		/// </summary>
		public String HORA_CANCELA
		{
			get { return m_hora_cancela; }
			set
			{
				if (m_hora_cancela != value)
				{
					m_hora_cancela = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIO_CANCELA.
		/// </summary>
		public String USUARIO_CANCELA
		{
			get { return m_usuario_cancela; }
			set
			{
				if (m_usuario_cancela != value)
				{
					m_usuario_cancela = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOPASE.
		/// </summary>
		public String TIPOPASE
		{
			get { return m_tipopase; }
			set
			{
				if (m_tipopase != value)
				{
					m_tipopase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PATENTE_ACCESO.
		/// </summary>
		public String PATENTE_ACCESO
		{
			get { return m_patente_acceso; }
			set
			{
				if (m_patente_acceso != value)
				{
					m_patente_acceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA_RESERVA.
		/// </summary>
		public String FECHA_RESERVA
		{
			get { return m_fecha_reserva; }
			set
			{
				if (m_fecha_reserva != value)
				{
					m_fecha_reserva = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORA_RESERVA.
		/// </summary>
		public String HORA_RESERVA
		{
			get { return m_hora_reserva; }
			set
			{
				if (m_hora_reserva != value)
				{
					m_hora_reserva = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA_RESERVA2.
		/// </summary>
		public String FECHA_RESERVA2
		{
			get { return m_fecha_reserva2; }
			set
			{
				if (m_fecha_reserva2 != value)
				{
					m_fecha_reserva2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UPDATED_AT.
		/// </summary>
		public Nullable<DateTime> UPDATED_AT
		{
			get { return m_updated_at; }
			set
			{
				if (m_updated_at != value)
				{
					m_updated_at = value;
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
