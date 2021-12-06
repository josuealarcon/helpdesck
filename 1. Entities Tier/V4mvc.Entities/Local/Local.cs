using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Local 
	{
		#region [ Variables ]
		private String m_local;
		private String m_empresal;
		private String m_detalle;
		private String m_locall;
		private String m_division;
		private String m_mandante;
		private String m_activo;
		private String m_p_acceso;
		private String m_fechamod;
		private String m_horamod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Local.
		/// </summary>
		public Local()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: EMPRESAL.
		/// </summary>
		public String EMPRESAL
		{
			get { return m_empresal; }
			set
			{
				if (m_empresal != value)
				{
					m_empresal = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DETALLE.
		/// </summary>
		public String DETALLE
		{
			get { return m_detalle; }
			set
			{
				if (m_detalle != value)
				{
					m_detalle = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOCALL.
		/// </summary>
		public String LOCALL
		{
			get { return m_locall; }
			set
			{
				if (m_locall != value)
				{
					m_locall = value;
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
		/// Gets or sets el valor de: MANDANTE.
		/// </summary>
		public String MANDANTE
		{
			get { return m_mandante; }
			set
			{
				if (m_mandante != value)
				{
					m_mandante = value;
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
		/// Gets or sets el valor de: P_ACCESO.
		/// </summary>
		public String P_ACCESO
		{
			get { return m_p_acceso; }
			set
			{
				if (m_p_acceso != value)
				{
					m_p_acceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHAMOD.
		/// </summary>
		public String FECHAMOD
		{
			get { return m_fechamod; }
			set
			{
				if (m_fechamod != value)
				{
					m_fechamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAMOD.
		/// </summary>
		public String HORAMOD
		{
			get { return m_horamod; }
			set
			{
				if (m_horamod != value)
				{
					m_horamod = value;
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
