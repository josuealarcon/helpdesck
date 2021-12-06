using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Tab_Reservasico
    {

        #region [ Variables ]
        private Decimal m_id;
        private String m_horaini;
        private String m_horafin;
        private String m_horaini_col;
        private String m_horafin_col;
        private Nullable<Int32> m_funcporhora;
        private Nullable<Int32> m_tiemporeserva;
        private Nullable<Int32> m_tiemporenueva;
        private String m_activo;
        private String m_fechamod;
        private String m_horamod;
        private String m_lun;
        private String m_mar;
        private String m_mie;
        private String m_jue;
        private String m_vie;
        private String m_sab;
        private String m_dom;
        private Nullable<Int32> m_tiempocancela;
        private String m_fechalimite;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Cert_Auditoria.
        /// </summary>
        public Tab_Reservasico()
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
        /// Gets or sets el valor de: HORAINI_COL.
        /// </summary>
        public String HORAINI_COL
        {
            get { return m_horaini_col; }
            set
            {
                if (m_horaini_col != value)
                {
                    m_horaini_col = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HORAFIN_COL.
        /// </summary>
        public String HORAFIN_COL
        {
            get { return m_horafin_col; }
            set
            {
                if (m_horafin_col != value)
                {
                    m_horafin_col = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FUNCPORHORA.
        /// </summary>
        public Nullable<Int32> FUNCPORHORA
        {
            get { return m_funcporhora; }
            set
            {
                if (m_funcporhora != value)
                {
                    m_funcporhora = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIEMPORESERVA.
        /// </summary>
        public Nullable<Int32> TIEMPORESERVA
        {
            get { return m_tiemporeserva; }
            set
            {
                if (m_tiemporeserva != value)
                {
                    m_tiemporeserva = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIEMPORENUEVA.
        /// </summary>
        public Nullable<Int32> TIEMPORENUEVA
        {
            get { return m_tiemporenueva; }
            set
            {
                if (m_tiemporenueva != value)
                {
                    m_tiemporenueva = value;
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
        /// Gets or sets el valor de: LUN.
        /// </summary>
        public String LUN
        {
            get { return m_lun; }
            set
            {
                if (m_lun != value)
                {
                    m_lun = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: MAR.
        /// </summary>
        public String MAR
        {
            get { return m_mar; }
            set
            {
                if (m_mar != value)
                {
                    m_mar = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: MIE.
        /// </summary>
        public String MIE
        {
            get { return m_mie; }
            set
            {
                if (m_mie != value)
                {
                    m_mie = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: JUE.
        /// </summary>
        public String JUE
        {
            get { return m_jue; }
            set
            {
                if (m_jue != value)
                {
                    m_jue = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: VIE.
        /// </summary>
        public String VIE
        {
            get { return m_vie; }
            set
            {
                if (m_vie != value)
                {
                    m_vie = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SAB.
        /// </summary>
        public String SAB
        {
            get { return m_sab; }
            set
            {
                if (m_sab != value)
                {
                    m_sab = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DOM.
        /// </summary>
        public String DOM
        {
            get { return m_dom; }
            set
            {
                if (m_dom != value)
                {
                    m_dom = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIEMPOCANCELA.
        /// </summary>
        public Nullable<Int32> TIEMPOCANCELA
        {
            get { return m_tiempocancela; }
            set
            {
                if (m_tiempocancela != value)
                {
                    m_tiempocancela = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FECHALIMITE.
        /// </summary>
        public String FECHALIMITE
        {
            get { return m_fechalimite; }
            set
            {
                if (m_fechalimite != value)
                {
                    m_fechalimite = value;
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
