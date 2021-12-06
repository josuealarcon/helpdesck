using System;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class WorkersLocal_Bono_Resumen
    {

        #region [ Variables ]

        private String m_tipo_bono { get; set; }
        private String m_periodo { get; set; }
        private String m_rut { get; set; }
        private String m_division { get; set; }
        private String m_empresa { get; set; }
        private String m_ost { get; set; }
        private String m_turno { get; set; }
        private Nullable<Int32> m_dias_trabajo { get; set; }
        private Nullable<Int32> m_dias_faena { get; set; }
        private Nullable<Int32> m_dias_licencia { get; set; }
        private Nullable<Int32> m_total_asistencia { get; set; }
        private Nullable<Int32> m_porcen_asis_final { get; set; }
        private Nullable<Int32> m_porcen_asis_min { get; set; }
        private String m_bono { get; set; }
        private Nullable<Int32> m_valor { get; set; }
        private String m_fechamod { get; set; }
        private String m_horamod { get; set; }
        private String m_usrmod { get; set; }
        private String m_cerrado { get; set; }
        private String m_fecha_cierre { get; set; }
        private String m_hora_cierre { get; set; }
        private String m_usuario_cierre { get; set; }

        #endregion

        #region[ Constructores ]

        /// <summary>
        /// Inicializar una nueva instancia de la clase Mutualidad.
        /// </summary>
        public WorkersLocal_Bono_Resumen()
        { }

        #endregion

        #region [ Propiedades ]

        /// <summary>
        /// Gets or sets el valor de: TIPO_BONO.
        /// </summary>
        public String TIPO_BONO
        {
            get { return m_tipo_bono; }
            set
            {
                if (m_tipo_bono != value)
                {
                    m_tipo_bono = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: PERIODO.
        /// </summary>
        public String PERIODO
        {
            get { return m_periodo; }
            set
            {
                if (m_periodo != value)
                {
                    m_periodo = value;
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
        /// Gets or sets el valor de: DIAS_TRABAJO.
        /// </summary>
        public Nullable<Int32> DIAS_TRABAJO
        {
            get { return m_dias_trabajo; }
            set
            {
                if (m_dias_trabajo != value)
                {
                    m_dias_trabajo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DIAS_FAENA.
        /// </summary>
        public Nullable<Int32> DIAS_FAENA
        {
            get { return m_dias_faena; }
            set
            {
                if (m_dias_faena != value)
                {
                    m_dias_faena = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DIAS_LICENCIA.
        /// </summary>
        public Nullable<Int32> DIAS_LICENCIA
        {
            get { return m_dias_licencia; }
            set
            {
                if (m_dias_licencia != value)
                {
                    m_dias_licencia = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TOTAL_ASISTENCIA.
        /// </summary>
        public Nullable<Int32> TOTAL_ASISTENCIA
        {
            get { return m_total_asistencia; }
            set
            {
                if (m_total_asistencia != value)
                {
                    m_total_asistencia = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: PORCEN_ASIS_FINAL.
        /// </summary>
        public Nullable<Int32> PORCEN_ASIS_FINAL
        {
            get { return m_porcen_asis_final; }
            set
            {
                if (m_porcen_asis_final != value)
                {
                    m_porcen_asis_final = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: PORCEN_ASIS_MIN.
        /// </summary>
        public Nullable<Int32> PORCEN_ASIS_MIN
        {
            get { return m_porcen_asis_min; }
            set
            {
                if (m_porcen_asis_min != value)
                {
                    m_porcen_asis_min = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: BONO.
        /// </summary>
        public String BONO
        {
            get { return m_bono; }
            set
            {
                if (m_bono != value)
                {
                    m_bono = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: VALOR.
        /// </summary>
        public Nullable<Int32> VALOR
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
        /// <summary>
        /// Gets or sets el valor de: USRMOD.
        /// </summary>
        public String USRMOD
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
        /// Gets or sets el valor de: CERRADO.
        /// </summary>
        public String CERRADO
        {
            get { return m_cerrado; }
            set
            {
                if (m_cerrado != value)
                {
                    m_cerrado = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FECHA_CIERRE.
        /// </summary>
        public String FECHA_CIERRE
        {
            get { return m_fecha_cierre; }
            set
            {
                if (m_fecha_cierre != value)
                {
                    m_fecha_cierre = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HORA_CIERRE.
        /// </summary>
        public String HORA_CIERRE
        {
            get { return m_hora_cierre; }
            set
            {
                if (m_hora_cierre != value)
                {
                    m_hora_cierre = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: USUARIO_CIERRE.
        /// </summary>
        public String USUARIO_CIERRE
        {
            get { return m_usuario_cierre; }
            set
            {
                if (m_usuario_cierre != value)
                {
                    m_usuario_cierre = value;
                }
            }
        }

        #endregion

        #region [ Instance Entity]

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
