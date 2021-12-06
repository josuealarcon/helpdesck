using System;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Servicio
    {

        #region [ Variables]

        private String m_servicio { get; set; }
        private String m_descripcion { get; set; }
        private String m_tiposervicio { get; set; }
        private Int32 m_valor { get; set; }
        private String m_horaini { get; set; }
        private String m_horafin { get; set; }
        private String m_local { get; set; }
        private String m_reemplazo { get; set; }
        private Int32 m_maxdia { get; set; }
        private String m_fechamod { get; set; }
        private String m_horamod { get; set; }
        private String m_grabo { get; set; }
        private String m_division { get; set; }
        private Int64 m_idsync { get; set; }

        #endregion

        #region [ Constructores ]

        /// <summary>
        /// Inicializar una nueva instancia de la clase Servicio.
        /// </summary>
        public Servicio()
        { }

        #endregion

        #region [ Propiedades ]

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
        /// Gets or sets el valor de: DESCRIPCION.
        /// </summary>
        public String DESCRIPCION
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
        /// Gets or sets el valor de: TIPOSERVICIO.
        /// </summary>
        public String TIPOSERVICIO
        {
            get { return m_tiposervicio; }
            set
            {
                if (m_tiposervicio != value)
                {
                    m_tiposervicio = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: VALOR.
        /// </summary>
        public Int32 VALOR
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
        /// Gets or sets el valor de: HORAINI.
        /// </summary>
        public String HORAINI
        {
            get { return m_horaini; }
            set
            {
                if (m_horaini != value)
                {
                    m_horaini = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HORAFIN.
        /// </summary>
        public String HORAFIN
        {
            get { return m_horafin; }
            set
            {
                if (m_horafin != value)
                {
                    m_horafin = value;
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
        /// Gets or sets el valor de: REEMPLAZO.
        /// </summary>
        public String REEMPLAZO
        {
            get { return m_reemplazo; }
            set
            {
                if (m_reemplazo != value)
                {
                    m_reemplazo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: MAXDIA.
        /// </summary>
        public Int32 MAXDIA
        {
            get { return m_maxdia; }
            set
            {
                if (m_maxdia != value)
                {
                    m_maxdia = value;
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
        /// Gets or sets el valor de: GRABO.
        /// </summary>
        public String GRABO
        {
            get { return m_grabo; }
            set
            {
                if (m_grabo != value)
                {
                    m_grabo = value;
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
        /// Gets or sets el valor de: IDSYNC.
        /// </summary>
        public Int64 IDSYNC
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