using System;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Ccostos
    {

        #region [ Variables ]

        private String m_empresa;
        private String m_ccosto;
        private String m_descripcion;
        private String m_activo;
        private String m_fechamod;
        private String m_horamod;
        private String m_grabo;
        private String m_responsable;
        private String m_localasistencia;

        #endregion

        #region [ Constructores ]

        /// <summary>
        /// Inicializar una nueva instancia de la clase Clinica.
        /// </summary>
        public Ccostos()
        { }

        #endregion

        #region [ Propiedades ]

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
        /// Gets or sets el valor de: RESPONSABLE.
        /// </summary>
        public String RESPONSABLE
        {
            get { return m_responsable; }
            set
            {
                if (m_responsable != value)
                {
                    m_responsable = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: LOCALASISTENCIA.
        /// </summary>
        public String LOCALASISTENCIA
        {
            get { return m_localasistencia; }
            set
            {
                if (m_localasistencia != value)
                {
                    m_localasistencia = value;
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
