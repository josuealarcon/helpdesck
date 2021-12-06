using System;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Charlhist
    {

        #region [ Variables ]

        private String m_rut { get; set; }
        private String m_fecha { get; set; }
        private String m_charla { get; set; }
        private String m_empresa { get; set; }
        private String m_local { get; set; }
        private String m_orador { get; set; }
        private Nullable<Int32> m_teorico { get; set; }
        private Nullable<Int32> m_practico { get; set; }
        private Int32 m_idcharla { get; set; }
        private String m_obs { get; set; }
        private String m_division { get; set; }

        #endregion

        #region [ Constructor ]

        /// <summary>
        /// Inicializar una nueva instancia de la clase Charlas.
        /// </summary>
        public Charlhist()
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
		/// Gets or sets el valor de: CHARLA.
		/// </summary>
		public String CHARLA
		{
			get { return m_charla; }
			set
			{
				if (m_charla != value)
				{
					m_charla = value;
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
		/// Gets or sets el valor de: ORADOR.
		/// </summary>
		public String ORADOR
		{
			get { return m_orador; }
			set
			{
				if (m_orador != value)
				{
					m_orador = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TEORICO.
		/// </summary>
		public Nullable<Int32> TEORICO
		{
			get { return m_teorico; }
			set
			{
				if (m_teorico != value)
				{
					m_teorico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PRACTICO.
		/// </summary>
		public Nullable<Int32> PRACTICO
		{
			get { return m_practico; }
			set
			{
				if (m_practico != value)
				{
					m_practico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDCHARLA.
		/// </summary>
		public Int32 IDCHARLA
		{
			get { return m_idcharla; }
			set
			{
				if (m_idcharla != value)
				{
					m_idcharla = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBS.
		/// </summary>
		public String OBS
		{
			get { return m_obs; }
			set
			{
				if (m_obs != value)
				{
					m_obs = value;
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
