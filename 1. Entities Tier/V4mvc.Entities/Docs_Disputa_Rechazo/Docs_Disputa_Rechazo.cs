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
    public partial class Docs_Disputa_Rechazo 
    {
        #region [ Variables ]
        private String m_rut;
        private Nullable<Int32> m_id_doc;
        private Guid m_id;
        private String m_usuario;
        private String m_fecha;
        private String m_hora;
        private Int32 m_id_tipo_rechazo;
        private Int32 m_id_disputa;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Docs_Disputa_Rechazo.
        /// </summary>
        public Docs_Disputa_Rechazo()
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
        /// Gets or sets el valor de: ID_DOC.
        /// </summary>
        public Nullable<Int32> ID_DOC
        {
            get { return m_id_doc; }
            set
            {
                if (m_id_doc != value)
                {
                    m_id_doc = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ID.
        /// </summary>
        public Guid ID
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
        /// Gets or sets el valor de: USUARIO.
        /// </summary>
        public String USUARIO
        {
            get { return m_usuario; }
            set
            {
                if (m_usuario != value)
                {
                    m_usuario = value;
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
        /// Gets or sets el valor de: HORA.
        /// </summary>
        public String HORA
        {
            get { return m_hora; }
            set
            {
                if (m_hora != value)
                {
                    m_hora = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ID_TIPO_RECHAZO.
        /// </summary>
        public Int32 ID_TIPO_RECHAZO
        {
            get { return m_id_tipo_rechazo; }
            set
            {
                if (m_id_tipo_rechazo != value)
                {
                    m_id_tipo_rechazo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ID_DISPUTA.
        /// </summary>
        public Int32 ID_DISPUTA
        {
            get { return m_id_disputa; }
            set
            {
                if (m_id_disputa != value)
                {
                    m_id_disputa = value;
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
