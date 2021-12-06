using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Viajes_Parametros
	{
		#region [ Variables ]
		private Nullable<Int32> m_tiempo_cancela;
		private Nullable<Int32> m_tiempo_reserva;
		private String m_control_perez;
		private String m_ida_vuelta;
		private Nullable<Int32> m_dias_castigo;
		private Nullable<Int32> m_porc_noutiliza;
		private Nullable<Int32> m_periodo_noutiliza;
		private String m_control_noutiliza;
		private String m_glosa_ticket;
		private String m_glosa;
		private String m_correo_adicional;
		private String m_control_mantencion;
		private String m_cancela_realizado;
		private Nullable<Int32> m_cantidad_subidas;
		private Nullable<Int32> m_cantidad_bajadas;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Viajes_Parametros.
		/// </summary>
		public Viajes_Parametros()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: TIEMPO_CANCELA.
		/// </summary>
		public Nullable<Int32> TIEMPO_CANCELA
		{
			get { return m_tiempo_cancela; }
			set
			{
				if (m_tiempo_cancela != value)
				{
					m_tiempo_cancela = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIEMPO_RESERVA.
		/// </summary>
		public Nullable<Int32> TIEMPO_RESERVA
		{
			get { return m_tiempo_reserva; }
			set
			{
				if (m_tiempo_reserva != value)
				{
					m_tiempo_reserva = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTROL_PEREZ.
		/// </summary>
		public String CONTROL_PEREZ
		{
			get { return m_control_perez; }
			set
			{
				if (m_control_perez != value)
				{
					m_control_perez = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDA_VUELTA.
		/// </summary>
		public String IDA_VUELTA
		{
			get { return m_ida_vuelta; }
			set
			{
				if (m_ida_vuelta != value)
				{
					m_ida_vuelta = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIAS_CASTIGO.
		/// </summary>
		public Nullable<Int32> DIAS_CASTIGO
		{
			get { return m_dias_castigo; }
			set
			{
				if (m_dias_castigo != value)
				{
					m_dias_castigo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PORC_NOUTILIZA.
		/// </summary>
		public Nullable<Int32> PORC_NOUTILIZA
		{
			get { return m_porc_noutiliza; }
			set
			{
				if (m_porc_noutiliza != value)
				{
					m_porc_noutiliza = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PERIODO_NOUTILIZA.
		/// </summary>
		public Nullable<Int32> PERIODO_NOUTILIZA
		{
			get { return m_periodo_noutiliza; }
			set
			{
				if (m_periodo_noutiliza != value)
				{
					m_periodo_noutiliza = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTROL_NOUTILIZA.
		/// </summary>
		public String CONTROL_NOUTILIZA
		{
			get { return m_control_noutiliza; }
			set
			{
				if (m_control_noutiliza != value)
				{
					m_control_noutiliza = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GLOSA_TICKET.
		/// </summary>
		public String GLOSA_TICKET
		{
			get { return m_glosa_ticket; }
			set
			{
				if (m_glosa_ticket != value)
				{
					m_glosa_ticket = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GLOSA.
		/// </summary>
		public String GLOSA
		{
			get { return m_glosa; }
			set
			{
				if (m_glosa != value)
				{
					m_glosa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CORREO_ADICIONAL.
		/// </summary>
		public String CORREO_ADICIONAL
		{
			get { return m_correo_adicional; }
			set
			{
				if (m_correo_adicional != value)
				{
					m_correo_adicional = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTROL_MANTENCION.
		/// </summary>
		public String CONTROL_MANTENCION
		{
			get { return m_control_mantencion; }
			set
			{
				if (m_control_mantencion != value)
				{
					m_control_mantencion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CANCELA_REALIZADO.
		/// </summary>
		public String CANCELA_REALIZADO
		{
			get { return m_cancela_realizado; }
			set
			{
				if (m_cancela_realizado != value)
				{
					m_cancela_realizado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CANTIDAD_SUBIDAS.
		/// </summary>
		public Nullable<Int32> CANTIDAD_SUBIDAS
		{
			get { return m_cantidad_subidas; }
			set
			{
				if (m_cantidad_subidas != value)
				{
					m_cantidad_subidas = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CANTIDAD_BAJADAS.
		/// </summary>
		public Nullable<Int32> CANTIDAD_BAJADAS
		{
			get { return m_cantidad_bajadas; }
			set
			{
				if (m_cantidad_bajadas != value)
				{
					m_cantidad_bajadas = value;
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
