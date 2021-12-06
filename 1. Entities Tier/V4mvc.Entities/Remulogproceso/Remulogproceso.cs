using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Remulogproceso
	{
        #region [ Variables ]

        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Remulogproceso.
        /// </summary>
        public Remulogproceso()
		{  }
        #endregion

        #region [ Propiedades ]
        /// <summary>
        /// Gets or sets el valor de: Remulogproceso.
        /// </summary>
        public string PAIS { get; set; }
        public string EMPRESA { get; set; }
        public string RUT { get; set; }
        public string PERIODO { get; set; }
        public string USUARIO { get; set; }
        public string FPROCESO { get; set; }
        public string HPROCESO { get; set; }
        public string MOTIVO { get; set; }
        public int? IMPONIBLE_R { get; set; }
        public int? IMPONIBLE_P { get; set; }
        public int? DIFERENCIA { get; set; }
        public string REMUNERA { get; set; }
        public string PREVIRED { get; set; }
        public string L_SUELDO { get; set; }
        public int? IMPONIBLE_L { get; set; }
        public string PBANCO { get; set; }
        public int? DIFPAGADO { get; set; }
        public int? LIQUIDO { get; set; }
        public int? TRANSFERIDO { get; set; }
        public string CUMPLE { get; set; }
        public double? P_CUMPLE { get; set; }
        public string TIPOCONTRATO { get; set; }
        public string OST { get; set; }
        public int? BONOIP { get; set; }
        public int? BONOIS { get; set; }
        public int? BONO1 { get; set; }
        public int? BONO2 { get; set; }
        public int? DIFBONOIP { get; set; }
        public int? DIFBONOIS { get; set; }
        public int? DIFBONO1 { get; set; }
        public int? DIFBONO2 { get; set; }
        public string FINIQUITO { get; set; }
        public string VALIDADO { get; set; }
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
