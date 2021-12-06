using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class WorkersLocal
    {
        #region [ Variables ]
        private String m_rut;
        private String m_division;
        private Int32 m_lote;
        private String m_empresa;
        private String m_tipopase;
        private String m_finipase;
        private String m_ffinpase;
        private String m_fecharla;
        private String m_autor;
        private String m_quien;
        private String m_validado;
        private String m_ost;
        private String m_tipocontrato;
        private String m_conductor;
        private String m_fechamod;
        private String m_horamod;
        private String m_alimentacion;
        private Nullable<Int64> m_idsync;
        private String m_idgerencia;
        private String m_estadocertificacion;
        private String m_remu;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase WorkersLocal.
        /// </summary>
        public WorkersLocal()
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
        /// Gets or sets el valor de: LOTE.
        /// </summary>
        public Int32 LOTE
        {
            get { return m_lote; }
            set
            {
                if (m_lote != value)
                {
                    m_lote = value;
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
        /// Gets or sets el valor de: TIPOPASE.
        /// </summary>
        public String TIPOPASE
        {
            get { return m_tipopase; }
            set
            {
                if (m_tipopase != value)
                {
                    m_tipopase = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FINIPASE.
        /// </summary>
        public String FINIPASE
        {
            get { return m_finipase; }
            set
            {
                if (m_finipase != value)
                {
                    m_finipase = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FFINPASE.
        /// </summary>
        public String FFINPASE
        {
            get { return m_ffinpase; }
            set
            {
                if (m_ffinpase != value)
                {
                    m_ffinpase = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FECHARLA.
        /// </summary>
        public String FECHARLA
        {
            get { return m_fecharla; }
            set
            {
                if (m_fecharla != value)
                {
                    m_fecharla = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: AUTOR.
        /// </summary>
        public String AUTOR
        {
            get { return m_autor; }
            set
            {
                if (m_autor != value)
                {
                    m_autor = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: QUIEN.
        /// </summary>
        public String QUIEN
        {
            get { return m_quien; }
            set
            {
                if (m_quien != value)
                {
                    m_quien = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: VALIDADO.
        /// </summary>
        public String VALIDADO
        {
            get { return m_validado; }
            set
            {
                if (m_validado != value)
                {
                    m_validado = value;
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
        /// Gets or sets el valor de: TIPOCONTRATO.
        /// </summary>
        public String TIPOCONTRATO
        {
            get { return m_tipocontrato; }
            set
            {
                if (m_tipocontrato != value)
                {
                    m_tipocontrato = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONDUCTOR.
        /// </summary>
        public String CONDUCTOR
        {
            get { return m_conductor; }
            set
            {
                if (m_conductor != value)
                {
                    m_conductor = value;
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
        /// Gets or sets el valor de: ALIMENTACION.
        /// </summary>
        public String ALIMENTACION
        {
            get { return m_alimentacion; }
            set
            {
                if (m_alimentacion != value)
                {
                    m_alimentacion = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: IDSYNC.
        /// </summary>
        public Nullable<Int64> IDSYNC
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
        /// <summary>
        /// Gets or sets el valor de: IDGERENCIA.
        /// </summary>
        public String IDGERENCIA
        {
            get { return m_idgerencia; }
            set
            {
                if (m_idgerencia != value)
                {
                    m_idgerencia = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ESTADOCERTIFICACION.
        /// </summary>
        public String ESTADOCERTIFICACION
        {
            get { return m_estadocertificacion; }
            set
            {
                if (m_estadocertificacion != value)
                {
                    m_estadocertificacion = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: REMU.
        /// </summary>
        public String REMU
        {
            get { return m_remu; }
            set
            {
                if (m_remu != value)
                {
                    m_remu = value;
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
