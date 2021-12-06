using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class BonosValor
    {
        #region [ Variables ]
        private Int32 m_id_valor { get; set; }
        private Int32 m_id_bono { get; set; }
        private String m_division { get; set; }
        private Int32 m_valor { get; set; }
        private String m_pago_func { get; set; }
        private String m_ep_factura { get; set; }
        private String m_periodoini { get; set; }
        private String m_periodofin { get; set; }
        private String m_asistenciaini { get; set; }
        private String m_asistenciafin { get; set; }
        private Int32 m_porcasistencia { get; set; }
        private String m_fechamod { get; set; }
        private String m_horamod { get; set; }
        private String m_usrmod { get; set; }
        private String m_cerrado { get; set; }
        private String m_fecha_cierre { get; set; }
        private String m_hora_cierre { get; set; }
        private String m_usuario_cierre { get; set; }
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase BusDestino.
        /// </summary>
        public BonosValor()
        { }
        #endregion

        #region [ Propiedades ]
        /// <summary>
        /// Gets or sets el valor de: ID_VALOR.
        /// </summary>
        public Int32 ID_VALOR
        {
            get { return m_id_valor; }
            set
            {
                if (m_id_valor != value)
                {
                    m_id_valor = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ID_BONO.
        /// </summary>
        public Int32 ID_BONO
        {
            get { return m_id_bono; }
            set
            {
                if (m_id_bono != value)
                {
                    m_id_bono = value;
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
        /// Gets or sets el valor de: PAGO_FUNC.
        /// </summary>
        public String PAGO_FUNC
        {
            get { return m_pago_func; }
            set
            {
                if (m_pago_func != value)
                {
                    m_pago_func = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: EP_FACTURA.
        /// </summary>
        public String EP_FACTURA
        {
            get { return m_ep_factura; }
            set
            {
                if (m_ep_factura != value)
                {
                    m_ep_factura = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: PERIODOINI.
        /// </summary>
        public String PERIODOINI
        {
            get { return m_periodoini; }
            set
            {
                if (m_periodoini != value)
                {
                    m_periodoini = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: PERIODOFIN.
        /// </summary>
        public String PERIODOFIN
        {
            get { return m_periodofin; }
            set
            {
                if (m_periodofin != value)
                {
                    m_periodofin = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ASISTENCIAINI.
        /// </summary>
        public String ASISTENCIAINI
        {
            get { return m_asistenciaini; }
            set
            {
                if (m_asistenciaini != value)
                {
                    m_asistenciaini = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ASISTENCIAFIN.
        /// </summary>
        public String ASISTENCIAFIN
        {
            get { return m_asistenciafin; }
            set
            {
                if (m_asistenciafin != value)
                {
                    m_asistenciafin = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: PORCASISTENCIA.
        /// </summary>
        public Int32 PORCASISTENCIA
        {
            get { return m_porcasistencia; }
            set
            {
                if (m_porcasistencia != value)
                {
                    m_porcasistencia = value;
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

        #region [ InstanceEntity ]
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
