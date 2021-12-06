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
    public partial class Control_Inicial
    {
        #region [ Variables ]
        private int m_codigo;
        private String m_rut;
        private String m_division;
        private String m_empresa;
        private String m_fecha;
        private String m_hora;
        private String m_declaracion;
        private String m_positivo;
        private String m_consentimiento;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Control_Inicial.
        /// </summary>
        public Control_Inicial()
        { }
        #endregion

        #region [ Propiedades ]

        /// <summary>
        /// Gets or sets el valor de: CODIGO.
        /// </summary>
        public Int32 CODIGO
        {
            get { return m_codigo; }
            set
            {
                if (m_codigo != value)
                {
                    m_codigo = value;
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
        /// Gets or sets el valor de: DECLARACION.
        /// </summary>
        public String DECLARACION
        {
            get { return m_declaracion; }
            set
            {
                if (m_declaracion != value)
                {
                    m_declaracion = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: POSITIVO.
        /// </summary>
        public String POSITIVO
        {
            get { return m_positivo; }
            set
            {
                if (m_positivo != value)
                {
                    m_positivo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONSENTIMIENTO.
        /// </summary>
        public String CONSENTIMIENTO
        {
            get { return m_consentimiento; }
            set
            {
                if (m_consentimiento != value)
                {
                    m_consentimiento = value;
                }
            }
        }

        /// <summary>
		/// Gets or sets el valor de: CONSENTIMIENTO.
		/// </summary>
		public String F00 { get; set; }
        public String F100 { get; set; }
        
        public String INICIAL { get; set; }

        public String VALF00 { get; set; }
        public String VALF100 { get; set; }
        
        public String VALINICIAL { get; set; }

        public Decimal TEMPERATURA { get; set; }
        public Decimal CTRLSATURACION { get; set; }
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
