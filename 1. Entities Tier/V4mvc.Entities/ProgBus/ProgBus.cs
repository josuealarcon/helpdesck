using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class ProgBus
	{
		#region [ Variables ]
		private Decimal m_idprog;
		private String m_patente;
		private String m_origen;
		private String m_destino;
		private String m_duracion;
		private String m_fecha;
		private String m_hora;
		private String m_activo;
		private String m_division;
		private Nullable<Int32> m_recorrido;
		private Nullable<Int32> m_idflota;
		private String m_direccion;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase ProgBus.
		/// </summary>
		public ProgBus()
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
		/// Gets or sets el valor de: PATENTE.
		/// </summary>
		public String PATENTE
		{
			get { return m_patente; }
			set
			{
				if (m_patente != value)
				{
					m_patente = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ORIGEN.
		/// </summary>
		public String ORIGEN
		{
			get { return m_origen; }
			set
			{
				if (m_origen != value)
				{
					m_origen = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESTINO.
		/// </summary>
		public String DESTINO
		{
			get { return m_destino; }
			set
			{
				if (m_destino != value)
				{
					m_destino = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DURACION.
		/// </summary>
		public String DURACION
		{
			get { return m_duracion; }
			set
			{
				if (m_duracion != value)
				{
					m_duracion = value;
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
		/// Gets or sets el valor de: RECORRIDO.
		/// </summary>
		public Nullable<Int32> RECORRIDO
		{
			get { return m_recorrido; }
			set
			{
				if (m_recorrido != value)
				{
					m_recorrido = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDFLOTA.
		/// </summary>
		public Nullable<Int32> IDFLOTA
		{
			get { return m_idflota; }
			set
			{
				if (m_idflota != value)
				{
					m_idflota = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRECCION.
		/// </summary>
		public String DIRECCION
		{
			get { return m_direccion; }
			set
			{
				if (m_direccion != value)
				{
					m_direccion = value;
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
