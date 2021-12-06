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
    public partial class A407_dotacion_docs_emp_2
    {
        #region [ Variables ]

        #endregion
        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Check_Checkinginghead.
        /// </summary>
        public A407_dotacion_docs_emp_2()
		{ }
        #endregion
        #region [ Propiedades ]
        public string PAIS { get; set; }
        public string EMPRESA { get; set; }
        public string PERIODO { get; set; }
        public int PERSONAS { get; set; }
        public string TIPO { get; set; }
        public string VALIDADO { get; set; }
        public string ACRONIMO { get; set; }
        public string NOMBRE { get; set; }
        public string TIPO_AUDITORIA { get; set; }
        public int PORCENTAJE_APROBACION { get; set; }
        public int ID_CERT_AUDITORIA { get; set; }
        public string COD_INTERNO_CERT { get; set; }
        public Guid? ID { get; set; }
        public Guid? ID_DOC { get; set; }
        public int ID_DOC2 { get; set; }
        public int PORCENTAJE_AUDIT { get; set; }
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
