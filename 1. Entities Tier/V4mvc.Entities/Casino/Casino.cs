using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Casino
	{

		#region [ Variables ]

		private String m_rut;
		private String m_empresa;
		private String m_servicio;
		private String m_fecha;
		private String m_hora;
		private String m_valor;
		private String m_turno;
		private String m_error;
		private String m_local;
		private String m_ccosto;
		private String m_ost;
		private String m_invita;
		private String m_nrolote;
		private String m_division;
		private String m_cod_pda;
		private String m_usuario;
		private String m_cantidad;

		#endregion

		#region [ Constructores ]

		/// <summary>
		/// Inicializar una nueva instancia de la clase Control_Cuarentena.
		/// </summary>
		public Casino()
		{ }

		#endregion

		#region [ Propiedades ]

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
		/// Gets or sets el valor de: SERVICIO.
		/// </summary>
		public String SERVICIO
		{
			get { return m_servicio; }
			set
			{
				if (m_servicio != value)
				{
					m_servicio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA.
		/// </summary>
		public String FECHA
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
		public String HORA
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
		/// Gets or sets el valor de: VALOR.
		/// </summary>
		public String VALOR
		{
			get { return m_valor; }
			set
			{
				if (m_valor != value)
				{
					m_valor = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TURNO.
		/// </summary>
		public String TURNO
		{
			get { return m_turno; }
			set
			{
				if (m_turno != value)
				{
					m_turno = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ERROR.
		/// </summary>
		public String ERROR
		{
			get { return m_error; }
			set
			{
				if (m_error != value)
				{
					m_error = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOCAL.
		/// </summary>
		public String LOCAL
		{
			get { return m_local; }
			set
			{
				if (m_local != value)
				{
					m_local = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOSTO.
		/// </summary>
		public String CCOSTO
		{
			get { return m_ccosto; }
			set
			{
				if (m_ccosto != value)
				{
					m_ccosto = value;
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
		/// Gets or sets el valor de: INVITA.
		/// </summary>
		public String INVITA
		{
			get { return m_invita; }
			set
			{
				if (m_invita != value)
				{
					m_invita = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NROLOTE.
		/// </summary>
		public String NROLOTE
		{
			get { return m_nrolote; }
			set
			{
				if (m_nrolote != value)
				{
					m_nrolote = value;
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
		/// Gets or sets el valor de: COD_PDA.
		/// </summary>
		public String COD_PDA
		{
			get { return m_cod_pda; }
			set
			{
				if (m_cod_pda != value)
				{
					m_cod_pda = value;
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
		/// Gets or sets el valor de: CANTIDAD.
		/// </summary>
		public String CANTIDAD
		{
			get { return m_cantidad; }
			set
			{
				if (m_cantidad != value)
				{
					m_cantidad = value;
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
