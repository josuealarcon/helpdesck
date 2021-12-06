using System;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Reservas_Exsico
    {

        #region [ Variables ]

        private Decimal m_id;
        private String m_empresa;
        private String m_rut;
        private String m_fechares;
        private String m_horainicio;
        private String m_horatermino;
        private Nullable<Decimal> m_tipo;
        private String m_asistio;
        private Nullable<Int32> m_motivo;
        private String m_fechasol;
        private String m_horasol;
        private String m_usuariosol;
        private String m_fechamod;
        private String m_horamod;
        private String m_aprobo;

        #endregion

        #region [ Constructores ]

        /// <summary>
        /// Inicializar una nueva instancia de la clase Cert_Auditoria.
        /// </summary>
        public Reservas_Exsico()
        { }

        #endregion

        #region [ Propiedades ]

        /// <summary>
        /// Gets or sets el valor de: ID.
        /// </summary>
        public Decimal ID
        {
            get { return m_id; }
            set
            {
                if (m_id != value)
                {
                    m_id = value;
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
        /// Gets or sets el valor de: FECHARES.
        /// </summary>
        public String FECHARES
        {
            get { return m_fechares; }
            set
            {
                if (m_fechares != value)
                {
                    m_fechares = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HORAINICIO.
        /// </summary>
        public String HORAINICIO
        {
            get { return m_horainicio; }
            set
            {
                if (m_horainicio != value)
                {
                    m_horainicio = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HORATERMINO.
        /// </summary>
        public String HORATERMINO
        {
            get { return m_horatermino; }
            set
            {
                if (m_horatermino != value)
                {
                    m_horatermino = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO.
        /// </summary>
        public Nullable<Decimal> TIPO
        {
            get { return m_tipo; }
            set
            {
                if (m_tipo != value)
                {
                    m_tipo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ASISTIO.
        /// </summary>
        public String ASISTIO
        {
            get { return m_asistio; }
            set
            {
                if (m_asistio != value)
                {
                    m_asistio = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: MOTIVO.
        /// </summary>
        public Nullable<Int32> MOTIVO
        {
            get { return m_motivo; }
            set
            {
                if (m_motivo != value)
                {
                    m_motivo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FECHASOL.
        /// </summary>
        public String FECHASOL
        {
            get { return m_fechasol; }
            set
            {
                if (m_fechasol != value)
                {
                    m_fechasol = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HORASOL.
        /// </summary>
        public String HORASOL
        {
            get { return m_horasol; }
            set
            {
                if (m_horasol != value)
                {
                    m_horasol = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: USUARIOSOL.
        /// </summary>
        public String USUARIOSOL
        {
            get { return m_usuariosol; }
            set
            {
                if (m_usuariosol != value)
                {
                    m_usuariosol = value;
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
        /// Gets or sets el valor de: APROBO.
        /// </summary>
        public String APROBO
        {
            get { return m_aprobo; }
            set
            {
                if (m_aprobo != value)
                {
                    m_aprobo = value;
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
